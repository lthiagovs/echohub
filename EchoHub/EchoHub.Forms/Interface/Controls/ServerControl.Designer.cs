namespace EchoHub.Forms.Interface.Controls
{
    partial class ServerControl
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerControl));
            panel1 = new Panel();
            pnBottom = new Panel();
            pnChat = new Panel();
            pnMessage = new Panel();
            txtChat = new TextBox();
            panel9 = new Panel();
            pictureBox4 = new PictureBox();
            btnGif = new PictureBox();
            panel8 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnConfig = new PictureBox();
            btnPhone = new PictureBox();
            btnMic = new PictureBox();
            txtUserName = new Label();
            pbUser = new PictureBox();
            pnLeft = new Panel();
            pnChannel = new Panel();
            pnTitle = new Panel();
            btnInvite = new Button();
            btnCreateChat = new Button();
            btnServer = new Button();
            pnUser = new Panel();
            pnMessages = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            txtChatName = new Label();
            titleTimer = new System.Windows.Forms.Timer(components);
            panel1.SuspendLayout();
            pnBottom.SuspendLayout();
            pnChat.SuspendLayout();
            pnMessage.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnGif).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnConfig).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            pnLeft.SuspendLayout();
            pnTitle.SuspendLayout();
            panel4.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(pnBottom);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 381);
            panel1.Name = "panel1";
            panel1.Size = new Size(864, 70);
            panel1.TabIndex = 0;
            // 
            // pnBottom
            // 
            pnBottom.Controls.Add(pnChat);
            pnBottom.Dock = DockStyle.Fill;
            pnBottom.Location = new Point(190, 0);
            pnBottom.Name = "pnBottom";
            pnBottom.Padding = new Padding(10);
            pnBottom.Size = new Size(674, 70);
            pnBottom.TabIndex = 1;
            // 
            // pnChat
            // 
            pnChat.BackColor = Color.FromArgb(55, 55, 55);
            pnChat.Controls.Add(pnMessage);
            pnChat.Controls.Add(panel9);
            pnChat.Controls.Add(panel8);
            pnChat.Dock = DockStyle.Fill;
            pnChat.Location = new Point(10, 10);
            pnChat.Name = "pnChat";
            pnChat.Padding = new Padding(8);
            pnChat.Size = new Size(654, 50);
            pnChat.TabIndex = 0;
            // 
            // pnMessage
            // 
            pnMessage.BackColor = Color.FromArgb(80, 80, 80);
            pnMessage.Controls.Add(txtChat);
            pnMessage.Dock = DockStyle.Fill;
            pnMessage.Location = new Point(58, 8);
            pnMessage.Name = "pnMessage";
            pnMessage.Padding = new Padding(8);
            pnMessage.Size = new Size(498, 34);
            pnMessage.TabIndex = 2;
            // 
            // txtChat
            // 
            txtChat.BackColor = Color.FromArgb(80, 80, 80);
            txtChat.BorderStyle = BorderStyle.None;
            txtChat.Dock = DockStyle.Fill;
            txtChat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtChat.ForeColor = Color.White;
            txtChat.Location = new Point(8, 8);
            txtChat.Name = "txtChat";
            txtChat.Size = new Size(482, 22);
            txtChat.TabIndex = 0;
            txtChat.KeyPress += txtChat_KeyPress;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(55, 55, 55);
            panel9.Controls.Add(pictureBox4);
            panel9.Controls.Add(btnGif);
            panel9.Dock = DockStyle.Right;
            panel9.Location = new Point(556, 8);
            panel9.Name = "panel9";
            panel9.Size = new Size(90, 34);
            panel9.TabIndex = 1;
            // 
            // pictureBox4
            // 
            pictureBox4.BackgroundImage = (Image)resources.GetObject("pictureBox4.BackgroundImage");
            pictureBox4.BackgroundImageLayout = ImageLayout.Center;
            pictureBox4.Cursor = Cursors.Hand;
            pictureBox4.Location = new Point(49, 3);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(30, 30);
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // btnGif
            // 
            btnGif.BackgroundImage = (Image)resources.GetObject("btnGif.BackgroundImage");
            btnGif.BackgroundImageLayout = ImageLayout.Center;
            btnGif.Cursor = Cursors.Hand;
            btnGif.Location = new Point(13, 3);
            btnGif.Name = "btnGif";
            btnGif.Size = new Size(30, 30);
            btnGif.TabIndex = 5;
            btnGif.TabStop = false;
            btnGif.Click += btnGif_Click;
            // 
            // panel8
            // 
            panel8.BackColor = Color.FromArgb(55, 55, 55);
            panel8.Controls.Add(pictureBox2);
            panel8.Dock = DockStyle.Left;
            panel8.Location = new Point(8, 8);
            panel8.Margin = new Padding(3, 3, 5, 3);
            panel8.Name = "panel8";
            panel8.Size = new Size(50, 34);
            panel8.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Location = new Point(10, 3);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(30, 30);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(40, 40, 40);
            panel2.Controls.Add(btnConfig);
            panel2.Controls.Add(btnPhone);
            panel2.Controls.Add(btnMic);
            panel2.Controls.Add(txtUserName);
            panel2.Controls.Add(pbUser);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(10);
            panel2.Size = new Size(190, 70);
            panel2.TabIndex = 0;
            // 
            // btnConfig
            // 
            btnConfig.BackgroundImage = (Image)resources.GetObject("btnConfig.BackgroundImage");
            btnConfig.BackgroundImageLayout = ImageLayout.Center;
            btnConfig.Cursor = Cursors.Hand;
            btnConfig.Location = new Point(154, 31);
            btnConfig.Name = "btnConfig";
            btnConfig.Size = new Size(30, 30);
            btnConfig.TabIndex = 4;
            btnConfig.TabStop = false;
            btnConfig.Click += btnConfig_Click;
            // 
            // btnPhone
            // 
            btnPhone.BackgroundImage = (Image)resources.GetObject("btnPhone.BackgroundImage");
            btnPhone.BackgroundImageLayout = ImageLayout.Center;
            btnPhone.Cursor = Cursors.Hand;
            btnPhone.Location = new Point(102, 31);
            btnPhone.Name = "btnPhone";
            btnPhone.Size = new Size(30, 30);
            btnPhone.TabIndex = 3;
            btnPhone.TabStop = false;
            // 
            // btnMic
            // 
            btnMic.BackgroundImage = (Image)resources.GetObject("btnMic.BackgroundImage");
            btnMic.BackgroundImageLayout = ImageLayout.Center;
            btnMic.Cursor = Cursors.Hand;
            btnMic.Location = new Point(66, 31);
            btnMic.Name = "btnMic";
            btnMic.Size = new Size(30, 30);
            btnMic.TabIndex = 2;
            btnMic.TabStop = false;
            // 
            // txtUserName
            // 
            txtUserName.AutoSize = true;
            txtUserName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtUserName.ForeColor = Color.White;
            txtUserName.Location = new Point(66, 10);
            txtUserName.Name = "txtUserName";
            txtUserName.Size = new Size(52, 17);
            txtUserName.TabIndex = 1;
            txtUserName.Text = "_name_";
            // 
            // pbUser
            // 
            pbUser.BackgroundImage = (Image)resources.GetObject("pbUser.BackgroundImage");
            pbUser.BackgroundImageLayout = ImageLayout.Stretch;
            pbUser.Dock = DockStyle.Left;
            pbUser.Location = new Point(10, 10);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(50, 50);
            pbUser.TabIndex = 0;
            pbUser.TabStop = false;
            // 
            // pnLeft
            // 
            pnLeft.BackColor = Color.FromArgb(55, 55, 55);
            pnLeft.Controls.Add(pnChannel);
            pnLeft.Controls.Add(pnTitle);
            pnLeft.Dock = DockStyle.Left;
            pnLeft.Location = new Point(0, 0);
            pnLeft.Name = "pnLeft";
            pnLeft.Size = new Size(190, 381);
            pnLeft.TabIndex = 1;
            // 
            // pnChannel
            // 
            pnChannel.AutoScroll = true;
            pnChannel.Dock = DockStyle.Fill;
            pnChannel.Location = new Point(0, 40);
            pnChannel.Name = "pnChannel";
            pnChannel.Size = new Size(190, 341);
            pnChannel.TabIndex = 1;
            // 
            // pnTitle
            // 
            pnTitle.BackColor = Color.FromArgb(40, 40, 40);
            pnTitle.BorderStyle = BorderStyle.FixedSingle;
            pnTitle.Controls.Add(btnInvite);
            pnTitle.Controls.Add(btnCreateChat);
            pnTitle.Controls.Add(btnServer);
            pnTitle.Dock = DockStyle.Top;
            pnTitle.Location = new Point(0, 0);
            pnTitle.MaximumSize = new Size(190, 120);
            pnTitle.MinimumSize = new Size(190, 40);
            pnTitle.Name = "pnTitle";
            pnTitle.Size = new Size(190, 40);
            pnTitle.TabIndex = 0;
            // 
            // btnInvite
            // 
            btnInvite.BackColor = Color.FromArgb(55, 55, 55);
            btnInvite.Cursor = Cursors.Hand;
            btnInvite.FlatAppearance.BorderSize = 0;
            btnInvite.FlatStyle = FlatStyle.Flat;
            btnInvite.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInvite.ForeColor = Color.White;
            btnInvite.Location = new Point(0, 78);
            btnInvite.Name = "btnInvite";
            btnInvite.Size = new Size(190, 42);
            btnInvite.TabIndex = 2;
            btnInvite.Text = "Convidar Pessoas";
            btnInvite.UseVisualStyleBackColor = false;
            btnInvite.Click += btnInvite_Click;
            // 
            // btnCreateChat
            // 
            btnCreateChat.BackColor = Color.FromArgb(55, 55, 55);
            btnCreateChat.Cursor = Cursors.Hand;
            btnCreateChat.FlatAppearance.BorderSize = 0;
            btnCreateChat.FlatStyle = FlatStyle.Flat;
            btnCreateChat.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateChat.ForeColor = Color.White;
            btnCreateChat.Location = new Point(0, 41);
            btnCreateChat.Name = "btnCreateChat";
            btnCreateChat.Size = new Size(191, 37);
            btnCreateChat.TabIndex = 1;
            btnCreateChat.Text = "Novo Chat";
            btnCreateChat.UseVisualStyleBackColor = false;
            btnCreateChat.Click += btnCreateChat_Click;
            // 
            // btnServer
            // 
            btnServer.BackColor = Color.CornflowerBlue;
            btnServer.Cursor = Cursors.Hand;
            btnServer.FlatAppearance.BorderSize = 0;
            btnServer.FlatStyle = FlatStyle.Flat;
            btnServer.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnServer.ForeColor = Color.White;
            btnServer.Location = new Point(0, 0);
            btnServer.Name = "btnServer";
            btnServer.Size = new Size(190, 40);
            btnServer.TabIndex = 0;
            btnServer.Text = "_serverName_";
            btnServer.UseVisualStyleBackColor = false;
            btnServer.Click += btnServer_Click;
            // 
            // pnUser
            // 
            pnUser.BackColor = Color.FromArgb(55, 55, 55);
            pnUser.Dock = DockStyle.Right;
            pnUser.Location = new Point(694, 0);
            pnUser.Name = "pnUser";
            pnUser.Size = new Size(170, 381);
            pnUser.TabIndex = 2;
            // 
            // pnMessages
            // 
            pnMessages.AutoScroll = true;
            pnMessages.Dock = DockStyle.Fill;
            pnMessages.Location = new Point(0, 30);
            pnMessages.Name = "pnMessages";
            pnMessages.Size = new Size(504, 351);
            pnMessages.TabIndex = 3;
            // 
            // panel4
            // 
            panel4.Controls.Add(pnMessages);
            panel4.Controls.Add(panel5);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(190, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(504, 381);
            panel4.TabIndex = 3;
            // 
            // panel5
            // 
            panel5.Controls.Add(txtChatName);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(504, 30);
            panel5.TabIndex = 4;
            // 
            // txtChatName
            // 
            txtChatName.Dock = DockStyle.Fill;
            txtChatName.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtChatName.ForeColor = Color.White;
            txtChatName.Location = new Point(0, 0);
            txtChatName.Name = "txtChatName";
            txtChatName.Size = new Size(504, 30);
            txtChatName.TabIndex = 0;
            txtChatName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // titleTimer
            // 
            titleTimer.Interval = 10;
            titleTimer.Tick += titleTimer_Tick;
            // 
            // ServerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            Controls.Add(panel4);
            Controls.Add(pnUser);
            Controls.Add(pnLeft);
            Controls.Add(panel1);
            Name = "ServerControl";
            Size = new Size(864, 451);
            panel1.ResumeLayout(false);
            pnBottom.ResumeLayout(false);
            pnChat.ResumeLayout(false);
            pnMessage.ResumeLayout(false);
            pnMessage.PerformLayout();
            panel9.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnGif).EndInit();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnConfig).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            pnLeft.ResumeLayout(false);
            pnTitle.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pbUser;
        private Panel pnLeft;
        private Panel pnUser;
        private Panel pnMessages;
        private Panel pnBottom;
        private Panel pnChat;
        private Panel panel8;
        private Panel panel9;
        private Panel pnMessage;
        private TextBox txtChat;
        private Label txtUserName;
        private PictureBox btnMic;
        private PictureBox btnConfig;
        private PictureBox btnPhone;
        private PictureBox pictureBox2;
        private PictureBox btnGif;
        private PictureBox pictureBox4;
        private Panel pnChannel;
        private Panel panel4;
        private Panel panel5;
        public Label txtChatName;
        private Panel pnTitle;
        private Button btnServer;
        private Button btnInvite;
        private Button btnCreateChat;
        private System.Windows.Forms.Timer titleTimer;
    }
}
