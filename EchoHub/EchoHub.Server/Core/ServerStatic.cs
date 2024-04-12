using EchoHub.Common;

namespace EchoHub.Server.Core
{
    public class ServerStatic
    {

        private readonly ServerHelper _helper;

        public ServerStatic(ServerHelper _helper)
        {
            this._helper = _helper;
        }

        private void verifyStaticFiles()
        {
            if (!Directory.Exists("Static"))
            {
                Directory.CreateDirectory("Static");
                Directory.CreateDirectory("Static\\Server");
                Directory.CreateDirectory("Static\\User");
            }
        }

        private bool saveServerImage(byte[] img, int serverID)
        {

            try
            {
                verifyStaticFiles();
                File.WriteAllBytes("Static\\Server\\" + serverID + ".png", img);
                return true;
            }
            catch
            {
                return false;
            }

        }

        private bool saveUserImage(byte[] img, int userID)
        {

            try
            {
                verifyStaticFiles();
                File.WriteAllBytes("Static\\User\\" + userID + ".png", img);
                return true;
            }
            catch
            {
                return false;
            }

        }

        public MessageType changeServerPhoto(List<string> Informations)
        {

            try
            {

                byte[] _img = Convert.FromBase64String(Informations[1]);
                saveServerImage(_img, Convert.ToInt32(Informations[0]));


                return MessageType.Positive;
            }
            catch
            {
                return MessageType.Wrong;
            }

        }

        public MessagePackage getServerImage(List<string> Informations)
        {
            MessagePackage _retriev = _helper.createMessage();

            try
            {

                verifyStaticFiles();
                int serverID = Convert.ToInt32(Informations[0]);
                if (File.Exists("Static\\Server\\" + serverID + ".png"))
                {
                    byte[] _img = File.ReadAllBytes("Static\\Server\\" + serverID + ".png");
                    _retriev.Informations.Add(Convert.ToBase64String(_img));
                    _retriev.Type = MessageType.Positive;
                }
                else
                {
                    _retriev.Type = MessageType.Negative;
                }

            }
            catch
            {
                _retriev.Type = MessageType.Wrong;
            }

            return _retriev;

        }

        public MessageType changeUserPhoto(List<string> Informations)
        {

            try
            {

                byte[] _img = Convert.FromBase64String(Informations[1]);
                saveUserImage(_img, Convert.ToInt32(Informations[0]));


                return MessageType.Positive;
            }
            catch
            {
                return MessageType.Wrong;
            }


        }

        public MessagePackage getUserImage(List<string> Informations)
        {
            MessagePackage _retriev = _helper.createMessage();

            try
            {

                verifyStaticFiles();
                int userID = Convert.ToInt32(Informations[0]);
                if (File.Exists("Static\\User\\" + userID + ".png"))
                {
                    byte[] _img = File.ReadAllBytes("Static\\User\\" + userID + ".png");
                    _retriev.Informations.Add(Convert.ToBase64String(_img));
                    _retriev.Type = MessageType.Positive;
                }
                else
                {
                    _retriev.Type = MessageType.Negative;
                }

            }
            catch
            {
                _retriev.Type = MessageType.Wrong;
            }

            return _retriev;

        }


    }

}
