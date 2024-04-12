using EchoHub.Common.Models;
using EchoHub.Common;
using EchoHub.Server.Database;

namespace EchoHub.Server.Core
{
    public class ServerWorker
    {

        private readonly DataWorker _worker;
        private readonly DataContext _context;
        private readonly ServerHelper _helper;

        public ServerWorker(DataWorker _worker, DataContext _context, ServerHelper _helper)
        {
            this._worker = _worker;
            this._context = _context;
            this._helper = _helper;
        }

        private bool verifyUser(string Email, string Password)
        {
            bool result;

            result = _worker.verifyUser(Email, Password);

            return result;
        }

        public MessagePackage verifyLogin(List<string> Informations)
        {
            MessagePackage _retriev = _helper.createMessage();
            try
            {
                User? _user = _worker.getUser(Informations[0], Informations[1]);

                if (_user != null)
                {
                    _retriev.Informations.Add(_user.Id.ToString());
                    _retriev.Informations.Add(_user.Name);
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

        public MessageType createAccount(List<string> Informations)
        {

            if (!verifyUser(Informations[2], Informations[1]))
            {
                try
                {
                    bool result;
                    User _user = new User();
                    _user.Name = Informations[0];
                    _user.Password = Informations[1];
                    _user.Email = Informations[2];
                    _user.Email = Informations[2];
                    using (DataContext _db = new DataContext())
                    {

                        result = _worker.createUser(_user.Name, _user.Password, _user.Email);

                    }

                    if (result)
                        return MessageType.Positive;
                    else
                        return MessageType.Negative;


                }
                catch
                {
                    return MessageType.Wrong;
                }

            }
            return MessageType.Negative;
        }

        public MessagePackage createServer(List<string> Informations)
        {
            MessagePackage _retriev = _helper.createMessage();
            try
            {

                if (_worker.createServer(Informations[0], Informations[1], Informations[2]))
                {
                    _retriev.Type = MessageType.Positive;
                    _retriev.Informations.Add(
                        _context.Servers.ToList()[_context.Servers.Count() - 1].Id.ToString()
                        );
                }
                else
                    _retriev.Type = MessageType.Negative;
            }
            catch
            {
                _retriev.Type = MessageType.Wrong;
            }

            return _retriev;

        }

        public MessagePackage getServers(List<string> Informations)
        {

            MessagePackage _retriev = _helper.createMessage();
            List<HubServer> _servers;
            try
            {

                _servers = _worker.getServers(Convert.ToInt32(Informations[0]));

                foreach (HubServer server in _servers)
                {
                    _retriev.Informations.Add(server.Id.ToString());
                    _retriev.Informations.Add(server.Name);
                }

                _retriev.Type = MessageType.Positive;
            }
            catch
            {
                _retriev.Type = MessageType.Wrong;
            }

            return _retriev;

        }

        public MessagePackage createChat(List<string> Informations)
        {

            MessagePackage _retriev = _helper.createMessage();
            _retriev.Informations = new List<string>();
            try
            {

                if (_worker.createChat(Convert.ToInt32(Informations[0]), Informations[1]))
                {
                    _retriev.Informations.Add(
                        _context.Chats.ToList()[_context.Chats.Count() - 1].Id.ToString()
                        );
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

        public MessagePackage getChats(List<string> Informations)
        {

            MessagePackage _retriev = _helper.createMessage();
            _retriev.Informations = new List<string>();

            try
            {

                List<Chat> _chats = _worker.getChats(Convert.ToInt32(Informations[0]));
                foreach (Chat chat in _chats)
                {
                    _retriev.Informations.Add(chat.Id.ToString());
                    _retriev.Informations.Add(chat.Name);

                }

                _retriev.Type = MessageType.Positive;

            }
            catch
            {
                _retriev.Type = MessageType.Wrong;
            }


            return _retriev;

        }

        public MessageType createMessage(List<string> Informations)
        {

            try
            {

                if (_worker.createMessage(Convert.ToInt32(Informations[0]), Convert.ToInt32(Informations[1]), Informations[2]))
                {
                    return MessageType.Positive;
                }
                else
                {
                    return MessageType.Negative;
                }

            }
            catch
            {
                return MessageType.Wrong;
            }

        }

        public MessagePackage getMessages(List<string> Informations)
        {
            MessagePackage _retriev = _helper.createMessage();
            _retriev.Informations = new List<string>();
            try
            {

                List<Message> _messages = _worker.getMessages(Convert.ToInt32(Informations[0]));
                foreach (Message message in _messages)
                {
                    _retriev.Informations.Add(message.Content);
                    _retriev.Informations.Add(message._User.Name);
                    _retriev.Informations.Add(message._User.Id.ToString());
                }

                _retriev.Type = MessageType.Positive;

            }
            catch
            {
                _retriev.Type = MessageType.Wrong;
            }

            return _retriev;
        }

        public MessagePackage getFriend(List<string> Informations)
        {
            MessagePackage _retriev = _helper.createMessage();
            _retriev.Informations = new List<string>();

            try
            {

                User? _friend = _worker.verifyFriend(Informations[0]);
                if (_friend != null)
                {
                    _retriev.Informations.Add(_friend.Id.ToString());
                    _retriev.Informations.Add(_friend.Name);
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

        public MessageType boundUser(List<string> Informations)
        {

            try
            {

                if (_worker.newBound(Convert.ToInt32(Informations[0]), Convert.ToInt32(Informations[1])))
                {
                    return MessageType.Positive;
                }
                return MessageType.Negative;

            }
            catch
            {
                return MessageType.Wrong;
            }

        }

        public MessagePackage getFriends(List<string> Informations)
        {
            MessagePackage _retriev = _helper.createMessage();

            try
            {

                List<User> _users = _worker.getFriends(Convert.ToInt32(Informations[0]));

                foreach (User user in _users)
                {

                    _retriev.Informations.Add(user.Id.ToString());
                    _retriev.Informations.Add(user.Name);

                }
                _retriev.Type = MessageType.Positive;

            }
            catch
            {
                _retriev.Type = MessageType.Wrong;
            }

            return _retriev;
        }

        public MessageType changeName(List<string> Informations)
        {

            try
            {

                if (_worker.changeName(Convert.ToInt32(Informations[0]), Informations[1]))
                    return MessageType.Positive;
                else
                    return MessageType.Negative;

            }
            catch
            {
                return MessageType.Wrong;
            }

        }

        public MessageType changePassword(List<string> Informations)
        {

            try
            {

                if (_worker.changePassword(Convert.ToInt32(Informations[0]), Informations[1]))
                    return MessageType.Positive;
                else
                    return MessageType.Negative;

            }
            catch
            {
                return MessageType.Wrong;
            }

        }

        public MessageType changeChat(List<string> Informations)
        {

            try
            {

                if (_worker.changeChannel(Convert.ToInt32(Informations[0]), Informations[1]))
                    return MessageType.Positive;
                else
                    return MessageType.Negative;

            }
            catch
            {
                return MessageType.Wrong;
            }

        }


    }

}
