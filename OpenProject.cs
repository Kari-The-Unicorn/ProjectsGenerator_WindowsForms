using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1;

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
            dgvIssues.Columns["IssueName"].HeaderText = "Nazwa poprawki";
            dgvIssues.Columns["IssueDescription"].HeaderText = "Opis";
            dgvIssues.Columns["IssuePlace"].HeaderText = "Lokalizacja";
            dgvIssues.Columns["ProjectId"].Visible = false;
            dgvIssues.Columns["ImageId"].Visible = false;
            dgvIssues.Columns["IssueCoordinateX"].Visible = false;
            dgvIssues.Columns["IssueCoordinateY"].Visible = false;
            dgvIssues.Columns["Project"].Visible = false;
            //dgvIssues.Columns["ProjectId"].HeaderText = "Nr projektu";
        }

        private void bAddIssue_Click(object sender, EventArgs e)
        {
            AddIssue newMdiChildEdit = new AddIssue();
            newMdiChildEdit.Show();
            //try
            //{
            //var project = GetSelectedProject();

            //if (project != null)
            //{
            //    ((EditProject)newMdiChildEdit).lblId.Text = project.id.ToString();
            //    ((EditProject)newMdiChildEdit).tbProjectName.Text = project.ProjectName;
            //    ((EditProject)newMdiChildEdit).tbProjectAddress.Text = project.ProjectAddress.ToString();
            //    ((EditProject)newMdiChildEdit).tbProjectCompany.Text = project.ProjectCompany.ToString();
            //    ((EditProject)newMdiChildEdit).tbProjectState.Text = project.ProjectState.ToString();
            //    ((EditProject)newMdiChildEdit).dtpProjectCollectionDate.Value = project.ProjectDateIn.Value;
            //    ((EditProject)newMdiChildEdit).dtpProjectCompleteDate.Value = project.ProjectDateOut.Value;
            //    newMdiChildEdit.Show();
            //}
            //}
            //catch
            //{
            //    Close();
            //}

        }

        private void dgvIssues_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
