using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Text;
using EchoHub.Common;
using EchoHub.Server.Database;

namespace EchoHub.Server.Core
{
    public class Server
    {

        private readonly ServerWorker _worker;
        private readonly ServerStatic _static;

        private int Port;
        private string IP;

        private Socket ServerListener;
        private IPEndPoint Address;

        //Informations
        private int MessagesReceived;
        private int MessagesSend;
        private int WrongPackages;

        public Server(string IP, int port=8080)
        {
            this._worker = new ServerWorker(new DataWorker(), new DataContext(), new ServerHelper());
            this._static = new ServerStatic(new ServerHelper());
            this.Port = port;
            this.IP = IP;
            this.ServerListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            this.Address = new IPEndPoint(
                IPAddress.Parse(this.IP), 
                this.Port);

            this.MessagesReceived = 0;
            this.MessagesSend = 0;
            this.WrongPackages = 0;

        }

        public void Start()
        {
            ServerListener.Bind(Address);
            ServerListener.Listen(100);
            Run();
        }

        private void Run()
        {

            this.Print();
            Socket ClientSocket = default(Socket);
            int ClientCounter = 0;
            while (true)
            {
                //Connect to another client
                ClientSocket = ServerListener.Accept();

                //Start thread to answer the user
                Thread operateThread = new Thread(new ThreadStart(() => Operate(ClientSocket)));
                operateThread.Start();
                ClientCounter++;

            }
        }

        private void Print()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("ECHOHUB SERVER ONLINE");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Messages Received: " + MessagesReceived);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Messages Send: " + MessagesSend);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Wrong Messages: " + WrongPackages);
        }

        private int Listen(Socket _client, byte[] _msg)
        {
            try
            {
                return _client.Receive(_msg);

            }
            catch
            {
                return -1;
            }
        }

        private MessagePackage? Translate(byte[] _msg, int _size)
        {

            try
            {

                string Json = (Encoding.ASCII.GetString(_msg, 0, _size));
                return JsonSerializer.Deserialize<MessagePackage>(Json);

            }
            catch
            {
                return null;
            }

        }

        private void Send(Socket _client, MessagePackage _send)
        {

            string messageClient = JsonSerializer.Serialize<MessagePackage>(_send);
            _client.Send(Encoding.ASCII.GetBytes(messageClient), 0, messageClient.Length, SocketFlags.None);

        }

        private void Operate(Socket Client)
        {
            while (true)
            {

                this.Print();

                //Get Json from Client
                byte[] ClientMsg = new byte[1000000];
                int size = Listen(Client, ClientMsg);
                if (size == -1)
                    break;


                MessagePackage? Message = Translate(ClientMsg, size);
                if (Message == null)
                    continue;

                MessagesReceived++;
                MessagePackage Send = new MessagePackage();
                Send.Informations = new List<string>();
                Send.Type = MessageType.Null;

                try
                {
                    //Operate
                    #region

                    switch(Message.Type)
                    {

                        case MessageType.CreateAccount:
                            Send.Type = _worker.createAccount(Message.Informations);
                            break;
                        case MessageType.VerifyAccount:
                            Send = _worker.verifyLogin(Message.Informations);
                            break;
                        case MessageType.CreateServer:
                            Send = _worker.createServer(Message.Informations);
                            break;
                        case MessageType.GetServers:
                            Send = _worker.getServers(Message.Informations);
                            break;
                        case MessageType.CreateChat:
                            Send = _worker.createChat(Message.Informations);
                            break;
                        case MessageType.GetChats:
                            Send = _worker.getChats(Message.Informations);
                            break;
                        case MessageType.CreateMessage:
                            Send.Type = _worker.createMessage(Message.Informations);
                            break;
                        case MessageType.GetMessages:
                            Send = _worker.getMessages(Message.Informations);
                            break;
                        case MessageType.GetFriend:
                            Send = _worker.getFriend(Message.Informations);
                            break;
                        case MessageType.BoundUser:
                            Send.Type = _worker.boundUser(Message.Informations);
                            break;
                        case MessageType.GetFriends:
                            Send = _worker.getFriends(Message.Informations);
                            break;
                        case MessageType.ChangeName:
                            Send.Type = _worker.changeName(Message.Informations);
                            break;
                        case MessageType.ChangePassword:
                            Send.Type = _worker.changePassword(Message.Informations);
                            break;
                        case MessageType.ChangeChannel:
                            Send.Type = _worker.changeChat(Message.Informations);
                            break;
                        case MessageType.ChangeServerPhoto:
                            Send.Type = _static.changeServerPhoto(Message.Informations);
                            break;
                        case MessageType.GetServerPhoto:
                            Send = _static.getServerImage(Message.Informations);
                            break;
                        case MessageType.ChangeUserPhoto:
                            Send.Type = _static.changeUserPhoto(Message.Informations);
                            break;
                        case MessageType.GetUserPhoto:
                            Send = _static.getUserImage(Message.Informations);
                            break;


                    }

                    #endregion
                    //Operate

                }
                catch //Wrong Package Received
                {
                    Send.Type = MessageType.Wrong;
                }

                if (Send.Type == MessageType.Wrong)
                    WrongPackages++;

                //Send back
                this.Send(Client, Send);
                MessagesSend++;

            }

        }

    }

}
