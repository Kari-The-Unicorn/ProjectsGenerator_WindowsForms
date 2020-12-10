using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectsGenerator_WindowsForms
{
    public partial class OpenProject : Form
    {
        public OpenProject()
        {
            InitializeComponent();
        }

        private void tbProjectInfoDateIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void lProjectInfoDateOut_Click(object sender, EventArgs e)
        {

        }

        private void pProjectInfo_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pProjectInfo.DisplayRectangle, Color.LightSkyBlue, ButtonBorderStyle.Solid);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
