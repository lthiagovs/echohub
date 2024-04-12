using EchoHub.Forms.Elements;

namespace EchoHub.Forms.Interface.Controls
{
    partial class AccountControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountControl));
            pnTop = new Panel();
            pnAccount = new Panel();
            pbUser = new RoundPictureBox();
            btnChangePassword = new Button();
            panel6 = new Panel();
            label5 = new Label();
            txtPassword = new Label();
            panel4 = new Panel();
            label2 = new Label();
            txtEmail = new Label();
            panel3 = new Panel();
            label4 = new Label();
            txtName = new Label();
            btnChangeName = new Button();
            panel5 = new Panel();
            btnLogout = new Button();
            pnTop.SuspendLayout();
            pnAccount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // pnTop
            // 
            pnTop.BackColor = Color.FromArgb(55, 55, 55);
            pnTop.Controls.Add(pnAccount);
            pnTop.Dock = DockStyle.Top;
            pnTop.Location = new Point(30, 20);
            pnTop.Name = "pnTop";
            pnTop.Padding = new Padding(20);
            pnTop.Size = new Size(804, 200);
            pnTop.TabIndex = 0;
            // 
            // pnAccount
            // 
            pnAccount.BackColor = Color.FromArgb(50, 50, 50);
            pnAccount.Controls.Add(pbUser);
            pnAccount.Controls.Add(btnChangePassword);
            pnAccount.Controls.Add(panel6);
            pnAccount.Controls.Add(panel4);
            pnAccount.Controls.Add(panel3);
            pnAccount.Controls.Add(btnChangeName);
            pnAccount.Dock = DockStyle.Fill;
            pnAccount.Location = new Point(20, 20);
            pnAccount.Name = "pnAccount";
            pnAccount.Padding = new Padding(10);
            pnAccount.Size = new Size(764, 160);
            pnAccount.TabIndex = 1;
            // 
            // pbUser
            // 
            pbUser.BackgroundImage = (Image)resources.GetObject("pbUser.BackgroundImage");
            pbUser.BackgroundImageLayout = ImageLayout.Stretch;
            pbUser.Cursor = Cursors.Hand;
            pbUser.Dock = DockStyle.Left;
            pbUser.Location = new Point(10, 10);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(140, 140);
            pbUser.TabIndex = 13;
            pbUser.TabStop = false;
            pbUser.Click += pbUser_Click;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChangePassword.BackColor = Color.FromArgb(45, 45, 45);
            btnChangePassword.Cursor = Cursors.Hand;
            btnChangePassword.FlatAppearance.BorderSize = 0;
            btnChangePassword.FlatStyle = FlatStyle.Flat;
            btnChangePassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangePassword.ForeColor = Color.White;
            btnChangePassword.Location = new Point(660, 117);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(84, 32);
            btnChangePassword.TabIndex = 12;
            btnChangePassword.Text = "Alterar";
            btnChangePassword.UseVisualStyleBackColor = false;
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(label5);
            panel6.Controls.Add(txtPassword);
            panel6.Location = new Point(349, 102);
            panel6.Name = "panel6";
            panel6.Size = new Size(254, 40);
            panel6.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Top;
            label5.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(224, 224, 224);
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(66, 21);
            label5.TabIndex = 10;
            label5.Text = "SENHA:";
            // 
            // txtPassword
            // 
            txtPassword.AutoSize = true;
            txtPassword.Dock = DockStyle.Bottom;
            txtPassword.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(0, 23);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(54, 17);
            txtPassword.TabIndex = 4;
            txtPassword.Text = "_senha_";
            // 
            // panel4
            // 
            panel4.Controls.Add(label2);
            panel4.Controls.Add(txtEmail);
            panel4.Location = new Point(349, 8);
            panel4.Name = "panel4";
            panel4.Size = new Size(254, 40);
            panel4.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Top;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(224, 224, 224);
            label2.Location = new Point(0, 0);
            label2.Name = "label2";
            label2.Size = new Size(61, 21);
            label2.TabIndex = 10;
            label2.Text = "EMAIL:";
            // 
            // txtEmail
            // 
            txtEmail.AutoSize = true;
            txtEmail.Dock = DockStyle.Bottom;
            txtEmail.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(0, 23);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(50, 17);
            txtEmail.TabIndex = 4;
            txtEmail.Text = "_email_";
            // 
            // panel3
            // 
            panel3.Controls.Add(label4);
            panel3.Controls.Add(txtName);
            panel3.Location = new Point(349, 56);
            panel3.Name = "panel3";
            panel3.Size = new Size(254, 40);
            panel3.TabIndex = 0;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Top;
            label4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(224, 224, 224);
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(61, 21);
            label4.TabIndex = 10;
            label4.Text = "NOME:";
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Dock = DockStyle.Bottom;
            txtName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(0, 23);
            txtName.Name = "txtName";
            txtName.Size = new Size(53, 17);
            txtName.TabIndex = 4;
            txtName.Text = "_nome_";
            // 
            // btnChangeName
            // 
            btnChangeName.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnChangeName.BackColor = Color.FromArgb(45, 45, 45);
            btnChangeName.Cursor = Cursors.Hand;
            btnChangeName.FlatAppearance.BorderSize = 0;
            btnChangeName.FlatStyle = FlatStyle.Flat;
            btnChangeName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnChangeName.ForeColor = Color.White;
            btnChangeName.Location = new Point(660, 66);
            btnChangeName.Name = "btnChangeName";
            btnChangeName.Size = new Size(84, 32);
            btnChangeName.TabIndex = 7;
            btnChangeName.Text = "Alterar";
            btnChangeName.UseVisualStyleBackColor = false;
            btnChangeName.Click += btnChangeName_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(btnLogout);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(30, 220);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(10);
            panel5.Size = new Size(804, 211);
            panel5.TabIndex = 1;
            // 
            // btnLogout
            // 
            btnLogout.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnLogout.BackColor = Color.Crimson;
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(624, 13);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(160, 32);
            btnLogout.TabIndex = 13;
            btnLogout.Text = "Sair";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // AccountControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            Controls.Add(panel5);
            Controls.Add(pnTop);
            Name = "AccountControl";
            Padding = new Padding(30, 20, 30, 20);
            Size = new Size(864, 451);
            pnTop.ResumeLayout(false);
            pnAccount.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel pnTop;
        private Panel panel5;
        private Panel pnAccount;
        private Label txtName;
        private Button btnChangeName;
        private Panel panel6;
        private Label label5;
        private Label txtPassword;
        private Panel panel4;
        private Label label2;
        private Label txtEmail;
        private Panel panel3;
        private Label label4;
        private Button btnChangePassword;
        private Button button4;
        private Button btnLogout;
        private RoundPictureBox pbUser;
    }
}
