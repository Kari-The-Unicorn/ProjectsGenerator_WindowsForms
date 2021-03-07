using System.Drawing;
using ProjectsGenerator_WindowsForms.Properties;

namespace ProjectsGenerator_WindowsForms
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.bDeleteProject = new FontAwesome.Sharp.IconButton();
            this.bEditProject = new FontAwesome.Sharp.IconButton();
            this.bOpenProject = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bProjects = new FontAwesome.Sharp.IconButton();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.panelSideMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(137)))), ((int)(((byte)(218)))), ((int)(((byte)(220)))));
            this.panelSideMenu.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelSideMenu.Controls.Add(this.bDeleteProject);
            this.panelSideMenu.Controls.Add(this.bEditProject);
            this.panelSideMenu.Controls.Add(this.bOpenProject);
            this.panelSideMenu.Controls.Add(this.panel1);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(165, 661);
            this.panelSideMenu.TabIndex = 2;
            this.panelSideMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bDeleteProject
            // 
            this.bDeleteProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bDeleteProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bDeleteProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.bDeleteProject.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.bDeleteProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bDeleteProject.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bDeleteProject.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.bDeleteProject.IconColor = System.Drawing.Color.Black;
            this.bDeleteProject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bDeleteProject.IconSize = 25;
            this.bDeleteProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bDeleteProject.Location = new System.Drawing.Point(0, 315);
            this.bDeleteProject.Name = "bDeleteProject";
            this.bDeleteProject.Size = new System.Drawing.Size(161, 48);
            this.bDeleteProject.TabIndex = 6;
            this.bDeleteProject.Text = "Usuń";
            this.bDeleteProject.UseVisualStyleBackColor = false;
            this.bDeleteProject.Click += new System.EventHandler(this.iBDeleteProject_Click);
            // 
            // bEditProject
            // 
            this.bEditProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bEditProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEditProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.bEditProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bEditProject.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditProject.IconChar = FontAwesome.Sharp.IconChar.Edit;
            this.bEditProject.IconColor = System.Drawing.Color.Black;
            this.bEditProject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bEditProject.IconSize = 25;
            this.bEditProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bEditProject.Location = new System.Drawing.Point(0, 266);
            this.bEditProject.Name = "bEditProject";
            this.bEditProject.Size = new System.Drawing.Size(161, 49);
            this.bEditProject.TabIndex = 5;
            this.bEditProject.Text = "Edytuj";
            this.bEditProject.UseVisualStyleBackColor = false;
            this.bEditProject.Click += new System.EventHandler(this.iBEditProject_Click);
            // 
            // bOpenProject
            // 
            this.bOpenProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bOpenProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bOpenProject.Dock = System.Windows.Forms.DockStyle.Top;
            this.bOpenProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bOpenProject.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bOpenProject.IconChar = FontAwesome.Sharp.IconChar.FolderOpen;
            this.bOpenProject.IconColor = System.Drawing.Color.Black;
            this.bOpenProject.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bOpenProject.IconSize = 25;
            this.bOpenProject.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bOpenProject.Location = new System.Drawing.Point(0, 218);
            this.bOpenProject.Name = "bOpenProject";
            this.bOpenProject.Size = new System.Drawing.Size(161, 48);
            this.bOpenProject.TabIndex = 4;
            this.bOpenProject.Text = "Otwórz";
            this.bOpenProject.UseVisualStyleBackColor = false;
            this.bOpenProject.Click += new System.EventHandler(this.iBOpenProject_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.Controls.Add(this.bProjects);
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 123);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(161, 95);
            this.panel1.TabIndex = 2;
            // 
            // bProjects
            // 
            this.bProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bProjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bProjects.Dock = System.Windows.Forms.DockStyle.Top;
            this.bProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bProjects.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bProjects.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.bProjects.IconColor = System.Drawing.Color.Black;
            this.bProjects.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bProjects.IconSize = 25;
            this.bProjects.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bProjects.Location = new System.Drawing.Point(0, 47);
            this.bProjects.Name = "bProjects";
            this.bProjects.Size = new System.Drawing.Size(161, 48);
            this.bProjects.TabIndex = 3;
            this.bProjects.Text = "Projekty";
            this.bProjects.UseVisualStyleBackColor = false;
            this.bProjects.Click += new System.EventHandler(this.bProjects_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.iconButton1.IconColor = System.Drawing.Color.Black;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 0);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(161, 47);
            this.iconButton1.TabIndex = 1;
            this.iconButton1.Text = "Nowy projekt";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panelLogo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelLogo.BackgroundImage")));
            this.panelLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelLogo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelLogo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(161, 123);
            this.panelLogo.TabIndex = 0;
            this.panelLogo.Click += new System.EventHandler(this.panelLogo_Click);
            this.panelLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelLogo_Paint);
            // 
            // panelChildForm
            // 
            this.panelChildForm.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(165, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(1047, 661);
            this.panelChildForm.TabIndex = 3;
            this.panelChildForm.Paint += new System.Windows.Forms.PaintEventHandler(this.panelChildForm_Paint);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1212, 661);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelSideMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Konstruktor";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelSideMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private FontAwesome.Sharp.IconButton bProjects;
        private System.Windows.Forms.Panel panelChildForm;
        private FontAwesome.Sharp.IconButton bDeleteProject;
        private FontAwesome.Sharp.IconButton bEditProject;
        private FontAwesome.Sharp.IconButton bOpenProject;
    }
}

