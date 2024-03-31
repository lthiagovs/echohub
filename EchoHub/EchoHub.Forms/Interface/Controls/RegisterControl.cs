using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EchoHub.Forms.Interface.Controls
{
    public partial class RegisterControl : UserControl
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

        public RegisterControl()
        {

            InitializeComponent();
            pnEmail.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnEmail.Width, pnEmail.Height, _round, _round));
            pnPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnPassword.Width, pnPassword.Height, _round, _round));
            pnRepeatPassword.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, pnRepeatPassword.Width, pnRepeatPassword.Height, _round, _round));
            btnRegister.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btnRegister.Width, btnRegister.Height, _round, _round));

        }

    }
}
