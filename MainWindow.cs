using System;
using System.Windows.Forms;
using ProjectsGenerator_WindowsForms;

namespace ProjectsGenerator_WindowsForms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    MainWindow testDialog = new MainWindow();

        //    // Show testDialog as a modal dialog and determine if DialogResult = OK.
        //    if (testDialog.ShowDialog(this) == DialogResult.OK)
        //    {
        //        // Read the contents of testDialog's TextBox.
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
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Title = "Upload file";
            openFile.Filter = "PDF|*.pdf";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                //textBox1.Text = openFile.FileName;
                //textBox1.Text = openFile.SafeFileName;
                MessageBox.Show("Click OK to confirm: " + openFile.SafeFileName);
            }
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

        private void bProjects_Click(object sender, EventArgs e)
        {
            openChildForm(new Projects());
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
    }
}
