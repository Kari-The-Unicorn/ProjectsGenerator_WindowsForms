﻿using System;
using System.Drawing;
using System.Windows.Forms;

namespace ProjectsGenerator_WindowsForms
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MinimumSize = new Size(1900, 1000);
            openChildForm(new Projects());
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
