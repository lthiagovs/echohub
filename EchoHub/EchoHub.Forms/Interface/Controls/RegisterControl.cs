using EchoHub.Common;
using EchoHub.Common.Helper;
using EchoHub.Forms.Core;
using EchoHub.Forms.Elements;
using EchoHub.Forms.Helper;
using EchoHub.Forms.Interface.Dialogs;
using System.ComponentModel.DataAnnotations;

namespace EchoHub.Forms.Interface.Controls
{
    public partial class RegisterControl : UserControl
    {

        public RegisterControl()
        {

            InitializeComponent();
            RoundBorder.Round(pnEmail, 8);
            RoundBorder.Round(pnPassword, 8);
            RoundBorder.Round(pnRepeatPassword, 8);
            RoundBorder.Round(btnRegister, 8);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            AdviceDialog _advice;
            if (RegisterValidator.ValidateEmail(txtEmail.Text) && 
                RegisterValidator.ValidatePassword(txtPassword.Text,txtRepeatPassword.Text))
            {


                MessagePackage _send = PackageHelper.CreatePackage(MessageType.CreateAccount);
                _send.Informations.Add(txtEmail.Text);
                _send.Informations.Add(txtPassword.Text);
                _send.Informations.Add(txtEmail.Text);

                Client.Send(_send);
                MessagePackage _receive = Client.Listen();

                if (PackageHelper.IsPositive(_receive))
                {
                    _advice = new AdviceDialog("Conta criada com sucesso!");
                    _advice.ShowDialog();
                }
                else
                {
                    _advice = new AdviceDialog("Erro ao criar conta!");
                    _advice.ShowDialog();
                }


            }
            else
            {
                _advice = new AdviceDialog("Email ou senha inválidos!");
                _advice.ShowDialog();
            }

        }
    }
}
