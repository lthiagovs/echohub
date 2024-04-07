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
            pbUser = new Elements.RoundPictureBox();
            ((System.ComponentModel.ISupportInitialize)pbUser).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(63, 10);
            txtName.Name = "txtName";
            txtName.Size = new Size(107, 47);
            txtName.TabIndex = 3;
            txtName.Text = "_name_";
            // 
            // pbUser
            // 
            pbUser.BackgroundImage = (Image)resources.GetObject("pbUser.BackgroundImage");
            pbUser.BackgroundImageLayout = ImageLayout.Stretch;
            pbUser.Dock = DockStyle.Left;
            pbUser.Location = new Point(10, 10);
            pbUser.Name = "pbUser";
            pbUser.Size = new Size(47, 47);
            pbUser.TabIndex = 4;
            pbUser.TabStop = false;
            // 
            // UserHub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 55, 55);
            Controls.Add(pbUser);
            Controls.Add(txtName);
            Name = "UserHub";
            Padding = new Padding(10);
            Size = new Size(170, 67);
            ((System.ComponentModel.ISupportInitialize)pbUser).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label txtName;
        private Elements.RoundPictureBox pbUser;
    }
}
