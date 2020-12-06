using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ProjectsGenerator_WindowsForms
{
    public partial class Projects : Form
    {
        private readonly ProjectsKonstruktorEntities projectsKonstruktorEntities;
        private bool isEditMode;
        public Projects()
        {
            InitializeComponent();
            projectsKonstruktorEntities = new ProjectsKonstruktorEntities();
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            //// select * from projects table
            var projects = projectsKonstruktorEntities.Projects.ToList();
            //var projects = projectsKonstruktorEntities.Projects.Select(q => new
            //{
            //    //Id = q.id, 
            //    Name = q.ProjectName
            //}).ToList();
            dgvProjects.DataSource = projects;
            dgvProjects.Columns["id"].Visible = false;
            dgvProjects.Columns["Issues"].Visible = false;
            this.dgvProjects.Columns["ProjectName"].HeaderText = "Nazwa";
            this.dgvProjects.Columns["ProjectAddress"].HeaderText = "Adres";
            this.dgvProjects.Columns["ProjectCompany"].HeaderText = "Firma";
            this.dgvProjects.Columns["ProjectState"].HeaderText = "Stan";
            this.dgvProjects.Columns["ProjectDateIn"].HeaderText = "Od dnia";
            this.dgvProjects.Columns["ProjectDateOut"].HeaderText = "Do dnia";
        }

        private void dgvProjects_Click(object sender, EventArgs e)
        {

        }

        private void dgvProjects_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        protected void MDIChildEditProject(object sender, System.EventArgs e)
        {
            EditProject newMdiChild = new EditProject();
            try
            {
                var name = (string) dgvProjects.SelectedRows[0].Cells["ProjectName"].Value;
                var project = projectsKonstruktorEntities.Projects.FirstOrDefault(q => q.ProjectName == name);
                
                if (project != null)
                {
                    ((EditProject)newMdiChild).tbProjectName.Text = project.ProjectName;
                    ((EditProject)newMdiChild).tbProjectAddress.Text = project.ProjectAddress;
                    ((EditProject)newMdiChild).tbProjectCompany.Text = project.ProjectCompany;
                    ((EditProject)newMdiChild).tbProjectState.Text = project.ProjectState;
                    ((EditProject)newMdiChild).dtpProjectCollectionDate.Value = project.ProjectDateIn.Value;
                    ((EditProject)newMdiChild).dtpProjectCompleteDate.Value = project.ProjectDateOut.Value;
                    newMdiChild.Show();
                }
            }
            catch
            {
                this.Close();
            }
            //Projects fL = new Projects();
            //fL.Show();
        }
        private void bEditProject_Click(object sender, EventArgs e)//Project projectToEdit)
        {
            isEditMode = true;
            MDIChildEditProject(sender, e);
        }

        private void bDeleteProject_Click_1(object sender, EventArgs e)
        {
            var name = (string)dgvProjects.SelectedRows[0].Cells["ProjectName"].Value;
            var project = projectsKonstruktorEntities.Projects.FirstOrDefault(q => q.ProjectName == name);
            if (project != null)
            {
                projectsKonstruktorEntities.Projects.Remove(project);
                projectsKonstruktorEntities.SaveChanges();
                dgvProjects.Refresh();
                Projects_Load(sender, e);
            }
        }
    }
}
