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
            //widnows forms tt.ShowAlways = true;
            pbMap.MouseDown += pbMap_MouseDown;
        }
        private void pbMap_MouseDown(object sender, MouseEventArgs e)
        {
            Bitmap bmp = new Bitmap(pbMap.Image);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                {
                    imagePos = e.Location;
                    g.DrawImage(new Bitmap(
                       @"C:\Users\karol\source\repos\WindowsFormsApp1\images\redcircle.png"),
                    new Point(imagePos.X -30, imagePos.Y-30));
                }
                pbMap.Image = bmp;
            }
        }

        private void pbMap_Click(object sender, EventArgs e)
        {
        }
    }
}
