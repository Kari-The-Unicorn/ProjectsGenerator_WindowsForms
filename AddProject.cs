using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AddProject : Form
    {
        public AddProject()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cancelAddingProjectButton_Click(object sender, EventArgs e)
        {
            this.Close();
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

                if (string.IsNullOrWhiteSpace(projectName))
                {
                    isValid = false;
                    MessageBox.Show("Proszę wpisać nazwę projektu.");
                }

                if (projectDateIn > projectDateOut)
                {
                    isValid = false;
                    MessageBox.Show("Data rozpoczęcia nie może być późniejsza niż data ukończenia.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //throw;
            }
        }
    }
}
