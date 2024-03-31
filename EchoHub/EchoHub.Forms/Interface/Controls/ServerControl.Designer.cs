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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerControl));
            panel1 = new Panel();
            pnBottom = new Panel();
            pnChat = new Panel();
            pnMessage = new Panel();
            textBox1 = new TextBox();
            panel9 = new Panel();
            pictureBox4 = new PictureBox();
            pictureBox3 = new PictureBox();
            panel8 = new Panel();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            btnConfig = new PictureBox();
            btnPhone = new PictureBox();
            btnMic = new PictureBox();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3 = new Panel();
            panel4 = new Panel();
            panel5 = new Panel();
            panel1.SuspendLayout();
            pnBottom.SuspendLayout();
            pnChat.SuspendLayout();
            pnMessage.SuspendLayout();
            panel9.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnConfig).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnPhone).BeginInit();
            ((System.ComponentModel.ISupportInitialize)btnMic).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            pnMessage.Controls.Add(textBox1);
            pnMessage.Dock = DockStyle.Fill;
            pnMessage.Location = new Point(58, 8);
            pnMessage.Name = "pnMessage";
            pnMessage.Padding = new Padding(8);
            pnMessage.Size = new Size(498, 34);
            pnMessage.TabIndex = 2;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(80, 80, 80);
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(8, 8);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(482, 18);
            textBox1.TabIndex = 0;
            // 
            // panel9
            // 
            panel9.BackColor = Color.FromArgb(55, 55, 55);
            panel9.Controls.Add(pictureBox4);
            panel9.Controls.Add(pictureBox3);
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
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Cursor = Cursors.Hand;
            pictureBox3.Location = new Point(13, 3);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(30, 30);
            pictureBox3.TabIndex = 5;
            pictureBox3.TabStop = false;
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
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(66, 10);
            label1.Name = "label1";
            label1.Size = new Size(52, 17);
            label1.TabIndex = 1;
            label1.Text = "_name_";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(10, 10);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(50, 50);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // panel3
            // 
            panel3.BackColor = Color.FromArgb(55, 55, 55);
            panel3.Dock = DockStyle.Left;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(190, 381);
            panel3.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.BackColor = Color.FromArgb(55, 55, 55);
            panel4.Dock = DockStyle.Right;
            panel4.Location = new Point(694, 0);
            panel4.Name = "panel4";
            panel4.Size = new Size(170, 381);
            panel4.TabIndex = 2;
            // 
            // panel5
            // 
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(190, 0);
            panel5.Name = "panel5";
            panel5.Size = new Size(504, 381);
            panel5.TabIndex = 3;
            // 
            // ServerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            Controls.Add(panel5);
            Controls.Add(panel4);
            Controls.Add(panel3);
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
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnConfig).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnPhone).EndInit();
            ((System.ComponentModel.ISupportInitialize)btnMic).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private Panel pnBottom;
        private Panel pnChat;
        private Panel panel8;
        private Panel panel9;
        private Panel pnMessage;
        private TextBox textBox1;
        private Label label1;
        private PictureBox btnMic;
        private PictureBox btnConfig;
        private PictureBox btnPhone;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
    }
}
