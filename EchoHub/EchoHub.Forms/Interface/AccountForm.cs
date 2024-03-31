using EchoHub.Forms.Interface.Controls;
using System.Runtime.InteropServices;

namespace EchoHub.Forms.Interface
{
    public partial class AccountForm : Form
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

        private void setControl(Control control)
        {

            this.pnContent.Controls.Clear();
            this.pnContent.Controls.Add(control);


        }

        public AccountForm()
        {

            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;

            setControl(new LoginControl());


        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            setControl(new LoginControl());
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            setControl(new RegisterControl());
        }
    }
}
