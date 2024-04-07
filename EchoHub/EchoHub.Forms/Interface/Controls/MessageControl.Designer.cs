namespace EchoHub.Forms.Interface.Controls
{
    partial class MessageControl
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
            txtName = new Label();
            txtContent = new TextBox();
            pbUser = new Elements.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(69, 4);
            txtName.Name = "txtName";
            txtName.Size = new Size(52, 17);
            txtName.TabIndex = 5;
            txtName.Text = "_name_";
            // 
            // txtContent
            // 
            txtContent.BackColor = Color.FromArgb(60, 60, 60);
            txtContent.BorderStyle = BorderStyle.None;
            txtContent.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtContent.ForeColor = Color.White;
            txtContent.Location = new Point(69, 24);
            txtContent.Multiline = true;
            txtContent.Name = "txtContent";
            txtContent.Size = new Size(422, 30);
            txtContent.TabIndex = 6;
            txtContent.Text = "_MESSAGE_";
            // 
            // pbUser
            // 
            pbUser.Location = new Point(3, 4);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(60, 60);
            pbUser.TabIndex = 8;
            pbUser.TabStop = false;
            // 
            // MessageControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 60, 60);
            Controls.Add(pbUser);
            Controls.Add(txtContent);
            Controls.Add(txtName);
            Name = "MessageControl";
            Padding = new Padding(10);
            Size = new Size(504, 67);
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        public Label txtName;
        public TextBox txtContent;
        public Elements.RoundPictureBox pbUser;
    }
}
