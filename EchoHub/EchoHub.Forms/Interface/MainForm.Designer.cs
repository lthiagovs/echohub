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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            pnMain = new Panel();
            pnContent = new Panel();
            pnTop = new Panel();
            pnLeft = new Panel();
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pnServers = new Panel();
            pnMain.SuspendLayout();
            pnLeft.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
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
            pnContent.Location = new Point(120, 40);
            pnContent.Name = "pnContent";
            pnContent.Size = new Size(864, 451);
            pnContent.TabIndex = 3;
            // 
            // pnTop
            // 
            pnTop.BackColor = Color.FromArgb(45, 45, 45);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(120, 0);
            pnTop.Name = "pnTop";
            pnTop.Size = new Size(864, 40);
            pnTop.TabIndex = 2;
            // 
            // pnLeft
            // 
            pnLeft.BackColor = Color.FromArgb(45, 45, 45);
            pnLeft.Controls.Add(pnServers);
            pnLeft.Controls.Add(panel1);
            pnLeft.Dock = DockStyle.Left;
            pnLeft.Location = new Point(0, 0);
            pnLeft.Name = "pnLeft";
            pnLeft.Size = new Size(120, 491);
            pnLeft.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(120, 73);
            panel1.TabIndex = 2;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(0, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(60, 60);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(56, 0);
            label1.Name = "label1";
            label1.Size = new Size(61, 64);
            label1.TabIndex = 1;
            label1.Text = "EchoHub";
            // 
            // pnServers
            // 
            pnServers.Dock = DockStyle.Fill;
            pnServers.Location = new Point(0, 73);
            pnServers.Name = "pnServers";
            pnServers.Size = new Size(120, 418);
            pnServers.TabIndex = 3;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 491);
            Controls.Add(pnMain);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainForm";
            Text = "MainForm";
            pnMain.ResumeLayout(false);
            pnLeft.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnMain;
        private Panel pnLeft;
        private Panel pnTop;
        private Panel pnContent;
        private PictureBox pictureBox1;
        private Label label1;
        private Panel panel1;
        private Panel pnServers;
    }
}