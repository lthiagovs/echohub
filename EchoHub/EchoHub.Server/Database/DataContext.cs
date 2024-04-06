using Microsoft.EntityFrameworkCore;
using EchoHub.Common.Models;
using System.Xml.Linq;

namespace EchoHub.Server.Database
{
    public class DataContext : DbContext
    {

        public DbSet<HubServer> Servers { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<UserServer> UserServer { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<Notification> Notifications { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {

            var connection = "server=127.0.0.1;port=3306;database=echohub;uid=root;password=1234";
            options.UseMySql(connection,ServerVersion.AutoDetect(connection));
        }

        public bool createUser(string Name, string Password, string Email)
        {

            try
            {

                User _user = new User();
                _user.Name = Name;
                _user.Password = Password;
                _user.Email = Email;

                this.Users.Add(_user);
                this.SaveChanges();

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
                this.Users.Single(x => x.Email.Equals(Email));
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
                return Users.Single(x => x.Email.Equals(Email));

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
                this.Users.Single(x=> x.Email.Equals(Email) && x.Password.Equals(Password));
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
                return this.Users.Single(
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
                UserServer _test = this.UserServer.Single(x => x.UserId == userID && x.ServerId == serverID); 
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

                this.UserServer.Add(_bound);
                this.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }

        public bool newBound(int UserID, int ServerID)
        {
            if(!isBound(ServerID, UserID))
            {
                UserServer _bound = new UserServer();
                _bound.ServerId = ServerID;
                _bound.UserId = UserID; 
                this.UserServer.Add(_bound);
                this.SaveChanges();
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

                this.Servers.Add(_server);

                User? _user = getUser(Email, Password);
                if(_user!=null)
                    boundServer(_server, _user);

                this.SaveChanges();

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
                return this.Users.Single(
                    x=>x.Email.Equals(Email)
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
                _chat._Server = this.Servers.Single(x=>x.Id == ServerID);
                this.Chats.Add(_chat);
                this.SaveChanges();

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

            _chats = this.Chats.Where(x => x.ServerId == ServerID).ToList();

            return _chats;

        }

        public List<HubServer> getServers(int UserId)
        {

            List<HubServer> _servers = new List<HubServer>();
            List<UserServer> _bounds = this.UserServer.Where(x=>x.UserId==UserId).ToList();
            
            foreach(UserServer bound in _bounds)
            {
                try
                {
                    _servers.Add(this.Servers.Single(x => x.Id == bound.ServerId));
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
                this.Messages.Add(_message);
                this.SaveChanges();
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

            _messages = this.Messages.Where(x => x.ChatId == ChatId).ToList();

            foreach(Message message in _messages)
            {

                message._User = this.Users.Single(x => x.Id == message.UserID);

            }

            return _messages;
        }

        public List<User> getFriends(int ServerId)
        {
            List<User> _users = new List<User>();
            List<UserServer> _bounds = this.UserServer.Where(x => x.ServerId == ServerId).ToList();

            foreach (UserServer bound in _bounds)
            {
                try
                {
                    _users.Add(this.Users.Single(x => x.Id == bound.UserId));
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

                User _user = this.Users.Single(x => x.Id == UserID);
                _user.Name = Name;
                this.Users.Attach(_user);
                this.Entry(_user).State = EntityState.Modified;
                this.SaveChanges();
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
                User _user = this.Users.Single(x => x.Id == UserID);
                _user.Password = Password;
                this.Users.Attach(_user);
                this.Entry(_user).State = EntityState.Modified;
                this.SaveChanges();
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

                Chat _chat = this.Chats.Single(x => x.Id == ChannelID);
                _chat.Name = Name;
                this.Chats.Attach(_chat);
                this.Entry(_chat).State = EntityState.Modified;
                this.SaveChanges();
                return true;

            }
            catch
            {
                return false;
            }

        }

    }

}
