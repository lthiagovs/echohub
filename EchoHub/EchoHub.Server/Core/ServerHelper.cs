using EchoHub.Common;

namespace EchoHub.Server.Core
{
    public class ServerHelper
    {

        public MessagePackage createMessage()
        {
            MessagePackage _package = new MessagePackage();
            _package.Type = MessageType.Null;
            _package.Informations = new List<string>();
            return _package;
        }

    }

}
