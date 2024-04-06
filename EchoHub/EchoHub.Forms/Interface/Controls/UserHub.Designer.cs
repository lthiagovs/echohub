namespace EchoHub.Forms.Interface.Controls
{
    partial class UserHub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserHub));
            txtName = new Label();
            pbUser = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.AutoSize = true;
            txtName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(72, 10);
            txtName.Name = "txtName";
            txtName.Size = new Size(52, 17);
            txtName.TabIndex = 3;
            txtName.Text = "_name_";
            // 
            // pbUser
            // 
            pbUser.BackgroundImage = (Image)resources.GetObject("pbUser.BackgroundImage");
            pbUser.BackgroundImageLayout = ImageLayout.Stretch;
            pbUser.Location = new Point(16, 10);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(50, 50);
            pbUser.TabIndex = 2;
            pbUser.TabStop = false;
            // 
            // UserHub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 55, 55);
            Controls.Add(txtName);
            Controls.Add(pbUser);
            Name = "UserHub";
            Padding = new Padding(10);
            Size = new Size(170, 67);
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtName;
        private PictureBox pbUser;
    }
}
