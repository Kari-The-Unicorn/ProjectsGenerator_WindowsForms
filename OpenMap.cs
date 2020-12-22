using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class OpenMap : Form
    {
        private Point imagePos = new Point();
        public OpenMap()
        {
            InitializeComponent();
            ToolTip tt = new ToolTip();
            tt.SetToolTip(this.pbMap, "Zaznacz poprawkę na mapie");
            //tt.ShowAlways = true;
            pbMap.MouseDown += pbMap_MouseDown;
        }
        private void pbMap_MouseDown(object sender, MouseEventArgs e)
        {
            if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
            {
                imagePos = e.Location;
            }
        }

        private void pbMap_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(pbMap.Image);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawImage(new Bitmap(
                        @"C:\Users\karol\source\repos\WindowsFormsApp1\images\redcircle.png"),
                    new Point(imagePos.X, imagePos.Y));
            }
            pbMap.Image = bmp;
        }
    }
}
