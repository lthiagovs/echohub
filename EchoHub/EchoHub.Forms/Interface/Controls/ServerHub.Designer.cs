namespace EchoHub.Forms.Interface.Controls
{
    partial class ServerHub
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ServerHub));
            pnBack = new Panel();
            btnServer = new Elements.RoundPictureBox();
            pnBack.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnServer).BeginInit();
            SuspendLayout();
            // 
            // pnBack
            // 
            pnBack.Controls.Add(btnServer);
            pnBack.Dock = DockStyle.Fill;
            pnBack.Location = new Point(0, 0);
            pnBack.Name = "pnBack";
            pnBack.Size = new Size(60, 60);
            pnBack.TabIndex = 1;
            // 
            // btnServer
            // 
            btnServer.BackgroundImage = (Image)resources.GetObject("btnServer.BackgroundImage");
            btnServer.BackgroundImageLayout = ImageLayout.Stretch;
            btnServer.Cursor = Cursors.Hand;
            btnServer.Dock = DockStyle.Fill;
            btnServer.Location = new Point(0, 0);
            btnServer.Name = "btnServer";
            btnServer.Size = new Size(60, 60);
            btnServer.TabIndex = 0;
            btnServer.TabStop = false;
            btnServer.Click += btnServer_Click;
            // 
            // ServerHub
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(45, 45, 45);
            Controls.Add(pnBack);
            Name = "ServerHub";
            Size = new Size(60, 60);
            pnBack.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)btnServer).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel pnBack;
        private Elements.RoundPictureBox btnServer;
    }
}
