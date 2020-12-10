using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ProjectsGenerator_WindowsForms
{
    public partial class OpenProject : Form
    {
        private readonly ProjectsKonstruktorEntities projectsKonstruktorEntities;
        public OpenProject()
        {
            InitializeComponent();
            projectsKonstruktorEntities = new ProjectsKonstruktorEntities();
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

        private void bLoadIssues_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvIssues_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }

        private void OpenProject_Load(object sender, EventArgs e)
        {
            var issues = projectsKonstruktorEntities.Issues.ToList();
            dgvIssues.DataSource = issues;
            dgvIssues.Columns["id"].HeaderText = "Numer";
            dgvIssues.Columns["IssueName"].HeaderText = "Opis";
            dgvIssues.Columns["ProjectId"].HeaderText = "Nr projektu";
        }
    }
}
