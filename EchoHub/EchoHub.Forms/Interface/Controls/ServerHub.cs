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

        public ServerHub(MainForm _target, int serverID, string Name)
        {
            InitializeComponent();
            this._target = _target;
            this.Name = Name;
            this.serverId = serverID; 

        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            this._target.setContent(new ServerControl(this._target._logged,this._target,serverId,Name));
        }
    }
}
