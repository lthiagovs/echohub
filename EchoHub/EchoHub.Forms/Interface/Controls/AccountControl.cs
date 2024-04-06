using EchoHub.Common.Models;

namespace EchoHub.Forms.Interface.Controls
{
    public partial class AccountControl : UserControl
    {
        private User _logged;
        public AccountControl(User _user)
        {
            InitializeComponent();
            _logged = _user;
            txtEmail.Text = _user.Email;
            txtName.Text = _user.Name;
            txtPassword.Text = _user.Password;

        }
    }
}
