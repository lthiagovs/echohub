namespace EchoHub.Forms.Interface
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnMain = new Panel();
            pnContent = new Panel();
            pnTop = new Panel();
            btnNotification = new PictureBox();
            btnChangelog = new PictureBox();
            btnCreateServer = new PictureBox();
            btnUser = new PictureBox();
            pnLeft = new Panel();
            pnServers = new Panel();
            pnCorner = new Panel();
            label2 = new Label();
            pbLogo = new PictureBox();
            label1 = new Label();
            updateServers = new System.Windows.Forms.Timer(components);
            pnMain.SuspendLayout();
            pnTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnNotification).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnChangelog).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnCreateServer).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnUser).BeginInit();
            pnLeft.SuspendLayout();
            pnCorner.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbLogo).BeginInit();
            SuspendLayout();
            // 
            // pnMain
            // 
            pnMain.Controls.Add(pnContent);
            pnMain.Controls.Add(pnTop);
            pnMain.Controls.Add(pnLeft);
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(0, 0);
            pnMain.Name = "pnMain";
            pnMain.Size = new Size(984, 491);
            pnMain.TabIndex = 0;
            // 
            // pnContent
            // 
            pnContent.BackColor = Color.FromArgb(60, 60, 60);
            pnContent.Dock = DockStyle.Fill;
            pnContent.Location = new Point(60, 40);
            pnContent.Name = "pnContent";
            pnContent.Size = new Size(924, 451);
            pnContent.TabIndex = 3;
            // 
            // pnTop
            // 
            pnTop.BackColor = Color.FromArgb(45, 45, 45);
            pnTop.Controls.Add(btnNotification);
            pnTop.Controls.Add(btnChangelog);
            pnTop.Controls.Add(btnCreateServer);
            pnTop.Controls.Add(btnUser);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(60, 0);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(924, 40);
            pnTop.TabIndex = 2;
            // 
            // btnNotification
            // 
            btnNotification.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnNotification.BackgroundImage = (Image)resources.GetObject("btnNotification.BackgroundImage");
            btnNotification.BackgroundImageLayout = ImageLayout.Center;
            btnNotification.Cursor = Cursors.Hand;
            btnNotification.Location = new Point(855, 3);
            btnNotification.Name = "btnNotification";
            btnNotification.Size = new Size(30, 30);
            btnNotification.TabIndex = 8;
            btnNotification.TabStop = false;
            btnNotification.MouseEnter += btnNotification_MouseEnter;
            btnNotification.MouseLeave += btnNotification_MouseLeave;
            // 
            // btnChangelog
            // 
            btnChangelog.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChangelog.BackgroundImage = (Image)resources.GetObject("btnChangelog.BackgroundImage");
            btnChangelog.BackgroundImageLayout = ImageLayout.Center;
            btnChangelog.Cursor = Cursors.Hand;
            btnChangelog.Location = new Point(891, 3);
            btnChangelog.Name = "btnChangelog";
            btnChangelog.Size = new Size(30, 30);
            btnChangelog.TabIndex = 7;
            btnChangelog.TabStop = false;
            btnChangelog.MouseEnter += btnChangelog_MouseEnter;
            btnChangelog.MouseLeave += btnChangelog_MouseLeave;
            // 
            // btnCreateServer
            // 
            btnCreateServer.BackgroundImage = (Image)resources.GetObject("btnCreateServer.BackgroundImage");
            btnCreateServer.BackgroundImageLayout = ImageLayout.Center;
            btnCreateServer.Cursor = Cursors.Hand;
            btnCreateServer.Location = new Point(42, 4);
            btnCreateServer.Name = "btnCreateServer";
            btnCreateServer.Size = new Size(30, 30);
            btnCreateServer.TabIndex = 6;
            btnCreateServer.TabStop = false;
            btnCreateServer.Click += btnCreateServer_Click;
            btnCreateServer.MouseEnter += btnCreateServer_MouseEnter;
            btnCreateServer.MouseLeave += btnCreateServer_MouseLeave;
            // 
            // btnUser
            // 
            btnUser.BackgroundImage = (Image)resources.GetObject("btnUser.BackgroundImage");
            btnUser.BackgroundImageLayout = ImageLayout.Center;
            btnUser.Cursor = Cursors.Hand;
            btnUser.Location = new Point(6, 4);
            btnUser.Name = "btnUser";
            btnUser.Size = new Size(30, 30);
            btnUser.TabIndex = 5;
            btnUser.TabStop = false;
            btnUser.Click += btnUser_Click;
            btnUser.MouseEnter += btnUser_MouseEnter;
            btnUser.MouseLeave += btnUser_MouseLeave;
            // 
            // pnLeft
            // 
            pnLeft.BackColor = Color.FromArgb(45, 45, 45);
            pnLeft.Controls.Add(pnServers);
            pnLeft.Controls.Add(pnCorner);
            pnLeft.Dock = DockStyle.Left;
            pnLeft.Location = new Point(0, 0);
            pnLeft.Name = "pnLeft";
            pnLeft.Size = new Size(60, 491);
            pnLeft.TabIndex = 0;
            // 
            // pnServers
            // 
            pnServers.AutoScroll = true;
            pnServers.AutoScrollMinSize = new Size(20, 0);
            pnServers.Dock = DockStyle.Fill;
            pnServers.Location = new Point(0, 73);
            pnServers.Name = "pnServers";
            pnServers.Size = new Size(60, 418);
            pnServers.TabIndex = 3;
            // 
            // pnCorner
            // 
            pnCorner.Controls.Add(label2);
            pnCorner.Controls.Add(pbLogo);
            pnCorner.Controls.Add(label1);
            pnCorner.Dock = DockStyle.Top;
            pnCorner.Location = new Point(0, 0);
            pnCorner.Name = "pnCorner";
            pnCorner.Size = new Size(60, 73);
            pnCorner.TabIndex = 2;
            // 
            // label2
            // 
            label2.Font = new Font("Segoe UI", 6.25F);
            label2.ForeColor = Color.White;
            label2.Location = new Point(0, 51);
            label2.Name = "label2";
            label2.Size = new Size(60, 12);
            label2.TabIndex = 2;
            label2.Text = "Novo Servidor";
            // 
            // pbLogo
            // 
            pbLogo.BackgroundImage = (Image)resources.GetObject("pbLogo.BackgroundImage");
            pbLogo.BackgroundImageLayout = ImageLayout.Stretch;
            pbLogo.Cursor = Cursors.Hand;
            pbLogo.Location = new Point(10, 15);
            pbLogo.Name = "pbLogo";
            pbLogo.Size = new Size(40, 40);
            pbLogo.TabIndex = 0;
            pbLogo.TabStop = false;
            pbLogo.Click += pbLogo_Click;
            pbLogo.MouseEnter += pbLogo_MouseEnter;
            pbLogo.MouseLeave += pbLogo_MouseLeave;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(60, 24);
            label1.TabIndex = 1;
            label1.Text = "EchoHub";
            // 
            // updateServers
            // 
            updateServers.Interval = 1000;
            updateServers.Tick += updateServers_Tick;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 491);
            Controls.Add(pnMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            pnMain.ResumeLayout(false);
            pnTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnNotification).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnChangelog).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnCreateServer).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnUser).EndInit();
            pnLeft.ResumeLayout(false);
            pnCorner.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private Panel pnLeft;
        private Panel pnTop;
        private Panel pnContent;
        private PictureBox pbLogo;
        private Label label1;
        private Panel pnCorner;
        private Panel pnServers;
        private Label label2;
        private System.Windows.Forms.Timer updateServers;
        private PictureBox btnUser;
        private PictureBox btnCreateServer;
        private PictureBox btnChangelog;
        private PictureBox btnNotification;
    }
}