using System;
using System.Linq;
using System.Windows.Forms;

namespace ProjectsGenerator_WindowsForms
{
    public partial class Projects : Form
    {
        private readonly ProjectsKonstruktorEntities projectsKonstruktorEntities;
        public Projects()
        {
            InitializeComponent();
            projectsKonstruktorEntities = new ProjectsKonstruktorEntities();
        }

        private void Projects_Load(object sender, EventArgs e)
        {
            //// select * from projects table
            var projects = projectsKonstruktorEntities.Projects.ToList();
            dgvProjects.DataSource = projects;
            dgvProjects.Columns["id"].Visible = false;
            dgvProjects.Columns["Issues"].Visible = false;
            this.dgvProjects.Columns["ProjectName"].HeaderText = "Nazwa";
            this.dgvProjects.Columns["ProjectAddress"].HeaderText = "Adres";
            this.dgvProjects.Columns["ProjectCompany"].HeaderText = "Firma";
            this.dgvProjects.Columns["ProjectState"].HeaderText = "Stan";
            this.dgvProjects.Columns["ProjectDateIn"].HeaderText = "Od dnia";
            this.dgvProjects.Columns["ProjectDateOut"].HeaderText = "Do dnia";

            DataGridViewButtonColumn bOpenProject = new DataGridViewButtonColumn();
            {
                //bOpenProject.Name = "button";
                //bOpenProject.HeaderText = "Otwórz";
                bOpenProject.Text = "Otwórz";
                bOpenProject.UseColumnTextForButtonValue = true;
                this.dgvProjects.Columns.Add(bOpenProject);
            }


            DataGridViewButtonColumn bEditProject = new DataGridViewButtonColumn();
            {
                //bEditProject.Name = "button";
                //bEditProject.HeaderText = "Edytuj";
                bEditProject.Text = "Edytuj";
                bEditProject.UseColumnTextForButtonValue = true;
                this.dgvProjects.Columns.Add(bEditProject);
            }

            DataGridViewButtonColumn bDeleteProject = new DataGridViewButtonColumn();
            {
                //bDeleteProject.Name = "button";
                //bDeleteProject.HeaderText = "Usuń";
                bDeleteProject.Text = "Usuń";
                bDeleteProject.UseColumnTextForButtonValue = true;
                this.dgvProjects.Columns.Add(bDeleteProject);
            }
            //dgvProjects.Columns["Projects1"].Visible = false;
            //dgvProjects.Columns["Project1"].Visible = false;
        }

        private void dgvProjects_Click(object sender, EventArgs e)
        {

        }

        //Show Image On Button
        //private void dgvProjects_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        //{
        //    if (e.RowIndex < 0)
        //        return;

        //    if (e.ColumnIndex == 0)
        //    {
        //        e.Paint(e.CellBounds, DataGridViewPaintParts.All);

        //        var w = ProjectsGenerator.Properties.Resources.logo.Width;
        //        var h = ProjectsGenerator.Properties.Resources.logo.Height;
        //        var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
        //        var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

        //        e.Graphics.DrawImage(ProjectsGenerator.Properties.Resources.logo,
        //            new Rectangle(x, y, w, h));
        //        e.Handled = true;
        //    }
        //}
    }
}
