using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Text;
using EchoHub.Common;
using EchoHub.Common.Models;
using EchoHub.Server.Database;
using System.Drawing;
using static System.Net.Mime.MediaTypeNames;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;

namespace EchoHub.Server.Core
{
    public static class Server
    {
        public static int Port = 8080;
        public static string IP = "26.74.172.252";

        public static Socket ServerListener = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        public static IPEndPoint Adress = new IPEndPoint(IPAddress.Parse(IP), Port);

        //Informations
        public static int MessagesReceived = 0;
        public static int MessagesSend = 0;
        public static int WrongPackages = 0;
        public static int Operations = 0;

        public static void Start()
        {
            ServerListener.Bind(Adress);
            ServerListener.Listen(100);
            Run();
        }

        public static void Run()
        {
            Console.WriteLine("ECHOHUB ONLINE!");

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

        public static void Operate(Socket Client)
        {
            while (true)
            {
                //Get Json from Client
                byte[] ClientMsg = new byte[1000000];
                int size;
                //If clients disconnect close thread
                try
                {
                    size = Client.Receive(ClientMsg);
                }
                catch
                {
                    break;

                }


                string json = (Encoding.ASCII.GetString(ClientMsg, 0, size));
                MessagePackage Message;
                MessagePackage Send = new MessagePackage();
                Send.Informations = new List<string>();
                Send.Type = MessageType.Null;

                try
                {
                    Message = JsonSerializer.Deserialize<MessagePackage>(json);
                    //Operate
                    #region

                    switch(Message.Type)
                    {

                        case MessageType.CreateAccount:
                            Send.Type = createAccount(Message.Informations);
                            break;
                        case MessageType.VerifyAccount:
                            Send = verifyLogin(Message.Informations);
                            break;
                        case MessageType.CreateServer:
                            Send = createServer(Message.Informations);
                            break;
                        case MessageType.GetServers:
                            Send = getServers(Message.Informations);
                            break;
                        case MessageType.CreateChat:
                            Send = createChat(Message.Informations);
                            break;
                        case MessageType.GetChats:
                            Send = getChats(Message.Informations);
                            break;
                        case MessageType.CreateMessage:
                            Send.Type = createMessage(Message.Informations);
                            break;
                        case MessageType.GetMessages:
                            Send = getMessages(Message.Informations);
                            break;
                        case MessageType.GetFriend:
                            Send = getFriend(Message.Informations);
                            break;
                        case MessageType.BoundUser:
                            Send.Type = boundUser(Message.Informations);
                            break;
                        case MessageType.GetFriends:
                            Send = getFriends(Message.Informations);
                            break;
                        case MessageType.ChangeName:
                            Send.Type = changeName(Message.Informations);
                            break;
                        case MessageType.ChangePassword:
                            Send.Type = changePassword(Message.Informations);
                            break;
                        case MessageType.ChangeChannel:
                            Send.Type = changeChat(Message.Informations);
                            break;
                        case MessageType.ChangeServerPhoto:
                            Send.Type = changeServerPhoto(Message.Informations);
                            break;
                        case MessageType.GetServerPhoto:
                            Send = getServerImage(Message.Informations);
                            break;
                        case MessageType.ChangeUserPhoto:
                            Send.Type = changeUserPhoto(Message.Informations);
                            break;
                        case MessageType.GetUserPhoto:
                            Send = getUserImage(Message.Informations);
                            break;


                    }

                    #endregion
                    //Operate

                }
                catch //Wrong Package Received
                {
                    Send.Type = MessageType.Wrong;
                }

                //Send back
                string messageClient = JsonSerializer.Serialize<MessagePackage>(Send);
                Client.Send(Encoding.ASCII.GetBytes(messageClient), 0, messageClient.Length, SocketFlags.None);

            }

        }

        //Operate functions
        #region
        private static bool verifyUser(string Email, string Password)
        {
            bool result;
            using(DataContext _db = new DataContext())
            {

                result = _db.verifyUser(Email, Password);

            }

            return result;
        }
       
        private static MessagePackage verifyLogin(List<string> Informations)
        {
            MessagePackage _retriev = new MessagePackage();
            _retriev.Informations = new List<string>();
            try
            {
                using (DataContext _db = new DataContext())
                {
                    User? _user = _db.getUser(Informations[0], Informations[1]);

                    if(_user!=null)
                    {
                        _retriev.Informations.Add(_user.Id.ToString());
                        _retriev.Informations.Add(_user.Name);
                        _retriev.Type = MessageType.Positive;
                    }
                    else
                    {
                        _retriev.Type = MessageType.Negative;
                    }
                }

            }
            catch
            {
                _retriev.Type = MessageType.Wrong;
            }
            return _retriev;

        }

        private static MessageType createAccount(List<string> Informations)
        {

            if (!verifyUser(Informations[2], Informations[1]))
            {
                try
                {
                    bool result;
                    User _user = new User();
                    _user.Name = Informations[0];
                    _user.Password = Informations[1];
                    _user.Email = Informations[2];
                    using (DataContext _db = new DataContext())
                    {

                        result = _db.createUser(_user.Name, _user.Password, _user.Email);

                    }

                    if (result)
                        return MessageType.Positive;
                    else
                        return MessageType.Negative;


                }
                catch
                {
                    return MessageType.Wrong;
                }

            }
            return MessageType.Negative;
        }

        private static MessagePackage createServer(List<string> Informations)
        {
            MessagePackage _retriev = new MessagePackage();
            _retriev.Informations = new List<string>();
            try
            {
                using(DataContext _db = new DataContext())
                {

                    if (_db.createServer(Informations[0], Informations[1], Informations[2]))
                    {
                        _retriev.Type = MessageType.Positive;
                        _retriev.Informations.Add(
                            _db.Servers.ToList()[_db.Servers.Count() - 1].Id.ToString()
                            );
                    }else
                        _retriev.Type = MessageType.Negative;
                }
            }
            catch
            {
                _retriev.Type =  MessageType.Wrong;
            }

            return _retriev;

        }

        private static MessagePackage getServers(List<string> Informations) 
        {

            MessagePackage _retriev = new MessagePackage();
            _retriev.Informations = new List<string>();
            List<HubServer> _servers;
            try
            {

                using (DataContext _db = new DataContext())
                {

                    _servers = _db.getServers(Convert.ToInt32(Informations[0]));

                    foreach(HubServer server in _servers)
                    {
                        _retriev.Informations.Add(server.Id.ToString());
                        _retriev.Informations.Add(server.Name);
                    }

                    _retriev.Type = MessageType.Positive;
                }
            }
            catch
            {
                _retriev.Type = MessageType.Wrong;
            }

            return _retriev;

        }
            
        private static MessagePackage createChat(List<string> Informations)
        {

            MessagePackage _retriev = new MessagePackage();
            _retriev.Informations = new List<string>();
            try
            {

                using(DataContext _db = new DataContext())
                {

                    if(_db.createChat(Convert.ToInt32(Informations[0]), Informations[1]))
                    {
                        _retriev.Informations.Add(
                            _db.Chats.ToList()[_db.Chats.Count() - 1].Id.ToString()
                            );
                        _retriev.Type = MessageType.Positive;
                    }
                    else
                    {
                        _retriev.Type = MessageType.Negative;
                    }

                }

            }
            catch
            {
                _retriev.Type = MessageType.Wrong;
            }
            return _retriev;

        }

        private static MessagePackage getChats(List<string> Informations)
        {

            MessagePackage _retriev = new MessagePackage();
            _retriev.Informations = new List<string>();

            try
            {

                using(DataContext _db = new DataContext())
                {

                    List<Chat> _chats = _db.getChats(Convert.ToInt32(Informations[0]));
                    foreach(Chat chat in _chats)
                    {
                        _retriev.Informations.Add(chat.Id.ToString());
                        _retriev.Informations.Add(chat.Name);

                    }

                }
                _retriev.Type = MessageType.Positive;

            }
            catch
            {
                _retriev.Type = MessageType.Wrong;
            }


            return _retriev;

        }
        
        private static MessageType createMessage(List<string> Informations)
        {

            try
            {

                using(DataContext _db = new DataContext())
                {

                    if (_db.createMessage(Convert.ToInt32(Informations[0]), Convert.ToInt32(Informations[1]), Informations[2]))
                    {
                        return MessageType.Positive;
                    }
                    else
                    {
                        return MessageType.Negative;
                    }

                }

            }
            catch
            {
                return MessageType.Wrong;
            }

        }
        
        private static MessagePackage getMessages(List<string> Informations)
        {
            MessagePackage _retriev = new MessagePackage();
            _retriev.Informations = new List<string>();
            try
            {
                using(DataContext _db = new DataContext())
                {

                    List<Message> _messages = _db.getMessages(Convert.ToInt32(Informations[0]));
                    foreach(Message message in _messages)
                    {
                        _retriev.Informations.Add(message.Content);
                        _retriev.Informations.Add(message._User.Name);
                        _retriev.Informations.Add(message._User.Id.ToString());
                    }

                }
                _retriev.Type = MessageType.Positive;

            }
            catch
            {
                _retriev.Type = MessageType.Wrong;
            }

            return _retriev;
        }

        private static MessagePackage getFriend(List<string> Informations)
        {
            MessagePackage _retriev = new MessagePackage();
            _retriev.Informations = new List<string>();

            try
            {

                using(DataContext _db = new DataContext())
                {
                    User? _friend = _db.verifyFriend(Informations[0]);
                    if (_friend!=null)
                    {
                        _retriev.Informations.Add(_friend.Id.ToString());
                        _retriev.Informations.Add(_friend.Name);
                        _retriev.Type = MessageType.Positive;
                    }
                    else
                    {
                        _retriev.Type = MessageType.Negative;
                    }

                }

            }
            catch
            {
                _retriev.Type = MessageType.Wrong;
            }


            return _retriev;
        }

        private static MessageType boundUser(List<string> Informations)
        {

            try
            {

                using(DataContext _db = new DataContext())
                {
                    if (_db.newBound(Convert.ToInt32(Informations[0]),Convert.ToInt32(Informations[1])))
                    {
                        return MessageType.Positive;
                    }
                    return MessageType.Negative;
                }

            }
            catch
            {
                return MessageType.Wrong;
            }

        }

        private static MessagePackage getFriends(List<string> Informations)
        {
            MessagePackage _retriev = new MessagePackage();
            _retriev.Informations = new List<string>();

            try
            {

                using(DataContext _db = new DataContext())
                {

                    List<User> _users = _db.getFriends(Convert.ToInt32(Informations[0]));

                    foreach(User user in _users)
                    {

                        _retriev.Informations.Add(user.Id.ToString());
                        _retriev.Informations.Add(user.Name);

                    }

                }
                _retriev.Type = MessageType.Positive;

            }
            catch
            {
                _retriev.Type = MessageType.Wrong;
            }

            return _retriev;
        }

        private static MessageType changeName(List<string> Informations)
        {

            try
            {

                using(DataContext _db = new DataContext())
                {

                    if (_db.changeName(Convert.ToInt32(Informations[0]), Informations[1]))
                        return MessageType.Positive;
                    else
                        return MessageType.Negative;

                }

            }
            catch
            {
                return MessageType.Wrong;
            }

        }

        private static MessageType changePassword(List<string> Informations)
        {

            try
            {

                using (DataContext _db = new DataContext())
                {

                    if (_db.changePassword(Convert.ToInt32(Informations[0]), Informations[1]))
                        return MessageType.Positive;
                    else
                        return MessageType.Negative;

                }

            }
            catch
            {
                return MessageType.Wrong;
            }

        }

        private static MessageType changeChat(List<string> Informations)
        {

            try
            {

                using (DataContext _db = new DataContext())
                {

                    if (_db.changeChannel(Convert.ToInt32(Informations[0]), Informations[1]))
                        return MessageType.Positive;
                    else
                        return MessageType.Negative;

                }

            }
            catch
            {
                return MessageType.Wrong;
            }

        }

        private static void verifyStaticFiles()
        {
            if (!Directory.Exists("Static"))
            {
                Directory.CreateDirectory("Static");
                Directory.CreateDirectory("Static\\Server");
                Directory.CreateDirectory("Static\\User");
            }
        }

        private static bool saveServerImage(byte[] img, int serverID)
        {

            try
            {
                verifyStaticFiles();
                File.WriteAllBytes("Static\\Server\\" + serverID + ".png", img);
                return true;
            }
            catch
            {
                return false;
            }

        }

        private static bool saveUserImage(byte[] img, int userID)
        {

            try
            {
                verifyStaticFiles();
                File.WriteAllBytes("Static\\User\\" + userID + ".png", img);
                return true;
            }
            catch
            {
                return false;
            }

        }

        private static MessageType changeServerPhoto(List<string> Informations)
        {

            try
            {

                byte[] _img = Convert.FromBase64String(Informations[1]);
                saveServerImage(_img, Convert.ToInt32(Informations[0]));


                return MessageType.Positive;
            }
            catch
            {
                return MessageType.Wrong;
            }

        }

        private static MessagePackage getServerImage(List<string> Informations)
        {
            MessagePackage _retriev = new MessagePackage();
            _retriev.Informations = new List<string>();

            try
            {

                verifyStaticFiles();
                int serverID = Convert.ToInt32(Informations[0]);
                if (File.Exists("Static\\Server\\" + serverID + ".png"))
                {
                    byte[] _img = File.ReadAllBytes("Static\\Server\\" + serverID + ".png");
                    _retriev.Informations.Add(Convert.ToBase64String(_img));
                    _retriev.Type = MessageType.Positive;
                }
                else
                {
                    _retriev.Type = MessageType.Negative;
                }

            }
            catch
            {
                _retriev.Type = MessageType.Wrong;
            }

            return _retriev;

        }

        private static MessageType changeUserPhoto(List<string> Informations)
        {

            try
            {

                byte[] _img = Convert.FromBase64String(Informations[1]);
                saveUserImage(_img, Convert.ToInt32(Informations[0]));


                return MessageType.Positive;
            }
            catch
            {
                return MessageType.Wrong;
            }


        }

        private static MessagePackage getUserImage(List<string> Informations)
        {
            MessagePackage _retriev = new MessagePackage();
            _retriev.Informations = new List<string>();

            try
            {

                verifyStaticFiles();
                int userID = Convert.ToInt32(Informations[0]);
                if (File.Exists("Static\\User\\" + userID + ".png"))
                {
                    byte[] _img = File.ReadAllBytes("Static\\User\\" + userID + ".png");
                    _retriev.Informations.Add(Convert.ToBase64String(_img));
                    _retriev.Type = MessageType.Positive;
                }
                else
                {
                    _retriev.Type = MessageType.Negative;
                }

            }
            catch
            {
                _retriev.Type = MessageType.Wrong;
            }

            return _retriev;

        }


        #endregion
    }

}
