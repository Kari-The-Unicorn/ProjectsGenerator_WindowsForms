using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ProjectsGenerator_WindowsForms
{
    public partial class AddProject : Form
    {
        private OpenFileDialog openFile;
        private string fileName;

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

        private void bUploadImage_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Upload file";
            openFile.Filter = "JPEG|*.jpeg";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Click OK to confirm: " + openFile.SafeFileName);
                if (openFile.FileName != null)
                {
                    lLoadedImageInfo.Text = "Wybrany plik: " + openFile.SafeFileName;
                    fileName = openFile.FileName;
                }
            }
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
                    var picture = new Picture();
                    project.ProjectName = projectName;
                    project.ProjectAddress = projectAddress;
                    project.ProjectCompany = projectCompany;
                    project.ProjectState = projectState;
                    project.ProjectDateIn = projectDateIn;
                    project.ProjectDateOut = projectDateOut;
                    Image imageContent = Image.FromFile(fileName);
                    picture.PictureName = fileName;
                    picture.PictureContent = ConvertImageToByteArray(imageContent);
                    projectsKonstruktorEntities.Projects.Add(project);
                    projectsKonstruktorEntities.Pictures.Add(picture);
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

        public byte[] ConvertImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }
    }
}
