namespace EchoHub.Common.Helper
{
    public static class PackageHelper
    {

        public static MessagePackage CreatePackage(MessageType Type)
        {

            MessagePackage package = new MessagePackage();
            package.Type = Type;
            package.Informations = new List<string>();
            return package;

        }

        public static bool IsPositive(MessagePackage package)
        {
            if(package.Type == MessageType.Positive)
                return true;
            else
                return false;
        }



    }
}
