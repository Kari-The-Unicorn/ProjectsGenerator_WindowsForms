using ProjectsGenerator_WindowsForms;
using System;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ProjectsGenerator_WindowsForms
{
    public partial class EditProject : Form
    {
        private readonly ProjectsKonstruktorEntities projectsKonstruktorEntities;
        private bool isEditMode;
        public EditProject()
        {
            InitializeComponent();
            //isEditMode = false;
            projectsKonstruktorEntities = new ProjectsKonstruktorEntities();
        }

        private void bEditProject_Click(object sender, EventArgs e)
        {
            //projectsKonstruktorEntities.SaveChanges();
            //((Projects)Owner).dgvProjects.Refresh();
            //Projects_Load(sender, e);
            try
            {
                var idBase = int.Parse(lblId.Text);
                Project project = projectsKonstruktorEntities.Projects
                    .FirstOrDefault(q => q.id == idBase);
                //if (System.Windows.Forms.Application.OpenForms["EditProject"] != null)
                //{
                //    project = (System.Windows.Forms.Application.OpenForms["EditProject"] as Projects)
                //        .GetSelectedProject();
                //}

                //if (Application.OpenForms["EditProject"] != null)
                //{
                //    project = (Application.OpenForms["EditProject"] as Projects)
                //        .GetSelectedProject();
                //}

                if (project != null)
                {
                    project.ProjectName = tbProjectName.Text;
                    project.ProjectAddress = tbProjectAddress.Text;
                    project.ProjectCompany = tbProjectCompany.Text; 
                    project.ProjectState = tbProjectState.Text;
                    project.ProjectDateIn = dtpProjectCollectionDate.Value;
                    project.ProjectDateOut = dtpProjectCompleteDate.Value;
                    projectsKonstruktorEntities.SaveChanges();
                    Close();
                    //dgvProjects.Refresh();
                    //Projects_Load(sender, e);
                }
            }
            catch
            {
                Close();
            }
        }

        private void bCancelEditingProject_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EditProject_Load(object sender, EventArgs e)
        {

        }
    }
}
