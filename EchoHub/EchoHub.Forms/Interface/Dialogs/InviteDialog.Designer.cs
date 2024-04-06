namespace EchoHub.Forms.Interface.Dialogs
{
    partial class InviteDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InviteDialog));
            panel1 = new Panel();
            label1 = new Label();
            btnClose = new PictureBox();
            pnEmail = new Panel();
            txtEmail = new TextBox();
            label2 = new Label();
            btnInvite = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            pnEmail.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 60, 60);
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(338, 40);
            panel1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(89, 25);
            label1.TabIndex = 5;
            label1.Text = "Convidar";
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Location = new Point(303, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // pnEmail
            // 
            pnEmail.BackColor = Color.FromArgb(60, 60, 60);
            pnEmail.Controls.Add(txtEmail);
            pnEmail.Location = new Point(12, 69);
            pnEmail.Margin = new Padding(3, 3, 3, 10);
            pnEmail.Name = "pnEmail";
            pnEmail.Padding = new Padding(4, 16, 4, 4);
            pnEmail.Size = new Size(314, 50);
            pnEmail.TabIndex = 4;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(60, 60, 60);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(4, 16);
            txtEmail.MaxLength = 30;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(306, 22);
            txtEmail.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Gainsboro;
            label2.Location = new Point(12, 45);
            label2.Name = "label2";
            label2.Size = new Size(146, 21);
            label2.TabIndex = 6;
            label2.Text = "EMAIL DO AMIGO:";
            // 
            // btnInvite
            // 
            btnInvite.BackColor = Color.CornflowerBlue;
            btnInvite.Cursor = Cursors.Hand;
            btnInvite.DialogResult = DialogResult.OK;
            btnInvite.FlatAppearance.BorderSize = 0;
            btnInvite.FlatStyle = FlatStyle.Flat;
            btnInvite.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInvite.ForeColor = Color.White;
            btnInvite.Location = new Point(156, 132);
            btnInvite.Name = "btnInvite";
            btnInvite.Size = new Size(170, 30);
            btnInvite.TabIndex = 7;
            btnInvite.Text = "Convidar";
            btnInvite.UseVisualStyleBackColor = false;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(338, 174);
            panel2.TabIndex = 8;
            // 
            // InviteDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 80, 80);
            ClientSize = new Size(338, 174);
            Controls.Add(btnInvite);
            Controls.Add(label2);
            Controls.Add(pnEmail);
            Controls.Add(panel1);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "InviteDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "InviteDialog";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            pnEmail.ResumeLayout(false);
            pnEmail.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox btnClose;
        private Panel pnEmail;
        private Label label1;
        private Label label2;
        private Button btnInvite;
        public TextBox txtEmail;
        private Panel panel2;
    }
}