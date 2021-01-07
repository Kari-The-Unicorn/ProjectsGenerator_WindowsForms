namespace ProjectsGenerator_WindowsForms
{
    partial class EditProject
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tbProjectState = new System.Windows.Forms.TextBox();
            this.tbProjectCompany = new System.Windows.Forms.TextBox();
            this.projectStateLabel = new System.Windows.Forms.Label();
            this.projectCompanyLabel = new System.Windows.Forms.Label();
            this.projectAddressLabel = new System.Windows.Forms.Label();
            this.projectNameLabel = new System.Windows.Forms.Label();
            this.projectCollectionDateLabel = new System.Windows.Forms.Label();
            this.projectCompleteDateLabel = new System.Windows.Forms.Label();
            this.tbProjectAddress = new System.Windows.Forms.TextBox();
            this.tbProjectName = new System.Windows.Forms.MaskedTextBox();
            this.dtpProjectCollectionDate = new System.Windows.Forms.DateTimePicker();
            this.dtpProjectCompleteDate = new System.Windows.Forms.DateTimePicker();
            this.bEditProject = new System.Windows.Forms.Button();
            this.bCancelEditingProject = new System.Windows.Forms.Button();
            this.lblId = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.82019F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.17981F));
            this.tableLayoutPanel1.Controls.Add(this.tbProjectState, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.tbProjectCompany, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.projectStateLabel, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.projectCompanyLabel, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.projectAddressLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.projectNameLabel, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.projectCollectionDateLabel, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.projectCompleteDateLabel, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.tbProjectAddress, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbProjectName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpProjectCollectionDate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpProjectCompleteDate, 1, 5);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(943, 507);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tbProjectState
            // 
            this.tbProjectState.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProjectState.Location = new System.Drawing.Point(199, 255);
            this.tbProjectState.Name = "tbProjectState";
            this.tbProjectState.Size = new System.Drawing.Size(739, 45);
            this.tbProjectState.TabIndex = 12;
            // 
            // tbProjectCompany
            // 
            this.tbProjectCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProjectCompany.Location = new System.Drawing.Point(199, 171);
            this.tbProjectCompany.Name = "tbProjectCompany";
            this.tbProjectCompany.Size = new System.Drawing.Size(739, 45);
            this.tbProjectCompany.TabIndex = 11;
            // 
            // projectStateLabel
            // 
            this.projectStateLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectStateLabel.Location = new System.Drawing.Point(3, 252);
            this.projectStateLabel.Name = "projectStateLabel";
            this.projectStateLabel.Size = new System.Drawing.Size(190, 48);
            this.projectStateLabel.TabIndex = 6;
            this.projectStateLabel.Text = "Status";
            this.projectStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // projectCompanyLabel
            // 
            this.projectCompanyLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectCompanyLabel.Location = new System.Drawing.Point(3, 168);
            this.projectCompanyLabel.Name = "projectCompanyLabel";
            this.projectCompanyLabel.Size = new System.Drawing.Size(190, 48);
            this.projectCompanyLabel.TabIndex = 4;
            this.projectCompanyLabel.Text = "Firma";
            this.projectCompanyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // projectAddressLabel
            // 
            this.projectAddressLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectAddressLabel.Location = new System.Drawing.Point(3, 84);
            this.projectAddressLabel.Name = "projectAddressLabel";
            this.projectAddressLabel.Size = new System.Drawing.Size(190, 48);
            this.projectAddressLabel.TabIndex = 2;
            this.projectAddressLabel.Text = "Adres";
            this.projectAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectNameLabel.Location = new System.Drawing.Point(3, 0);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(190, 48);
            this.projectNameLabel.TabIndex = 0;
            this.projectNameLabel.Text = "Nazwa projektu";
            this.projectNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // projectCollectionDateLabel
            // 
            this.projectCollectionDateLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectCollectionDateLabel.Location = new System.Drawing.Point(3, 336);
            this.projectCollectionDateLabel.Name = "projectCollectionDateLabel";
            this.projectCollectionDateLabel.Size = new System.Drawing.Size(190, 41);
            this.projectCollectionDateLabel.TabIndex = 7;
            this.projectCollectionDateLabel.Text = "Data rozpoczęcia";
            this.projectCollectionDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // projectCompleteDateLabel
            // 
            this.projectCompleteDateLabel.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.projectCompleteDateLabel.Location = new System.Drawing.Point(3, 420);
            this.projectCompleteDateLabel.Name = "projectCompleteDateLabel";
            this.projectCompleteDateLabel.Size = new System.Drawing.Size(190, 41);
            this.projectCompleteDateLabel.TabIndex = 8;
            this.projectCompleteDateLabel.Text = "Data ukończenia";
            this.projectCompleteDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbProjectAddress
            // 
            this.tbProjectAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProjectAddress.Location = new System.Drawing.Point(199, 87);
            this.tbProjectAddress.Name = "tbProjectAddress";
            this.tbProjectAddress.Size = new System.Drawing.Size(739, 45);
            this.tbProjectAddress.TabIndex = 10;
            // 
            // tbProjectName
            // 
            this.tbProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProjectName.Location = new System.Drawing.Point(199, 3);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(739, 45);
            this.tbProjectName.TabIndex = 9;
            // 
            // dtpProjectCollectionDate
            // 
            this.dtpProjectCollectionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpProjectCollectionDate.Location = new System.Drawing.Point(199, 339);
            this.dtpProjectCollectionDate.Name = "dtpProjectCollectionDate";
            this.dtpProjectCollectionDate.Size = new System.Drawing.Size(273, 38);
            this.dtpProjectCollectionDate.TabIndex = 15;
            this.dtpProjectCollectionDate.Value = new System.DateTime(2020, 11, 29, 21, 23, 3, 0);
            // 
            // dtpProjectCompleteDate
            // 
            this.dtpProjectCompleteDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpProjectCompleteDate.Location = new System.Drawing.Point(199, 423);
            this.dtpProjectCompleteDate.Name = "dtpProjectCompleteDate";
            this.dtpProjectCompleteDate.Size = new System.Drawing.Size(273, 38);
            this.dtpProjectCompleteDate.TabIndex = 16;
            // 
            // bEditProject
            // 
            this.bEditProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(125)))), ((int)(((byte)(75)))));
            this.bEditProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bEditProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bEditProject.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEditProject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bEditProject.Location = new System.Drawing.Point(0, 545);
            this.bEditProject.Name = "bEditProject";
            this.bEditProject.Size = new System.Drawing.Size(198, 48);
            this.bEditProject.TabIndex = 3;
            this.bEditProject.Text = "Zapisz";
            this.bEditProject.UseVisualStyleBackColor = false;
            this.bEditProject.Click += new System.EventHandler(this.bEditProject_Click);
            // 
            // bCancelEditingProject
            // 
            this.bCancelEditingProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(9)))), ((int)(((byte)(0)))));
            this.bCancelEditingProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancelEditingProject.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCancelEditingProject.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelEditingProject.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bCancelEditingProject.Location = new System.Drawing.Point(204, 545);
            this.bCancelEditingProject.Name = "bCancelEditingProject";
            this.bCancelEditingProject.Size = new System.Drawing.Size(202, 48);
            this.bCancelEditingProject.TabIndex = 5;
            this.bCancelEditingProject.Text = "Anuluj";
            this.bCancelEditingProject.UseVisualStyleBackColor = false;
            this.bCancelEditingProject.Click += new System.EventHandler(this.bCancelEditingProject_Click);
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(579, 561);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(0, 17);
            this.lblId.TabIndex = 6;
            // 
            // EditProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 618);
            this.Controls.Add(this.lblId);
            this.Controls.Add(this.bCancelEditingProject);
            this.Controls.Add(this.bEditProject);
            this.Controls.Add(this.tableLayoutPanel1);
            this.HelpButton = true;
            this.Name = "EditProject";
            this.Text = "Edytuj projekt";
            this.Load += new System.EventHandler(this.EditProject_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button bEditProject;
        private System.Windows.Forms.Button bCancelEditingProject;
        private System.Windows.Forms.Label projectStateLabel;
        private System.Windows.Forms.Label projectCompanyLabel;
        private System.Windows.Forms.Label projectAddressLabel;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.Label projectCollectionDateLabel;
        private System.Windows.Forms.Label projectCompleteDateLabel;
        public System.Windows.Forms.MaskedTextBox tbProjectName;
        public System.Windows.Forms.TextBox tbProjectState;
        public System.Windows.Forms.TextBox tbProjectCompany;
        public System.Windows.Forms.TextBox tbProjectAddress;
        public System.Windows.Forms.DateTimePicker dtpProjectCompleteDate;
        public System.Windows.Forms.DateTimePicker dtpProjectCollectionDate;
        public System.Windows.Forms.Label lblId;
    }
}