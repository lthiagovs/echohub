using System.Runtime.InteropServices;

namespace EchoHub.Forms.Interface.Controls
{
    public partial class ServerHub : UserControl
    {

        private int _round = 14;
        private MainForm _target;

        private int serverId;
        private String Name;

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

        public ServerHub(MainForm _target, int serverID, string Name, Image? img)
        {
            InitializeComponent();
            this._target = _target;
            this.Name = Name;
            this.serverId = serverID;

            if(img!=null)
            {

                this.btnServer.Image = img;
                this.btnServer.SizeMode = PictureBoxSizeMode.StretchImage;

            }

        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            this._target.setContent(new ServerControl(this._target._logged, this._target, serverId, Name));
        }

        private void btnServer_MouseEnter(object sender, EventArgs e)
        {
            btnServer.BackColor = Color.FromArgb(255, 65, 65, 65);
            btnServer.BorderStyle = BorderStyle.FixedSingle;
        }

        private void btnServer_MouseLeave(object sender, EventArgs e)
        {
            btnServer.BackColor = Color.FromArgb(0, 45, 45, 45);
            btnServer.BorderStyle = BorderStyle.None;
        }
    }
}
