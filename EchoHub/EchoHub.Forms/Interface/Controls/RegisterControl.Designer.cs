namespace EchoHub.Forms.Interface.Controls
{
    partial class RegisterControl
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
            pnRepeatPassword = new Panel();
            txtRepeatPassword = new TextBox();
            btnRegister = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            pnEmail.SuspendLayout();
            pnPassword.SuspendLayout();
            pnRepeatPassword.SuspendLayout();
            SuspendLayout();
            // 
            // pnEmail
            // 
            pnEmail.BackColor = Color.FromArgb(50, 50, 50);
            pnEmail.Controls.Add(txtEmail);
            pnEmail.Location = new Point(13, 22);
            pnEmail.Margin = new Padding(3, 3, 3, 10);
            pnEmail.Name = "pnEmail";
            pnEmail.Padding = new Padding(6);
            pnEmail.Size = new Size(598, 50);
            pnEmail.TabIndex = 0;
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(50, 50, 50);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.Dock = DockStyle.Fill;
            txtEmail.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.White;
            txtEmail.Location = new Point(6, 6);
            txtEmail.MaxLength = 30;
            txtEmail.Multiline = true;
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(586, 38);
            txtEmail.TabIndex = 0;
            // 
            // pnPassword
            // 
            pnPassword.BackColor = Color.FromArgb(50, 50, 50);
            pnPassword.Controls.Add(txtPassword);
            pnPassword.Location = new Point(13, 109);
            pnPassword.Name = "pnPassword";
            pnPassword.Padding = new Padding(6, 14, 6, 6);
            pnPassword.Size = new Size(598, 50);
            pnPassword.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(50, 50, 50);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.White;
            txtPassword.Location = new Point(6, 14);
            txtPassword.MaxLength = 12;
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(586, 22);
            txtPassword.TabIndex = 1;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // pnRepeatPassword
            // 
            pnRepeatPassword.BackColor = Color.FromArgb(50, 50, 50);
            pnRepeatPassword.Controls.Add(txtRepeatPassword);
            pnRepeatPassword.Location = new Point(13, 197);
            pnRepeatPassword.Name = "pnRepeatPassword";
            pnRepeatPassword.Padding = new Padding(6, 14, 6, 6);
            pnRepeatPassword.Size = new Size(598, 50);
            pnRepeatPassword.TabIndex = 2;
            // 
            // txtRepeatPassword
            // 
            txtRepeatPassword.BackColor = Color.FromArgb(50, 50, 50);
            txtRepeatPassword.BorderStyle = BorderStyle.None;
            txtRepeatPassword.Dock = DockStyle.Fill;
            txtRepeatPassword.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtRepeatPassword.ForeColor = Color.White;
            txtRepeatPassword.Location = new Point(6, 14);
            txtRepeatPassword.MaxLength = 12;
            txtRepeatPassword.Name = "txtRepeatPassword";
            txtRepeatPassword.Size = new Size(586, 22);
            txtRepeatPassword.TabIndex = 2;
            txtRepeatPassword.UseSystemPasswordChar = true;
            // 
            // btnRegister
            // 
            btnRegister.BackColor = Color.CornflowerBlue;
            btnRegister.Cursor = Cursors.Hand;
            btnRegister.FlatAppearance.BorderSize = 0;
            btnRegister.FlatStyle = FlatStyle.Flat;
            btnRegister.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRegister.ForeColor = Color.White;
            btnRegister.Location = new Point(13, 260);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(598, 50);
            btnRegister.TabIndex = 3;
            btnRegister.Text = "Registrar";
            btnRegister.UseVisualStyleBackColor = false;
            btnRegister.Click += btnRegister_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.LightGray;
            label2.Location = new Point(13, -2);
            label2.Name = "label2";
            label2.Size = new Size(63, 21);
            label2.TabIndex = 7;
            label2.Text = "E-MAIL";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.LightGray;
            label1.Location = new Point(13, 82);
            label1.Name = "label1";
            label1.Size = new Size(62, 21);
            label1.TabIndex = 8;
            label1.Text = "SENHA";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.LightGray;
            label3.Location = new Point(13, 173);
            label3.Name = "label3";
            label3.Size = new Size(125, 21);
            label3.TabIndex = 9;
            label3.Text = "REPETIR SENHA";
            // 
            // RegisterControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(btnRegister);
            Controls.Add(pnRepeatPassword);
            Controls.Add(pnPassword);
            Controls.Add(pnEmail);
            Name = "RegisterControl";
            Padding = new Padding(10);
            Size = new Size(624, 314);
            pnEmail.ResumeLayout(false);
            pnEmail.PerformLayout();
            pnPassword.ResumeLayout(false);
            pnPassword.PerformLayout();
            pnRepeatPassword.ResumeLayout(false);
            pnRepeatPassword.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel pnEmail;
        private Panel pnPassword;
        private Panel pnRepeatPassword;
        private Button btnRegister;
        private Label label2;
        private Label label1;
        private Label label3;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private TextBox txtRepeatPassword;
    }
}
