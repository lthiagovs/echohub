namespace EchoHub.Forms.Interface
{
    partial class AccountForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountForm));
            pictureBox1 = new PictureBox();
            pbBackground = new PictureBox();
            pnMain = new Panel();
            btnLogin = new Label();
            label5 = new Label();
            btnRegister = new Label();
            label3 = new Label();
            panel4 = new Panel();
            label1 = new Label();
            label2 = new Label();
            pnContent = new Panel();
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbBackground).BeginInit();
            pnMain.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(140, 80);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(644, 431);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // pbBackground
            // 
            pbBackground.Dock = DockStyle.Fill;
            pbBackground.Location = new Point(140, 80);
            pbBackground.Name = "pbBackground";
            pbBackground.Size = new Size(644, 431);
            pbBackground.TabIndex = 2;
            pbBackground.TabStop = false;
            // 
            // pnMain
            // 
            pnMain.BackColor = Color.FromArgb(60, 60, 60);
            pnMain.Controls.Add(btnLogin);
            pnMain.Controls.Add(label5);
            pnMain.Controls.Add(btnRegister);
            pnMain.Controls.Add(label3);
            pnMain.Controls.Add(panel4);
            pnMain.Controls.Add(pnContent);
            pnMain.Dock = DockStyle.Fill;
            pnMain.Location = new Point(140, 80);
            pnMain.Name = "pnMain";
            pnMain.Padding = new Padding(10, 10, 10, 40);
            pnMain.Size = new Size(644, 431);
            pnMain.TabIndex = 0;
            // 
            // btnLogin
            // 
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.CornflowerBlue;
            btnLogin.Location = new Point(113, 409);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(56, 15);
            btnLogin.TabIndex = 7;
            btnLogin.Text = "Login";
            btnLogin.Click += btnLogin_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(10, 409);
            label5.Name = "label5";
            label5.Size = new Size(107, 15);
            label5.TabIndex = 6;
            label5.Text = "Já tem uma conta?";
            // 
            // btnRegister
            // 
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.CornflowerBlue;
            btnRegister.Location = new Point(125, 394);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(56, 15);
            btnRegister.TabIndex = 5;
            btnRegister.Text = "Cadastrar";
            btnRegister.Click += btnRegister_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(10, 394);
            label3.Name = "label3";
            label3.Size = new Size(118, 15);
            label3.TabIndex = 4;
            label3.Text = "Não tem uma conta?";
            // 
            // panel4
            // 
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label2);
            panel4.Dock = DockStyle.Top;
            panel4.Location = new Point(10, 10);
            panel4.Name = "panel4";
            panel4.Size = new Size(624, 61);
            panel4.TabIndex = 3;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Top;
            label1.Font = new Font("Segoe UI Semibold", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(624, 40);
            label1.TabIndex = 0;
            label1.Text = "Boas-vindas de volta!";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Dock = DockStyle.Bottom;
            label2.Font = new Font("Segoe UI", 12F);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(0, 40);
            label2.Name = "label2";
            label2.Size = new Size(624, 21);
            label2.TabIndex = 1;
            label2.Text = "Estamos animados em te ver novamente";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnContent
            // 
            pnContent.Dock = DockStyle.Bottom;
            pnContent.Location = new Point(10, 77);
            pnContent.Name = "pnContent";
            pnContent.Size = new Size(624, 314);
            pnContent.TabIndex = 2;
            // 
            // panel1
            // 
            panel1.BackgroundImageLayout = ImageLayout.None;
            panel1.Controls.Add(pnMain);
            panel1.Controls.Add(pbBackground);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(140, 80, 140, 50);
            panel1.Size = new Size(924, 561);
            panel1.TabIndex = 0;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(924, 561);
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(924, 541);
            Controls.Add(panel1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "AccountForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "AccountForm";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbBackground).EndInit();
            pnMain.ResumeLayout(false);
            pnMain.PerformLayout();
            panel4.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pbBackground;
        private Panel pnMain;
        private Panel panel4;
        private Label label1;
        private Label label2;
        private Panel pnContent;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Label label3;
        private Label btnRegister;
        private Label btnLogin;
        private Label label5;
    }
}