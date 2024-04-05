namespace EchoHub.Forms.Interface.Dialogs
{
    partial class AdviceDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdviceDialog));
            panel1 = new Panel();
            btnClose = new PictureBox();
            pictureBox2 = new PictureBox();
            txtAdvice = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClose).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(60, 60, 60);
            panel1.Controls.Add(btnClose);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(354, 40);
            panel1.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.BackgroundImage = (Image)resources.GetObject("btnClose.BackgroundImage");
            btnClose.BackgroundImageLayout = ImageLayout.Center;
            btnClose.Cursor = Cursors.Hand;
            btnClose.Location = new Point(319, 5);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 32);
            btnClose.TabIndex = 1;
            btnClose.TabStop = false;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(12, 46);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 112);
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // txtAdvice
            // 
            txtAdvice.BackColor = Color.FromArgb(80, 80, 80);
            txtAdvice.BorderStyle = BorderStyle.None;
            txtAdvice.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtAdvice.ForeColor = Color.White;
            txtAdvice.Location = new Point(118, 46);
            txtAdvice.Multiline = true;
            txtAdvice.Name = "txtAdvice";
            txtAdvice.ReadOnly = true;
            txtAdvice.ShortcutsEnabled = false;
            txtAdvice.Size = new Size(224, 112);
            txtAdvice.TabIndex = 0;
            txtAdvice.TextAlign = HorizontalAlignment.Center;
            // 
            // AdviceDialog
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(80, 80, 80);
            ClientSize = new Size(354, 170);
            Controls.Add(txtAdvice);
            Controls.Add(pictureBox2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MdiChildrenMinimizedAnchorBottom = false;
            MinimizeBox = false;
            Name = "AdviceDialog";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Aviso";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnClose).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox btnClose;
        private PictureBox pictureBox2;
        private TextBox txtAdvice;
    }
}