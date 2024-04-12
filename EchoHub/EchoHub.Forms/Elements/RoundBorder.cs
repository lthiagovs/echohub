using System.Runtime.InteropServices;

namespace EchoHub.Forms.Elements
{
    public static class RoundBorder
    {

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // width of ellipse
            int nHeightEllipse // height of ellipse
        );

        public static void Round(Control control, int Radius)
        {

            control.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, control.Width, control.Height, Radius, Radius));

        }


    }

}
