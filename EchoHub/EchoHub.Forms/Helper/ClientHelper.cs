using EchoHub.Common;
using EchoHub.Common.Helper;
using EchoHub.Forms.Core;

namespace EchoHub.Forms.Helper
{
    public static class ClientHelper
    {

        public static Image? AskUserImage(int UserID)
        {

            MessagePackage _send = PackageHelper.CreatePackage(MessageType.GetUserPhoto);
            _send.Informations.Add(UserID.ToString());
            Client.Send(_send);

            MessagePackage _receive = Client.Listen();

            if (PackageHelper.IsPositive(_receive))
                return StringToImage(_receive.Informations[0]);

            return null;

        }

        public static Image? AskServerImage(int ServerID)
        {

            MessagePackage _send = PackageHelper.CreatePackage(MessageType.GetServerPhoto);
            _send.Informations.Add(ServerID.ToString());
            Client.Send(_send);

            MessagePackage _receive = Client.Listen();

            if (PackageHelper.IsPositive(_receive))
                return StringToImage(_receive.Informations[0]);

            return null;

        }

        private static Image? StringToImage(string? data)
        {

            try
            {
                byte[] image = Convert.FromBase64String(data);
                return ByteToImage(image);
            }
            catch
            {
                return null;
            }

        }

        public static Image? ByteToImage(byte[]? data)
        {
            try
            {
                using (MemoryStream _stream = new MemoryStream(data))
                {
                    return Image.FromStream(_stream);
                }

            }
            catch
            {
                return null;
            }

        }

        public static bool ValidateMessage(string Content)
        {

            if (Content.Replace(" ", "").Length > 0)
                return true;

            return false;
        }

    }

}
