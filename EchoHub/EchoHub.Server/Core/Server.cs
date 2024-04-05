﻿using System.Net;
using System.Net.Sockets;
using System.Text.Json;
using System.Text;
using EchoHub.Common;
using EchoHub.Common.Models;
using EchoHub.Server.Database;

namespace EchoHub.Server.Core
{
    public static class Server
    {
        public static int Port = 8080;
        public static string IP = "127.0.0.1";

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
            Console.WriteLine("NSM SERVER ONLINE!");

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
                            Send.Type = verifyLogin(Message.Informations);
                            break;
                        case MessageType.CreateServer:
                            Send = createServer(Message.Informations);
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

        private static bool verifyUser(string Email, string Password)
        {
            bool result;
            using(DataContext _db = new DataContext())
            {

                result = _db.verifyUser(Email, Password);

            }

            return result;
        }
       
        private static MessageType verifyLogin(List<string> Informations)
        {

            if (verifyUser(Informations[0], Informations[1]))
                return MessageType.Positive;
            else
                return MessageType.Negative;

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

    }

}
