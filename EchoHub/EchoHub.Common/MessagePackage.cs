namespace EchoHub.Common
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
        GetFriends,
        CreateServer,
        CreateChat,

    }

    public class MessagePackage
    {

        public MessageType Type { get; set; }
        public List<string> Informations { get; set; }

    }

}