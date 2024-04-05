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
            pictureBox1 = new PictureBox();
            txtName = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Dock = DockStyle.Left;
            pictureBox1.Location = new Point(2, 2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 39);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.White;
            txtName.Location = new Point(42, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(146, 39);
            txtName.TabIndex = 2;
            txtName.Text = "_channel_";
            txtName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ChannelControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(55, 55, 55);
            Controls.Add(txtName);
            Controls.Add(pictureBox1);
            Name = "ChannelControl";
            Padding = new Padding(2);
            Size = new Size(190, 43);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label txtName;
    }
}
