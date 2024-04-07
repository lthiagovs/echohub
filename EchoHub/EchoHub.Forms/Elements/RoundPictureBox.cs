using System.Drawing.Drawing2D;

namespace EchoHub.Forms.Elements
{
    public class RoundPictureBox : PictureBox
    {

        protected override void OnPaint(PaintEventArgs pe)
        {
            GraphicsPath grpath = new GraphicsPath();
            grpath.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
            this.Region = new System.Drawing.Region(grpath);
            base.OnPaint(pe);
        }

    }
}
