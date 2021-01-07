using System;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
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
            openFile.Filter = "JPG|*.jpg";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                MessageBox.Show("Kliknij OK żeby potwierdzić plik: " + openFile.SafeFileName + ".");
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
                string projectName = tbProjectName.Text.Trim();
                string projectAddress = tbProjectAddress.Text.Trim();
                string projectCompany = tbProjectCompany.Text.Trim();
                string projectState = tbProjectState.Text.Trim();
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

                if (fileName == null)
                {
                    isValid = false;
                    errorMessage = "Proszę załączyć plik PDF.";
                }

                if (isValid)
                {
                    var projectsKonstruktorEntities = new ProjectsKonstruktorEntities();
                    MainWindow window = new MainWindow();
                    Projects projects = new Projects();
                    var project = new Project();
                    var picture = new Pictures1();
                    project.ProjectName = projectName.Trim();
                    project.ProjectAddress = projectAddress.Trim();
                    project.ProjectCompany = projectCompany.Trim();
                    project.ProjectState = projectState.Trim();
                    project.ProjectDateIn = projectDateIn;
                    project.ProjectDateOut = projectDateOut;
                    Image imageContent = Image.FromFile(fileName);
                    picture.PictureName = fileName.Trim();
                    project.ImageId = picture.PictureId;
                    picture.PictureContent = ConvertImageToByteArray(imageContent);

                    try
                    {
                        projectsKonstruktorEntities.Projects.Add(project);
                        projectsKonstruktorEntities.Pictures1.Add(picture);
                        //projectsKonstruktorEntities.Entry(picture).State = EntityState.Added;
                        //projectsKonstruktorEntities.Entry(project).State = EntityState.Added;
                        //project.ImageId = picture.PictureId;
                        //projectsKonstruktorEntities.Entry(project).State = EntityState.Modified;
                        projectsKonstruktorEntities.SaveChanges();
                        MessageBox.Show("Projekt dodano pomyślnie.");
                        Close();
                        window.openChildForm(projects);
                    }

                    catch (Exception ec)
                    {
                        Console.WriteLine(ec.Message);
                        MessageBox.Show("Projektu nie dodano.");
                    }
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
