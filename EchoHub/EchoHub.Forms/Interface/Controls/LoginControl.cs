using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrayNotify;

namespace EchoHub.Forms.Interface.Controls
{
    public partial class LoginControl : UserControl
    {

        private int _round = 8;
        //Round Borders
        #region
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );
        #endregion

        public LoginControl()
        {
            InitializeComponent();
            pnEmail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnEmail.Width, pnEmail.Height, _round, _round));
            pnPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnPassword.Width, pnPassword.Height, _round, _round));
            btnLogin.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnLogin.Width, btnLogin.Height, _round, _round));


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MainForm _mainForm = new MainForm();
            _mainForm.Show();
        }
    }
}
