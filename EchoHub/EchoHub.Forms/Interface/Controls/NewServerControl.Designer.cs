namespace EchoHub.Forms.Interface.Controls
{
    partial class NewServerControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewServerControl));
            panel1 = new Panel();
            btnChangePhoto = new PictureBox();
            panel2 = new Panel();
            panel3 = new Panel();
            label1 = new Label();
            btnNewServer = new Button();
            pnEmail = new Panel();
            txtServerName = new TextBox();
            pbServer = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnChangePhoto).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            pnEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbServer).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(50, 50, 50);
            panel1.Controls.Add(btnChangePhoto);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pbServer);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(20, 20);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(583, 242);
            panel1.TabIndex = 0;
            // 
            // btnChangePhoto
            // 
            btnChangePhoto.BackColor = Color.FromArgb(80, 80, 80);
            btnChangePhoto.BackgroundImage = (Image)resources.GetObject("btnChangePhoto.BackgroundImage");
            btnChangePhoto.BackgroundImageLayout = ImageLayout.Stretch;
            btnChangePhoto.BorderStyle = BorderStyle.FixedSingle;
            btnChangePhoto.Cursor = Cursors.Hand;
            btnChangePhoto.Location = new Point(182, 182);
            btnChangePhoto.Name = "btnChangePhoto";
            btnChangePhoto.Size = new Size(40, 40);
            btnChangePhoto.TabIndex = 3;
            btnChangePhoto.TabStop = false;
            btnChangePhoto.Click += btnChangePhoto_Click;
            btnChangePhoto.MouseEnter += btnChangePhoto_MouseEnter;
            btnChangePhoto.MouseLeave += btnChangePhoto_MouseLeave;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnNewServer);
            panel2.Controls.Add(pnEmail);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(222, 20);
            panel2.Name = "panel2";
            panel2.Padding = new Padding(15);
            panel2.Size = new Size(341, 202);
            panel2.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(label1);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(15, 15);
            panel3.Name = "panel3";
            panel3.Size = new Size(311, 33);
            panel3.TabIndex = 10;
            // 
            // label1
            // 
            label1.Dock = DockStyle.Fill;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(311, 33);
            label1.TabIndex = 7;
            label1.Text = "NOME:";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnNewServer
            // 
            btnNewServer.Anchor = AnchorStyles.Top;
            btnNewServer.BackColor = Color.CornflowerBlue;
            btnNewServer.FlatAppearance.BorderSize = 0;
            btnNewServer.FlatStyle = FlatStyle.Flat;
            btnNewServer.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNewServer.ForeColor = Color.White;
            btnNewServer.Location = new Point(15, 114);
            btnNewServer.Name = "btnNewServer";
            btnNewServer.Size = new Size(308, 43);
            btnNewServer.TabIndex = 9;
            btnNewServer.Text = "Novo Servidor";
            btnNewServer.UseVisualStyleBackColor = false;
            btnNewServer.Click += btnNewServer_Click;
            // 
            // pnEmail
            // 
            pnEmail.Anchor = AnchorStyles.Top;
            pnEmail.BackColor = Color.FromArgb(45, 45, 45);
            pnEmail.Controls.Add(txtServerName);
            pnEmail.Location = new Point(15, 51);
            pnEmail.Margin = new Padding(3, 3, 3, 10);
            pnEmail.Name = "pnEmail";
            pnEmail.Padding = new Padding(4, 16, 4, 4);
            pnEmail.Size = new Size(305, 50);
            pnEmail.TabIndex = 8;
            // 
            // txtServerName
            // 
            txtServerName.BackColor = Color.FromArgb(45, 45, 45);
            txtServerName.BorderStyle = BorderStyle.None;
            txtServerName.Dock = DockStyle.Fill;
            txtServerName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtServerName.ForeColor = Color.White;
            txtServerName.Location = new Point(4, 16);
            txtServerName.MaxLength = 30;
            txtServerName.Name = "txtServerName";
            txtServerName.Size = new Size(297, 22);
            txtServerName.TabIndex = 1;
            // 
            // pbServer
            // 
            pbServer.BackgroundImage = (Image)resources.GetObject("pbServer.BackgroundImage");
            pbServer.BackgroundImageLayout = ImageLayout.Stretch;
            pbServer.BorderStyle = BorderStyle.FixedSingle;
            pbServer.Dock = DockStyle.Left;
            pbServer.Location = new Point(20, 20);
            pbServer.Name = "pbServer";
            pbServer.Size = new Size(202, 202);
            pbServer.TabIndex = 1;
            pbServer.TabStop = false;
            // 
            // NewServerControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            Controls.Add(panel1);
            Name = "NewServerControl";
            Padding = new Padding(20);
            Size = new Size(623, 282);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnChangePhoto).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            pnEmail.ResumeLayout(false);
            pnEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbServer).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbServer;
        private Panel panel2;
        private Label label1;
        private Panel pnEmail;
        private TextBox txtServerName;
        private Panel panel3;
        private Button btnNewServer;
        private PictureBox btnChangePhoto;
    }
}
