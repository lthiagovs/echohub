using System.Net.Sockets;
using System.Text.Json;
using System.Text;
using System.Net;
using EchoHub.Common;

namespace EchoHub.Forms.Core
{
    public static class Client
    {
        public static int Port = 8080;
        public static string IPAdress = "26.74.172.252";

        public static Socket ClientSocket;
        public static IPEndPoint Adress = new IPEndPoint(IPAddress.Parse(IPAdress), Port);

        public static void Start()
        {
            ClientSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            ClientSocket.Connect(Adress);

        }

        public static MessagePackage Listen()
        {
            try
            {
                byte[] MsgFromServer = new byte[1000000];
                int size = Client.ClientSocket.Receive(MsgFromServer);
                string json = (Encoding.ASCII.GetString(MsgFromServer, 0, size));
                return JsonSerializer.Deserialize<MessagePackage>(json);
            }
            catch
            {
                return new MessagePackage();
            }

        }

        public async static Task<MessagePackage> ListenAsync()
        {
            try
            {
                byte[] MsgFromServer = new byte[1000000];
                int size = await Client.ClientSocket.ReceiveAsync(MsgFromServer);
                string json = (Encoding.ASCII.GetString(MsgFromServer, 0, size));
                return JsonSerializer.Deserialize<MessagePackage>(json);
            }
            catch
            {
                return new MessagePackage();
            }

        }

        public static void Send(MessagePackage Message)
        {
            string messageClient = JsonSerializer.Serialize<MessagePackage>(Message);
            Client.ClientSocket.Send(Encoding.ASCII.GetBytes(messageClient), 0, messageClient.Length, SocketFlags.None);
        }

    }

}
