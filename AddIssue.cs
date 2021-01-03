using ProjectsGenerator_WindowsForms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddIssue : Form
    {
        public bool isCancelled = false;
        public static OpenProject openProject = new OpenProject();
        public static OpenMap newMdiChildMap = new OpenMap();
        Projects project = new Projects();
        public AddIssue()
        {
            InitializeComponent();
        }

        private void bCancelAddingIssue_Click(object sender, EventArgs e)
        {
            isCancelled = true;
            //OpenProject proj = new OpenProject();
            //proj.bShowMap_Click(sender, e); 
            Close();
            //OpenMap.ActiveForm.Refresh();
            //openProject.ActiveMdiChild.Refresh();
            openProject.bShowMap_Click(sender, e);
            newMdiChildMap.Close();
            //openProject.Controls.Clear();
            //openProject.Refresh();
            //openProject.Close();
            //project.GetSelectedProject();
            //((OpenMap)newMdiChildMap).Refresh();
            //Application.DoEvents();
        }

        private void projectCompanyLabel_Click(object sender, EventArgs e)
        {
        }

        private void tbProjectInfoDateIn_TextChanged(object sender, EventArgs e)
        {
        }

        private void pProjectInfoInIssueForm_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pProjectInfoInIssueForm.DisplayRectangle, Color.LightSkyBlue, ButtonBorderStyle.Solid);
        }

        private void bUploadImage_Click(object sender, EventArgs e)
        {
        }

        private void tlpAddIssueForm_Paint(object sender, PaintEventArgs e)
        {
        }

        private void bAddIssue_Click(object sender, EventArgs e)
        {
            try
            {
                var project3 = Projects.project;
                var imagePos1 = OpenMap.imagePos;

                if (project3 != null)
                {
                    string issueName = tbIssueName.Text.Trim();
                    int projectId = project3.id;
                    string issueDescription = tbIssueDescription.Text.Trim();
                    string issuePlace = tbIssuePlace.Text.Trim();
                    var imageId = project3.ImageId;
                    var issueCoordinateX = imagePos1.X - 30;
                    var issueCoordinateY = imagePos1.Y - 30;
                    var isValid = true;
                    var errorMessage = string.Empty;

                    if (string.IsNullOrWhiteSpace(issueName))
                    {
                        isValid = false;
                        errorMessage = "Proszę wpisać nazwę projektu.";
                    }

                    //if (projectDateIn > projectDateOut)
                    //{
                    //    isValid = false;
                    //    errorMessage = "Data rozpoczęcia nie może być późniejsza niż data ukończenia.";
                    //}

                    //if (fileName == null)
                    //{
                    //    isValid = false;
                    //    errorMessage = "Proszę załączyć plik PDF.";
                    //}

                    if (isValid)
                    {
                        var projectsKonstruktorEntities = new ProjectsKonstruktorEntities();
                        var issue = new Issue();
                        issue.IssueName = issueName;
                        issue.ProjectId = projectId;
                        issue.IssueDescription = issueDescription;
                        issue.IssuePlace = issuePlace;
                        issue.ImageId = imageId;
                        issue.IssueCoordinateX = issueCoordinateX;
                        issue.IssueCoordinateY = issueCoordinateY;

                        try
                        {
                            isCancelled = false;
                            projectsKonstruktorEntities.Issues.Add(issue);
                            projectsKonstruktorEntities.SaveChanges();
                            MessageBox.Show("Poprawkę dodano pomyślnie.");
                            Close();
                        }
                        catch (Exception ec)
                        {
                            Console.WriteLine(ec.Message);
                            MessageBox.Show("Poprawki nie dodano.");
                        }
                    }
                    else
                    {
                        MessageBox.Show(errorMessage);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
