using System;
using System.Windows.Forms;

namespace ProjectsGenerator_WindowsForms
{
    public partial class AddProject : Form
    {
        //private readonly ProjectsKonstruktorEntities projectsKonstruktorEntities;
        public AddProject()
        {
            InitializeComponent();
            //projectsKonstruktorEntities = new ProjectsKonstruktorEntities();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cancelAddingProjectButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void bAddProject_Click(object sender, EventArgs e)
        {
            try
            {
                string projectName = tbProjectName.Text;
                string projectAddress = tbProjectAddress.Text;
                string projectCompany = tbProjectCompany.Text;
                string projectState = tbProjectState.Text;
                var projectDateIn = dtpProjectCollectionDate.Value;
                var projectDateOut = dtpProjectCompleteDate.Value;
                var isValid = true;
                var errorMessage = string.Empty;

                if (string.IsNullOrWhiteSpace(projectName))
                {
                    isValid = false;
                    errorMessage = "Proszę wpisać nazwę projektu.";
                }

                if (projectDateIn > projectDateOut)
                {
                    isValid = false;
                    errorMessage = "Data rozpoczęcia nie może być późniejsza niż data ukończenia.";
                }

                if (isValid)
                {
                    var projectsKonstruktorEntities = new ProjectsKonstruktorEntities();
                    var project = new Project();
                    project.ProjectName = projectName;
                    project.ProjectAddress = projectAddress;
                    project.ProjectCompany = projectCompany;
                    project.ProjectState = projectState;
                    project.ProjectDateIn = projectDateIn;
                    project.ProjectDateOut = projectDateOut;
                    projectsKonstruktorEntities.Projects.Add(project);
                    projectsKonstruktorEntities.SaveChanges();
                    MessageBox.Show("Projekt dodano pomyślnie.");
                    Close();
                }
                else
                {
                    MessageBox.Show(errorMessage);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
