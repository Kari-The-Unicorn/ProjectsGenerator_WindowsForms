using System;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ProjectsGenerator_WindowsForms
{
    public partial class MainWindow : Form
    {
        public static ProjectsKonstruktorEntities projectsKonstruktorEntities;
        public static Projects projects;
        public static Project project;
        public MainWindow()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1900, 1000);
            //openChildForm(new Projects());
            projectsKonstruktorEntities = new ProjectsKonstruktorEntities();
            projects = new Projects();
            openChildForm(projects);
            project = new Project();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    MainWindow testDialog = new MainWindow();

        //    if (testDialog.ShowDialog(this) == DialogResult.OK)
        //    {
        //        this.button1.Text = testDialog.Text;
        //    }
        //    else
        //    {
        //        this.button1.Text = "Cancelled";
        //    }
        //    testDialog.Dispose();
        //}

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        private void iconButton1_Click(object sender, EventArgs e)
        {
            openChildForm(new AddProject());
        }

        public void bProjects_Click(object sender, EventArgs e)
        {
            openChildForm(projects);
        }

        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panelLogo_Click(object sender, EventArgs e)
        {
            activeForm.Close();
        }
        protected void MDIChildOpenProject(object sender, System.EventArgs e)
        {
            OpenProject newMdiChildOpen = new OpenProject();
            try
            {
                //var name = (string)projects.dgvProjects.SelectedRows[0].Cells["ProjectName"].Value;
                //var project = projectsKonstruktorEntities.Projects.FirstOrDefault(q => q.ProjectName == name);
                project = projects.GetSelectedProject();

                if (project != null)
                {
                    //((OpenProject)newMdiChildOpen).tbProjectInfoGeneral.Text = project.id.ToString() + "; ";
                    ((OpenProject)newMdiChildOpen).tbProjectInfoGeneral.Text += project.ProjectName.ToString().Trim() + "; ";
                    ((OpenProject)newMdiChildOpen).tbProjectInfoGeneral.Text += project.ProjectAddress.ToString().Trim() + "; ";
                    ((OpenProject)newMdiChildOpen).tbProjectInfoGeneral.Text += project.ProjectCompany.ToString().Trim();
                    ((OpenProject)newMdiChildOpen).tbProjectInfoGeneral.Text += " (" + project.ProjectState.ToString().Trim() + ")";
                    ((OpenProject)newMdiChildOpen).tbProjectInfoDateIn.Text += Regex.Replace(project.ProjectDateIn.ToString(),
                        @"\s(.*)", string.Empty, RegexOptions.IgnoreCase);
                    ((OpenProject)newMdiChildOpen).tbProjectInfoDateOut.Text += Regex.Replace(project.ProjectDateOut.ToString(),
                        @"\s(.*)", string.Empty, RegexOptions.IgnoreCase);
                    newMdiChildOpen.ShowDialog();
                }
            }
            catch
            {
                Close();
            }
        }

        protected void MDIChildEditProject(object sender, System.EventArgs e)
        {
            EditProject newMdiChildEdit = new EditProject();
            try
            {
                project = projects.GetSelectedProject();

                if (project != null)
                {
                    ((EditProject)newMdiChildEdit).lblId.Text = project.id.ToString().Trim();
                    ((EditProject)newMdiChildEdit).tbProjectName.Text = project.ProjectName.Trim();
                    ((EditProject)newMdiChildEdit).tbProjectAddress.Text = project.ProjectAddress.ToString().Trim();
                    ((EditProject)newMdiChildEdit).tbProjectCompany.Text = project.ProjectCompany.ToString().Trim();
                    ((EditProject)newMdiChildEdit).tbProjectState.Text = project.ProjectState.ToString().Trim();
                    ((EditProject)newMdiChildEdit).dtpProjectCollectionDate.Value = project.ProjectDateIn.Value;
                    ((EditProject)newMdiChildEdit).dtpProjectCompleteDate.Value = project.ProjectDateOut.Value;
                    newMdiChildEdit.ShowDialog();
                }
            }
            catch
            {
                Close();
            }
        }
        private void iBOpenProject_Click(object sender, EventArgs e)
        {
            //    bDeleteProject_Click_1
            MDIChildOpenProject(sender, e);
            //openChildForm(new OpenProject());
        }

        private void iBEditProject_Click(object sender, EventArgs e)
        {
            //openChildForm(new EditProject());
            MDIChildEditProject(sender, e);
        }

        private void iBDeleteProject_Click(object sender, EventArgs e)
        {
            var name = (string)projects.dgvProjects.SelectedRows[0].Cells["ProjectName"].Value;
            project = projectsKonstruktorEntities.Projects.FirstOrDefault(q => q.ProjectName == name);
            var issues = projectsKonstruktorEntities.Issues.Where(q => q.ProjectId == project.id).ToList();
            var pictures = projectsKonstruktorEntities.Pictures1.Where(q => q.PictureId == project.ImageId).ToList();

            if (project != null)
            {
                projectsKonstruktorEntities.Projects.Remove(project);
                
                foreach (var issue in issues)
                {
                    projectsKonstruktorEntities.Issues.Remove(issue);
                }

                foreach (var picture in pictures)
                {
                    projectsKonstruktorEntities.Pictures1.Remove(picture);
                }

                projectsKonstruktorEntities.SaveChanges();
                projects.dgvProjects.Refresh();
                projects.Projects_Load(sender, e);
            }
        }
    }
}
