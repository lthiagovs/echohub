namespace EchoHub.Forms.Interface.Controls
{
    partial class ChannelControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChannelControl));
            btnChannel = new PictureBox();
            txtName = new Label();
            ((System.ComponentModel.ISupportInitialize)btnChannel).BeginInit();
            SuspendLayout();
            // 
            // btnChannel
            // 
            btnChannel.BackgroundImage = (Image)resources.GetObject("btnChannel.BackgroundImage");
            btnChannel.BackgroundImageLayout = ImageLayout.Center;
            btnChannel.Cursor = Cursors.Hand;
            btnChannel.Dock = DockStyle.Left;
            btnChannel.Location = new Point(2, 2);
            btnChannel.Name = "btnChannel";
            btnChannel.Size = new Size(40, 39);
            btnChannel.TabIndex = 0;
            btnChannel.TabStop = false;
            btnChannel.Click += btnChannel_Click;
            btnChannel.MouseEnter += btnChannel_MouseEnter;
            btnChannel.MouseLeave += btnChannel_MouseLeave;
            // 
            // txtName
            // 
            txtName.Cursor = Cursors.Hand;
            txtName.Dock = DockStyle.Fill;
            txtName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(42, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(146, 39);
            txtName.TabIndex = 2;
            txtName.Text = "_channel_";
            txtName.TextAlign = ContentAlignment.MiddleCenter;
            txtName.Click += txtName_Click;
            txtName.MouseEnter += txtName_MouseEnter;
            txtName.MouseLeave += txtName_MouseLeave;
            // 
            // ChannelControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 55, 55);
            Controls.Add(txtName);
            Controls.Add(btnChannel);
            Name = "ChannelControl";
            Padding = new Padding(2);
            Size = new Size(190, 43);
            ((System.ComponentModel.ISupportInitialize)btnChannel).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox btnChannel;
        public Label txtName;
    }
}
