namespace ProjectsGenerator_WindowsForms
{
    partial class Projects
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Projects));
            this.dgvProjects = new System.Windows.Forms.DataGridView();
            this.bOpenProject = new System.Windows.Forms.Button();
            this.bDeleteProject = new System.Windows.Forms.Button();
            this.bEditProject = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProjects
            // 
            this.dgvProjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvProjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvProjects.Location = new System.Drawing.Point(0, 0);
            this.dgvProjects.Margin = new System.Windows.Forms.Padding(5);
            this.dgvProjects.Name = "dgvProjects";
            this.dgvProjects.RowHeadersWidth = 51;
            this.dgvProjects.RowTemplate.Height = 24;
            this.dgvProjects.Size = new System.Drawing.Size(2008, 1163);
            this.dgvProjects.TabIndex = 0;
            this.dgvProjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProjects_CellContentClick);
            this.dgvProjects.Click += new System.EventHandler(this.dgvProjects_Click);
            // 
            // bOpenProject
            // 
            this.bOpenProject.Location = new System.Drawing.Point(2016, 0);
            this.bOpenProject.Name = "bOpenProject";
            this.bOpenProject.Size = new System.Drawing.Size(100, 42);
            this.bOpenProject.TabIndex = 1;
            this.bOpenProject.Text = "Otwórz";
            this.bOpenProject.UseVisualStyleBackColor = true;
            this.bOpenProject.Click += new System.EventHandler(this.bOpenProject_Click);
            // 
            // bDeleteProject
            // 
            this.bDeleteProject.Location = new System.Drawing.Point(2016, 96);
            this.bDeleteProject.Name = "bDeleteProject";
            this.bDeleteProject.Size = new System.Drawing.Size(101, 42);
            this.bDeleteProject.TabIndex = 2;
            this.bDeleteProject.Text = "Usuń";
            this.bDeleteProject.UseVisualStyleBackColor = true;
            this.bDeleteProject.Click += new System.EventHandler(this.bDeleteProject_Click_1);
            // 
            // bEditProject
            // 
            this.bEditProject.Location = new System.Drawing.Point(2016, 48);
            this.bEditProject.Name = "bEditProject";
            this.bEditProject.Size = new System.Drawing.Size(100, 42);
            this.bEditProject.TabIndex = 3;
            this.bEditProject.Text = "Edytuj";
            this.bEditProject.UseVisualStyleBackColor = true;
            this.bEditProject.Click += new System.EventHandler(this.bEditProject_Click);
            // 
            // Projects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1908, 1924);
            this.Controls.Add(this.bEditProject);
            this.Controls.Add(this.bDeleteProject);
            this.Controls.Add(this.bOpenProject);
            this.Controls.Add(this.dgvProjects);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.MinimumSize = new System.Drawing.Size(1918, 47);
            this.Name = "Projects";
            this.Text = "Projects";
            this.Load += new System.EventHandler(this.Projects_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProjects)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bOpenProject;
        private System.Windows.Forms.Button bDeleteProject;
        private System.Windows.Forms.Button bEditProject;
        public System.Windows.Forms.DataGridView dgvProjects;
    }
}