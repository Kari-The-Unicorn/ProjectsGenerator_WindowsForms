using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddIssue : Form
    {
        public AddIssue()
        {
            InitializeComponent();
        }

        private void bCancelAddingIssue_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void projectCompanyLabel_Click(object sender, EventArgs e)
        {

        }

        private void tbProjectInfoDateIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void pProjectInfoInIssueForm_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pProjectInfoInIssueForm.DisplayRectangle, Color.LightSkyBlue, ButtonBorderStyle.Solid);
        }

        private void bUploadImage_Click(object sender, EventArgs e)
        {

        }
    }
}
