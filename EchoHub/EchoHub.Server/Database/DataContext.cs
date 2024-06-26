﻿using Microsoft.EntityFrameworkCore;
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


    }

}
