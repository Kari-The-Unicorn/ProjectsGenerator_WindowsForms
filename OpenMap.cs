using ProjectsGenerator_WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
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
            tt.SetToolTip(this.pbMap, "Zaznacz poprawkę na mapie");
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
                            MessageBox.Show("Edit project");
                            //AddIssue newMdiChildEdit = new AddIssue();
                            //newMdiChildEdit.Show();
                        }
                    }
                    if (!isEditMode)
                    {
                        imagePos = e.Location;
                        g.DrawImage(new Bitmap(
                           @"C:\Users\karol\source\repos\WindowsFormsApp1\images\redcircle.png"),
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
                    ((AddIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text = project2.id.ToString() + "; ";
                    ((AddIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text += project2.ProjectName.ToString().Trim() + "; ";
                    ((AddIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text += project2.ProjectAddress.ToString().Trim() + "; ";
                    ((AddIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text += project2.ProjectCompany.ToString().Trim();
                    ((AddIssue)newMdiChildEdit).tbProjectInfoGeneralInIssueForm.Text += " ( " + project2.ProjectState.ToString().Trim() + " )";
                    ((AddIssue)newMdiChildEdit).tbProjectInfoDateInInIssueForm.Text += project2.ProjectDateIn.ToString();
                    ((AddIssue)newMdiChildEdit).tbProjectInfoDateOutInIssueForm.Text += project2.ProjectDateOut.ToString();
                    newMdiChildEdit.Show();
                }
            }
            catch
            {
                Close();
            }
        }

        private void OpenMap_Load(object sender, EventArgs e)
        {
            foreach (var issueOnMap in issuesOnMap)
            {
                //issueOnTheMap = issueOnMap;
                Bitmap bmp1 = new Bitmap(pbMap.Image);
                using (Graphics g = Graphics.FromImage(bmp1))
                {
                    g.DrawImage(new Bitmap(
                       @"C:\Users\karol\source\repos\WindowsFormsApp1\images\redcircle.png"),
                    new Point((int)issueOnMap.IssueCoordinateX, (int)issueOnMap.IssueCoordinateY));
                    pbMap.Image = bmp1;
                }
            }
        }
    }
}
