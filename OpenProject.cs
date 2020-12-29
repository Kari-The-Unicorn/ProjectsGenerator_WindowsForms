using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using WindowsFormsApp1;

namespace ProjectsGenerator_WindowsForms
{
    public partial class OpenProject : Form
    {
        private readonly ProjectsKonstruktorEntities projectsKonstruktorEntities;

        public Project project1;
        private int? pictureId1;

        public OpenProject()
        {
            InitializeComponent();
            projectsKonstruktorEntities = new ProjectsKonstruktorEntities();
        }

        private void tbProjectInfoDateIn_TextChanged(object sender, EventArgs e)
        {

        }

        private void lProjectInfoDateOut_Click(object sender, EventArgs e)
        {

        }

        private void pProjectInfo_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, pProjectInfo.DisplayRectangle, Color.LightSkyBlue, ButtonBorderStyle.Solid);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void bLoadIssues_Click(object sender, EventArgs e)
        {
            var issues = projectsKonstruktorEntities.Issues.ToList();
            dgvIssues.DataSource = issues;
        }

        private void dgvIssues_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            
        }

        private void OpenProject_Load(object sender, EventArgs e)
        {
            var issues = projectsKonstruktorEntities.Issues.ToList();
            dgvIssues.DataSource = issues;
            dgvIssues.Columns["id"].HeaderText = "Numer";
            dgvIssues.Columns["IssueName"].HeaderText = "Nazwa poprawki";
            dgvIssues.Columns["IssueDescription"].HeaderText = "Opis";
            dgvIssues.Columns["IssuePlace"].HeaderText = "Lokalizacja";
            dgvIssues.Columns["Pictures1"].Visible = false;
            dgvIssues.Columns["ProjectId"].Visible = false;
            dgvIssues.Columns["ImageId"].Visible = false;
            dgvIssues.Columns["IssueCoordinateX"].Visible = false;
            dgvIssues.Columns["IssueCoordinateY"].Visible = false;
            dgvIssues.Columns["Project"].Visible = false;
        }

        //private void bAddIssue_Click(object sender, EventArgs e)
        //{
        //    AddIssue newMdiChildEdit = new AddIssue();
        //    newMdiChildEdit.Show();
        //}

        private void dgvIssues_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void bShowMap_Click(object sender, EventArgs e)
        {
            OpenMap newMdiChildMap = new OpenMap();
            try
            {
                project1 = Projects.project;
                pictureId1 = project1.ImageId;
                
                if (project1 != null && pictureId1 != null)
                {
                    ((OpenMap)newMdiChildMap).pbMap.Image = System.Drawing.Image.FromFile(projectsKonstruktorEntities.Pictures1
                               .FirstOrDefault(q => q.PictureId == pictureId1).PictureName.ToString());
                    Byte[] byteBLOBData = (Byte[])projectsKonstruktorEntities.Pictures1
                        .FirstOrDefault(q => q.PictureId == pictureId1).PictureContent;
                    MemoryStream ms = new MemoryStream(byteBLOBData);
                    ms.Write(byteBLOBData, 0, byteBLOBData.Length);
                    ms.Position = 0;
                    ((OpenMap)newMdiChildMap).pbMap.Image = Image.FromStream(ms);
                    newMdiChildMap.Show();
                }
            }
            catch
            {
                Close();
            }
        }

        private void tbProjectInfoGeneral_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
