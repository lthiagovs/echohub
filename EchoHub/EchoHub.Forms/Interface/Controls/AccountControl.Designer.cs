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
            panel1 = new Panel();
            btnChangePhoto = new PictureBox();
            panel2 = new Panel();
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
            pbUser = new PictureBox();
            panel5 = new Panel();
            button4 = new Button();
            button3 = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnChangePhoto).BeginInit();
            panel2.SuspendLayout();
            panel6.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(55, 55, 55);
            panel1.Controls.Add(btnChangePhoto);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pbUser);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(30, 20);
            panel1.Name = "panel1";
            panel1.Padding = new Padding(20);
            panel1.Size = new Size(804, 200);
            panel1.TabIndex = 0;
            // 
            // btnChangePhoto
            // 
            btnChangePhoto.BackgroundImage = (Image)resources.GetObject("btnChangePhoto.BackgroundImage");
            btnChangePhoto.BackgroundImageLayout = ImageLayout.Stretch;
            btnChangePhoto.Cursor = Cursors.Hand;
            btnChangePhoto.Location = new Point(140, 140);
            btnChangePhoto.Name = "btnChangePhoto";
            btnChangePhoto.Size = new Size(40, 40);
            btnChangePhoto.TabIndex = 2;
            btnChangePhoto.TabStop = false;
            btnChangePhoto.Click += btnChangePhoto_Click;
            btnChangePhoto.MouseEnter += btnChangePhoto_MouseEnter;
            btnChangePhoto.MouseLeave += btnChangePhoto_MouseLeave;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(50, 50, 50);
            panel2.Controls.Add(btnChangePassword);
            panel2.Controls.Add(panel6);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(panel3);
            panel2.Controls.Add(btnChangeName);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(180, 20);
            panel2.Name = "panel2";
            panel2.Size = new Size(604, 160);
            panel2.TabIndex = 1;
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
            btnChangePassword.Location = new Point(510, 107);
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
            panel6.Location = new Point(6, 102);
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
            panel4.Location = new Point(6, 8);
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
            panel3.Location = new Point(6, 56);
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
            btnChangeName.Location = new Point(510, 56);
            btnChangeName.Name = "btnChangeName";
            btnChangeName.Size = new Size(84, 32);
            btnChangeName.TabIndex = 7;
            btnChangeName.Text = "Alterar";
            btnChangeName.UseVisualStyleBackColor = false;
            btnChangeName.Click += btnChangeName_Click;
            // 
            // pbUser
            // 
            pbUser.BackgroundImage = (Image)resources.GetObject("pbUser.BackgroundImage");
            pbUser.BackgroundImageLayout = ImageLayout.Stretch;
            pbUser.BorderStyle = BorderStyle.FixedSingle;
            pbUser.Dock = DockStyle.Left;
            pbUser.Location = new Point(20, 20);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(160, 160);
            pbUser.TabIndex = 0;
            pbUser.TabStop = false;
            // 
            // panel5
            // 
            panel5.Controls.Add(button4);
            panel5.Controls.Add(button3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(30, 220);
            panel5.Name = "panel5";
            panel5.Padding = new Padding(10);
            panel5.Size = new Size(804, 211);
            panel5.TabIndex = 1;
            // 
            // button4
            // 
            button4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button4.BackColor = Color.Crimson;
            button4.Cursor = Cursors.Hand;
            button4.FlatAppearance.BorderSize = 0;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.ForeColor = Color.White;
            button4.Location = new Point(624, 51);
            button4.Name = "button4";
            button4.Size = new Size(160, 32);
            button4.TabIndex = 14;
            button4.Text = "Excluir Conta";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.Crimson;
            button3.Cursor = Cursors.Hand;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.White;
            button3.Location = new Point(624, 13);
            button3.Name = "button3";
            button3.Size = new Size(160, 32);
            button3.TabIndex = 13;
            button3.Text = "Desativar Conta";
            button3.UseVisualStyleBackColor = false;
            // 
            // AccountControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            Controls.Add(panel5);
            Controls.Add(panel1);
            Name = "AccountControl";
            Padding = new Padding(30, 20, 30, 20);
            Size = new Size(864, 451);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnChangePhoto).EndInit();
            panel2.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            panel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pbUser;
        private Panel panel5;
        private Panel panel2;
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
        private Button button3;
        private PictureBox btnChangePhoto;
    }
}
