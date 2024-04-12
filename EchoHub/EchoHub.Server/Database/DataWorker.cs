﻿using EchoHub.Common.Models;
using Microsoft.EntityFrameworkCore;

namespace EchoHub.Server.Database
{
    public class DataWorker
    {

        private readonly DataContext _context;

        public DataWorker()
        {
            _context = new DataContext();
        }

        public bool createUser(string Name, string Password, string Email)
        {

            try
            {

                User _user = new User();
                _user.Name = Name;
                _user.Password = Password;
                _user.Email = Email;

                _context.Users.Add(_user);
                _context.SaveChanges();

                return true;

            }
            catch
            {

                return false;

            }


        }

        public bool verifyUser(string Email)
        {

            try
            {
                _context.Users.Single(x => x.Email.Equals(Email));
                return true;
            }
            catch
            {
                return false;
            }

        }

        public User? verifyFriend(string Email)
        {

            try
            {
                return _context.Users.Single(x => x.Email.Equals(Email));

            }
            catch
            {
                return null;
            }

        }

        public bool verifyUser(string Email, string Password)
        {

            try
            {
                _context.Users.Single(x => x.Email.Equals(Email) && x.Password.Equals(Password));
                return true;
            }
            catch
            {
                return false;
            }

        }

        public User? getUser(string Email, string Password)
        {

            try
            {
                return _context.Users.Single(
                    x =>
                    x.Email.Equals(Email) &&
                    x.Password.Equals(Password)
                );

            }
            catch
            {
                return null;
            }

        }

        private bool isBound(int serverID, int userID)
        {

            try
            {
                UserServer _test = _context.UserServer.Single(x => x.UserId == userID && x.ServerId == serverID);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool boundServer(HubServer _server, User _user)
        {

            try
            {
                if (isBound(_server.Id, _user.Id))
                {
                    return false;
                }
                UserServer _bound = new UserServer();
                _bound._Server = _server;
                _bound._User = _user;

                _context.UserServer.Add(_bound);
                _context.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool newBound(int UserID, int ServerID)
        {
            if (!isBound(ServerID, UserID))
            {
                UserServer _bound = new UserServer();
                _bound.ServerId = ServerID;
                _bound.UserId = UserID;
                _context.UserServer.Add(_bound);
                _context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool createServer(string Name, string Email, string Password)
        {

            try
            {
                HubServer _server = new HubServer();
                _server.Name = Name;

                _context.Servers.Add(_server);

                User? _user = getUser(Email, Password);
                if (_user != null)
                    boundServer(_server, _user);

                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }

        }

        public int getUserID(string Email, string Password)
        {

            try
            {
                return _context.Users.Single(
                    x => x.Email.Equals(Email)
                    &&
                    x.Password.Equals(Password)
                    ).Id;
            }
            catch
            {
                return 0;
            }

        }

        public bool createChat(int ServerID, string Name)
        {

            try
            {

                Chat _chat = new Chat();
                _chat.Name = Name;
                _chat.ServerId = ServerID;
                _chat._Server = _context.Servers.Single(x => x.Id == ServerID);
                _context.Chats.Add(_chat);
                _context.SaveChanges();

                return true;
            }
            catch
            {
                return false;
            }

        }

        public List<Chat> getChats(int ServerID)
        {

            List<Chat> _chats = new List<Chat>();

            _chats = _context.Chats.Where(x => x.ServerId == ServerID).ToList();

            return _chats;

        }

        public List<HubServer> getServers(int UserId)
        {

            List<HubServer> _servers = new List<HubServer>();
            List<UserServer> _bounds = _context.UserServer.Where(x => x.UserId == UserId).ToList();

            foreach (UserServer bound in _bounds)
            {
                try
                {
                    _servers.Add(_context.Servers.Single(x => x.Id == bound.ServerId));
                }
                catch
                {

                }

            }

            return _servers;

        }

        public bool createMessage(int ChatId, int UserID, string Content)
        {
            try
            {

                Message _message = new Message();
                _message.ChatId = ChatId;
                _message.Content = Content;
                _message.UserID = UserID;
                _context.Messages.Add(_message);
                _context.SaveChanges();
                return true;
            }
            catch
            {

                return false;

            }
        }

        public List<Message> getMessages(int ChatId)
        {
            List<Message> _messages = new List<Message>();

            _messages = _context.Messages.Where(x => x.ChatId == ChatId).ToList();

            foreach (Message message in _messages)
            {

                message._User = _context.Users.Single(x => x.Id == message.UserID);

            }

            return _messages;
        }

        public List<User> getFriends(int ServerId)
        {
            List<User> _users = new List<User>();
            List<UserServer> _bounds = _context.UserServer.Where(x => x.ServerId == ServerId).ToList();

            foreach (UserServer bound in _bounds)
            {
                try
                {
                    _users.Add(_context.Users.Single(x => x.Id == bound.UserId));
                }
                catch
                {

                }

            }

            return _users;
        }

        public bool changeName(int UserID, string Name)
        {

            try
            {

                User _user = _context.Users.Single(x => x.Id == UserID);
                _user.Name = Name;
                _context.Users.Attach(_user);
                _context.Entry(_user).State = EntityState.Modified;
                _context.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }

        }

        public bool changePassword(int UserID, string Password)
        {

            try
            {
                User _user = _context.Users.Single(x => x.Id == UserID);
                _user.Password = Password;
                _context.Users.Attach(_user);
                _context.Entry(_user).State = EntityState.Modified;
                _context.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }

        }

        public bool changeChannel(int ChannelID, string Name)
        {

            try
            {

                Chat _chat = _context.Chats.Single(x => x.Id == ChannelID);
                _chat.Name = Name;
                _context.Chats.Attach(_chat);
                _context.Entry(_chat).State = EntityState.Modified;
                _context.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }

        }


    }

}