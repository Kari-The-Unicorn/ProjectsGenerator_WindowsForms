using ProjectsGenerator_WindowsForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class EditIssue : Form
    {
        public bool isCancelled = false;
        public static OpenProject openProject = new OpenProject();
        public static OpenMap newMdiChildMap = new OpenMap();
        Projects project4 = new Projects();
        Issue issueOnTheMap = new Issue();
        Pictures1 pictures1 = new Pictures1();
        private readonly ProjectsKonstruktorEntities projectsKonstruktorEntities;
        private readonly List<Issue> issuesOnMap = new List<Issue>();

        public EditIssue()
        {
            InitializeComponent();
            //issuesOnMap = projectsKonstruktorEntities.Issues.ToList();
            projectsKonstruktorEntities = new ProjectsKonstruktorEntities();
        }

        private void EditIssue_Load(object sender, EventArgs e)
        {   
        }

        private void bCancelAddingIssue_Click(object sender, EventArgs e)
        {
            isCancelled = true;
            Close();
        }

        private void pProjectInfoInIssueForm_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pProjectInfoInIssueForm.DisplayRectangle, Color.LightSkyBlue, ButtonBorderStyle.Solid);
        }

        private void bSaveEditingIssue_Click(object sender, EventArgs e)
        {
            try
            {
                var idBase = int.Parse(lId.Text);
                Issue issue = projectsKonstruktorEntities.Issues
                    .FirstOrDefault(q => q.id == idBase);
                string issueName = tbIssueName.Text.Trim();
                string issueDescription = tbIssueDescription.Text.Trim();
                string issuePlace = tbIssuePlace.Text.Trim();

                if (issueName != null)
                {
                    issue.IssueName = issueName;
                    issue.IssueDescription = issueDescription;
                    issue.IssuePlace = issuePlace;
                    projectsKonstruktorEntities.SaveChanges();
                    Close();
                }
            }
            catch
            {
                Close();
            }

        }

        private void bDeleteIssue_Click(object sender, EventArgs e)
        {
            try
            {
                var idBase = int.Parse(lId.Text);
                Issue issue = projectsKonstruktorEntities.Issues
                    .FirstOrDefault(q => q.id == idBase);
                projectsKonstruktorEntities.Issues.Remove(issue);
                projectsKonstruktorEntities.SaveChanges();
                Close();

                for (int index = Application.OpenForms.Count - 1; index >= 0; index--)
                {
                    if (Application.OpenForms[index].Name == "OpenMap")
                    {
                        Application.OpenForms[index].Hide();
                    }
                    else if (Application.OpenForms[index].Name == "EditIssue")
                    {
                        Application.OpenForms[index].Hide();
                    }
                }

                openProject.bShowMap_Click(sender, e);
            }
            catch
            {
                Close();
            }
        }
    }
}
