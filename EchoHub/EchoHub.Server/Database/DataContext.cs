using Microsoft.EntityFrameworkCore;
using EchoHub.Common.Models;

namespace EchoHub.Server.Database
{
    public class DataContext : DbContext
    {

        public DbSet<HubServer> Servers { get; set; }
        public DbSet<Chat> Chats { get; set; }
        public DbSet<UserServer> UserServer { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<User> Users { get; set; }

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

        public bool verifyUser(string Name)
        {

            try
            {
                this.Users.Single(x => x.Name.Equals(Name));
                return true;
            }
            catch
            {
                return false;
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

        public bool boundServer(HubServer _server, User _user)
        {

            try
            {
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


    }

}
