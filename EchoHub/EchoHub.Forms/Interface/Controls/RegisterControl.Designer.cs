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
            pnPassword = new Panel();
            pnRepeatPassword = new Panel();
            btnRegister = new Button();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // pnEmail
            // 
            pnEmail.BackColor = Color.FromArgb(50, 50, 50);
            pnEmail.Location = new Point(13, 22);
            pnEmail.Margin = new Padding(3, 3, 3, 10);
            pnEmail.Name = "pnEmail";
            pnEmail.Size = new Size(598, 50);
            pnEmail.TabIndex = 0;
            // 
            // pnPassword
            // 
            pnPassword.BackColor = Color.FromArgb(50, 50, 50);
            pnPassword.Location = new Point(13, 109);
            pnPassword.Name = "pnPassword";
            pnPassword.Size = new Size(598, 50);
            pnPassword.TabIndex = 1;
            // 
            // pnRepeatPassword
            // 
            pnRepeatPassword.BackColor = Color.FromArgb(50, 50, 50);
            pnRepeatPassword.Location = new Point(13, 197);
            pnRepeatPassword.Name = "pnRepeatPassword";
            pnRepeatPassword.Size = new Size(598, 50);
            pnRepeatPassword.TabIndex = 2;
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
    }
}
