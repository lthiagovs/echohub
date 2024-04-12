﻿using System.Runtime.InteropServices;

namespace EchoHub.Forms.Interface.Controls
{
    public partial class ServerHub : UserControl
    {

        private readonly MainForm _target;

        private readonly int serverId;
        private readonly String Name;

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

            if (img != null)
            {

                this.btnServer.Image = img;
                this.btnServer.SizeMode = PictureBoxSizeMode.StretchImage;

            }

        }

        private void btnServer_Click(object sender, EventArgs e)
        {
            this._target.setContent(new ServerControl(this._target._user, this._target, serverId, Name));
        }
    }
}
