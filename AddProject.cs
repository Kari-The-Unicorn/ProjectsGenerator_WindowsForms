using System;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ProjectsGenerator_WindowsForms
{
    public partial class AddProject : Form
    {
        private readonly OpenFileDialog openFile;

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

        private void bUploadImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Upload file";
            openFile.Filter = "PDF|*.pdf";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //textBox1.Text = openFile.FileName;
                //textBox1.Text = openFile.SafeFileName;
                //var x = NewMethod(openFile, out var result);
                //NewMethod(openFile, out var result);
                MessageBox.Show("Click OK to confirm: " + openFile.SafeFileName);
                if (openFile.SafeFileName != null)
                {
                    //tbLoadedImageInfo.Clear();
                    lLoadedImageInfo.Text = "Wybrany plik: " + openFile.SafeFileName;
                    //tbLoadedImageInfo.Show();
                }
            }
        }

        //private static string NewMethod(OpenFileDialog openFile, out DialogResult result)
        //{
        //    result = MessageBox.Show("Click OK to confirm: " + openFile.SafeFileName);
        //    return openFile.SafeFileName;
        //}

        private void tbLoadedImageInfo_TextChanged(object sender, EventArgs e)
        {
            //NewMethod(openFile, out var result);
            //if (result != null)
            //{
            //    tbLoadedImageInfo.Clear();
            //    tbLoadedImageInfo.Text = "Otwórz";
            //    tbLoadedImageInfo.Show();
            //}
        }
    }
}
