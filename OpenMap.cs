using ProjectsGenerator_WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class OpenMap : Form
    {
        public static Point imagePos = new Point();
        private readonly ProjectsKonstruktorEntities projectsKonstruktorEntities;
        private readonly Label lblId;
        private List<Issue> issuesOnMap = new List<Issue>();
        private bool isEditMode;
        //private Issue issueOnTheMap = new Issue();
        public OpenMap()
        {
            InitializeComponent();
            projectsKonstruktorEntities = new ProjectsKonstruktorEntities();
            lblId = new Label();
            ToolTip tt = new ToolTip();
            tt.SetToolTip(pbMap, "Zaznacz poprawkę na mapie");
            tt.ShowAlways = true;
            //pbMap.MouseDown += pbMap_MouseDown;
            issuesOnMap = projectsKonstruktorEntities.Issues.ToList();
        }

        public void pbMap_MouseDown(object sender, MouseEventArgs e)
        {
            isEditMode = false;
            issuesOnMap = projectsKonstruktorEntities.Issues.ToList();
            Bitmap bmp = new Bitmap(pbMap.Image);
            using (Graphics g = Graphics.FromImage(bmp))
            {
                if ((e.Button & MouseButtons.Left) == MouseButtons.Left)
                {
                    foreach (var issueOnTheMap in issuesOnMap)
                    {
                        if (issueOnTheMap.IssueCoordinateX < e.Location.X &&
                            issueOnTheMap.IssueCoordinateX > e.Location.X - 60 &&
                            issueOnTheMap.IssueCoordinateY < e.Location.Y &&
                            issueOnTheMap.IssueCoordinateY > e.Location.Y - 60)
                        {
                            isEditMode = true;
                            EditIssue newMdiChildEdit = new EditIssue();

                            try
                            {
                                var project4 = Projects.project;
                                //var pictures1 = Pictures1.;
                                var imagePos2 = OpenMap.imagePos;

                                if (project4 != null)
                                {
                                    //((EditIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text = project4.id.ToString() + "; ";
                                    ((EditIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text += project4.ProjectName.ToString().Trim() + "; ";
                                    ((EditIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text += project4.ProjectAddress.ToString().Trim() + "; ";
                                    ((EditIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text += project4.ProjectCompany.ToString().Trim();
                                    ((EditIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text += " (" + project4.ProjectState.ToString().Trim() + ")";
                                    ((EditIssue)newMdiChildEdit).tbProjectInfoDateInInIssueForm.Text += Regex.Replace(project4.ProjectDateIn.ToString(),
                                            @"\s(.*)", string.Empty, RegexOptions.IgnoreCase);
                                    ((EditIssue)newMdiChildEdit).tbProjectInfoDateOutInIssueForm.Text += Regex.Replace(project4.ProjectDateOut.ToString(),
                                        @"\s(.*)", string.Empty, RegexOptions.IgnoreCase);
                                    ((EditIssue)newMdiChildEdit).lId.Text = issueOnTheMap.id.ToString();
                                    //foreach (var issueOnTheMap in issuesOnMap)
                                    //{
                                    //    if (issueOnTheMap.IssueCoordinateX < e.Location.X &&
                                    //        issueOnTheMap.IssueCoordinateX > e.Location.X - 60 &&
                                    //        issueOnTheMap.IssueCoordinateY < e.Location.Y &&
                                    //        issueOnTheMap.IssueCoordinateY > e.Location.Y - 60)
                                    //    {
                                    //        //isEditMode = true;
                                    //        //MessageBox.Show("Edit project");
                                    //        EditIssue newMdiChildEdit = new EditIssue();
                                    //        newMdiChildEdit.Show();
                                    //    }
                                    //}
                                    ((EditIssue)newMdiChildEdit).tbIssueName.Text = issueOnTheMap.IssueName;
                                    ((EditIssue)newMdiChildEdit).tbIssueDescription.Text = issueOnTheMap.IssueDescription;
                                    ((EditIssue)newMdiChildEdit).tbIssuePlace.Text = issueOnTheMap.IssuePlace;

                                    

                                    //if (string.IsNullOrWhiteSpace(issueName))
                                    //{
                                    //    isValid = false;
                                    //    errorMessage = "Proszę wpisać nazwę projektu.";
                                    //}

                                    //if (isValid)
                                    //{
                                    //    var projectsKonstruktorEntities = new ProjectsKonstruktorEntities();
                                    //    var issue = new Issue();
                                    //    issue.IssueName = issueName;
                                    //    issue.ProjectId = projectId;
                                    //    issue.IssueDescription = issueDescription;
                                    //    issue.IssuePlace = issuePlace;
                                    //    issue.ImageId = imageId;
                                    //    issue.IssueCoordinateX = issueCoordinateX;
                                    //    issue.IssueCoordinateY = issueCoordinateY;

                                    //    try
                                    //    {
                                    //        isCancelled = false;
                                    //        projectsKonstruktorEntities.Issues.Add(issue);
                                    //        projectsKonstruktorEntities.SaveChanges();
                                    //        MessageBox.Show("Poprawkę dodano pomyślnie.");
                                    //        Close();
                                    //    }
                                    //    catch (Exception ec)
                                    //    {
                                    //        Console.WriteLine(ec.Message);
                                    //        MessageBox.Show("Poprawki nie dodano.");
                                    //    }
                                }
                                //else
                                //{
                                //    MessageBox.Show(errorMessage);
                                //}
                            }
                            catch (Exception ex)
                            {
                                MessageBox.Show(ex.Message);
                            }

                            newMdiChildEdit.ShowDialog();
                        }
                    }
                    if (!isEditMode)
                    {
                        imagePos = e.Location;
                        g.DrawImage(new Bitmap(
                            System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"images\redcircle.png")),
                        new Point(imagePos.X - 30, imagePos.Y - 30));
                    }
                    pbMap.Image = bmp;
                }
            }
        }

        private void pbMap_Click(object sender, EventArgs e)
        {
            Thread.Sleep(500);
            AddIssue newMdiChildEdit = new AddIssue();
            try
            {
                var project2 = Projects.project;

                if (project2 != null)
                {
                    //((AddIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text = project2.id.ToString() + "; ";
                    ((AddIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text += project2.ProjectName.ToString().Trim() + "; ";
                    ((AddIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text += project2.ProjectAddress.ToString().Trim() + "; ";
                    ((AddIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text += project2.ProjectCompany.ToString().Trim();
                    ((AddIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text += " (" + project2.ProjectState.ToString().Trim() + ")";
                    ((AddIssue)newMdiChildEdit).tbProjectInfoDateInInIssueForm.Text += Regex.Replace(project2.ProjectDateIn.ToString(),
                            @"\s(.*)", string.Empty, RegexOptions.IgnoreCase);
                    ((AddIssue)newMdiChildEdit).tbProjectInfoDateOutInIssueForm.Text += Regex.Replace(project2.ProjectDateOut.ToString(),
                        @"\s(.*)", string.Empty, RegexOptions.IgnoreCase);
                    newMdiChildEdit.ShowDialog();
                }
            }
            catch
            {
                Close();
            }
        }

        public void OpenMap_Load(object sender, EventArgs e)
        {
            foreach (var issueOnMap in issuesOnMap)
            {
                //issueOnTheMap = issueOnMap;
                    Bitmap bmp1 = new Bitmap(pbMap.Image);
                    using (Graphics g = Graphics.FromImage(bmp1))
                    {
                        g.DrawImage(new Bitmap(
                            System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, $@"images\redcircle.png")),
                        new Point((int)issueOnMap.IssueCoordinateX, (int)issueOnMap.IssueCoordinateY));
                        pbMap.Image = bmp1;
                    }
            }
        }

        private void bCancelAddingIssue_Click(object sender, EventArgs e)
        {
            AddIssue addissueform = new AddIssue();
            addissueform.FormClosing += new FormClosingEventHandler(this.AddIssue_FormClosing);
            addissueform.ShowDialog();
        }

        private void AddIssue_FormClosing(object sender, FormClosingEventArgs e)
        {
            OpenMap.ActiveForm.Invalidate(); 
            OpenMap.ActiveForm.Refresh();
            this.Close();
        }
    }
}
