namespace EchoHub.Forms.Interface.Dialogs
{
    partial class ChangeDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChangeDialog));
            panel1 = new Panel();
            label1 = new Label();
            btnClose = new PictureBox();
            btnInvite = new Button();
            pnEmail = new Panel();
            txtChange = new TextBox();
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
            panel1.Size = new Size(340, 40);
            panel1.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(71, 25);
            label1.TabIndex = 5;
            label1.Text = "Alterar";
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
            // btnInvite
            // 
            btnInvite.BackColor = Color.CornflowerBlue;
            btnInvite.Cursor = Cursors.Hand;
            btnInvite.DialogResult = DialogResult.OK;
            btnInvite.FlatAppearance.BorderSize = 0;
            btnInvite.FlatStyle = FlatStyle.Flat;
            btnInvite.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnInvite.ForeColor = Color.White;
            btnInvite.Location = new Point(158, 109);
            btnInvite.Name = "btnInvite";
            btnInvite.Size = new Size(170, 30);
            btnInvite.TabIndex = 10;
            btnInvite.Text = "Confirmar";
            btnInvite.UseVisualStyleBackColor = false;
            // 
            // pnEmail
            // 
            pnEmail.BackColor = Color.FromArgb(60, 60, 60);
            pnEmail.Controls.Add(txtChange);
            pnEmail.Location = new Point(14, 46);
            pnEmail.Margin = new Padding(3, 3, 3, 10);
            pnEmail.Name = "pnEmail";
            pnEmail.Padding = new Padding(4, 16, 4, 4);
            pnEmail.Size = new Size(314, 50);
            pnEmail.TabIndex = 8;
            // 
            // txtChange
            // 
            txtChange.BackColor = Color.FromArgb(60, 60, 60);
            txtChange.BorderStyle = BorderStyle.None;
            txtChange.Dock = DockStyle.Fill;
            txtChange.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtChange.ForeColor = Color.White;
            txtChange.Location = new Point(4, 16);
            txtChange.MaxLength = 30;
            txtChange.Name = "txtChange";
            txtChange.Size = new Size(306, 22);
            txtChange.TabIndex = 1;
            // 
            // ChangeDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 80, 80);
            ClientSize = new Size(340, 149);
            Controls.Add(btnInvite);
            Controls.Add(pnEmail);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ChangeDialog";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ChangeDialog";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            pnEmail.ResumeLayout(false);
            pnEmail.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private PictureBox btnClose;
        private Button btnInvite;
        private Panel pnEmail;
        public TextBox txtChange;
    }
}