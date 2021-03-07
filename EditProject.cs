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
        //private readonly MainWindow mainWindow;
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
            MainWindow mainWindow = new MainWindow();
            Projects projects = new Projects();
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
                    //Close();
                    //projects.Hide();
                    //dgvProjects.Refresh();
                    //Projects_Load(sender, e);
                    //mainWindow.openChildForm(projects);

                    //mainWindow.bProjects_Click(sender, e);

                }

                for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
                {
                    if (Application.OpenForms[index].Name == "Projects")
                    {
                        Application.OpenForms[index].Hide();
                        Application.OpenForms[index].Show();
                    }

                    else if (Application.OpenForms[index].Name == "EditProject")
                    {
                        Application.OpenForms[index].Hide();
                    }

                    //}
                    //MainWindow.projects.Projects_Load(sender, e);
                    //projects.dgvProjects.Refresh();
                    //projects.Projects_Load(sender, e);
                }
            }
            catch
            {
                Close();
            }
        }

        private void bCancelEditingProject_Click(object sender, EventArgs e)
        {

            MainWindow mainWindow = new MainWindow();

            for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
            {
                if (Application.OpenForms[index].Name == "Projects")
                {
                    Application.OpenForms[index].Hide();
                    Application.OpenForms[index].Show();
                }

                else if (Application.OpenForms[index].Name == "EditProject")
                {
                    Application.OpenForms[index].Hide();
                }

                //}
                //MainWindow.projects.Projects_Load(sender, e);
                //projects.dgvProjects.Refresh();
                //projects.Projects_Load(sender, e);
            }

            //Close();

            //this.Hide();
            //MainWindow form2 = new MainWindow();
            //form2.ShowDialog();
            //this.Close();
            //Close();
            //mainWindow.Show();

            //for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
            //{
            //    if (Application.OpenForms[index].Name == "EditProject")
            //    {
            //        Application.OpenForms[index].Hide();
            //    }
            //}

            //EditProject nextForm = new EditProject();
            //this.Hide();
            //nextForm.ShowDialog();
            //this.Close();

            //this.Hide();
            //EditProject form2 = new EditProject();
            //form2.Closed += (s, args) => this.Close();
            //form2.Show();
        }

        private void EditProject_Load(object sender, EventArgs e)
        {

        }
    }
}
