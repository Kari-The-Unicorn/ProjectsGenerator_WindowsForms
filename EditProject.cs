using ProjectsGenerator_WindowsForms;
using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EditProject : Form
    {
        private readonly ProjectsKonstruktorEntities projectsKonstruktorEntities;
        private bool isEditMode;
        public EditProject()
        {
            InitializeComponent();
            isEditMode = false;
            projectsKonstruktorEntities = new ProjectsKonstruktorEntities();
            //tbProjectName.Text = 
            //var name = (string)dgvProjects.SelectedRows[0].Cells["ProjectName"].Value;
            //var project = projectsKonstruktorEntities.Projects.FirstOrDefault(q => q.ProjectName == name);
            //if (project != null)
            //{
            //    projectsKonstruktorEntities.Projects.Remove(project);
            //    projectsKonstruktorEntities.SaveChanges();
            //    dgvProjects.Refresh();
            //    Projects_Load(sender, e);
            //}
            //projects = new ProjectsKonstruktorEntities();
            //tbProjectName.Text = projects.projectName;
            //string projectAddress = tbProjectAddress.Text;
            //string projectCompany = tbProjectCompany.Text;
            //string projectState = tbProjectState.Text;
            //var projectDateIn = dtpProjectCollectionDate.Value;
            //var projectDateOut = dtpProjectCompleteDate.Value;
        }

        public EditProject(Project projectToEdit)
        {
            InitializeComponent();
            isEditMode = true;
            projectsKonstruktorEntities = new ProjectsKonstruktorEntities();
            //PopulateFields(projectToEdit);
        }

        private void bEditProject_Click(object sender, EventArgs e)
        {

        }

        private void bCancelEditingProject_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
