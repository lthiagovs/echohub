namespace EchoHub.Forms.Interface.Controls
{
    partial class LoginControl
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
            pnEmail = new Panel();
            txtEmail = new TextBox();
            pnPassword = new Panel();
            txtPassword = new TextBox();
            btnLogin = new Button();
            label1 = new Label();
            label2 = new Label();
            pnEmail.SuspendLayout();
            pnPassword.SuspendLayout();
            SuspendLayout();
            // 
            // pnEmail
            // 
            pnEmail.BackColor = Color.FromArgb(50, 50, 50);
            pnEmail.Controls.Add(txtEmail);
            pnEmail.Location = new Point(13, 50);
            pnEmail.Margin = new Padding(3, 3, 3, 10);
            pnEmail.Name = "pnEmail";
            pnEmail.Padding = new Padding(4, 16, 4, 4);
            pnEmail.Size = new Size(598, 50);
            pnEmail.TabIndex = 1;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(50, 50, 50);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(4, 16);
            txtEmail.MaxLength = 30;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(590, 22);
            txtEmail.TabIndex = 1;
            // 
            // pnPassword
            // 
            pnPassword.BackColor = Color.FromArgb(50, 50, 50);
            pnPassword.Controls.Add(txtPassword);
            pnPassword.Location = new Point(13, 142);
            pnPassword.Margin = new Padding(3, 3, 3, 10);
            pnPassword.Name = "pnPassword";
            pnPassword.Padding = new Padding(4, 16, 4, 4);
            pnPassword.Size = new Size(598, 50);
            pnPassword.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(50, 50, 50);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(4, 16);
            txtPassword.MaxLength = 12;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(590, 22);
            txtPassword.TabIndex = 2;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.CornflowerBlue;
            btnLogin.Cursor = Cursors.Hand;
            btnLogin.FlatAppearance.BorderSize = 0;
            btnLogin.FlatStyle = FlatStyle.Flat;
            btnLogin.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.ForeColor = Color.White;
            btnLogin.Location = new Point(13, 251);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(598, 50);
            btnLogin.TabIndex = 4;
            btnLogin.Text = "Entrar";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(13, 26);
            label1.Name = "label1";
            label1.Size = new Size(63, 21);
            label1.TabIndex = 5;
            label1.Text = "E-MAIL";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(13, 118);
            label2.Name = "label2";
            label2.Size = new Size(62, 21);
            label2.TabIndex = 6;
            label2.Text = "SENHA";
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnLogin);
            Controls.Add(pnPassword);
            Controls.Add(pnEmail);
            Name = "LoginControl";
            Padding = new Padding(10);
            Size = new Size(624, 314);
            pnEmail.ResumeLayout(false);
            pnEmail.PerformLayout();
            pnPassword.ResumeLayout(false);
            pnPassword.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnEmail;
        private Panel pnPassword;
        private Button btnLogin;
        private Label label1;
        private Label label2;
        private TextBox txtPassword;
        private TextBox txtEmail;
    }
}
