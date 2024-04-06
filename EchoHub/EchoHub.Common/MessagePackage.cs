﻿namespace EchoHub.Common
{
    
    public enum MessageType
    {
        Null,
        Positive,
        Negative,
        Wrong,
        CreateAccount,
        VerifyAccount,
        GetServers,
        GetChats,
        GetMessages,
        GetFriends,
        CreateServer,
        CreateChat,
        CreateMessage,
        GetFriend,
        BoundUser,
        ChangeName,
        ChangePassword,
        ChangeChannel,
        ChangeServerPhoto,
        GetServerPhoto,
        ChangeUserPhoto,
        GetUserPhoto

    }

    public class MessagePackage
    {

        public MessageType Type { get; set; }
        public List<string> Informations { get; set; }

    }

}