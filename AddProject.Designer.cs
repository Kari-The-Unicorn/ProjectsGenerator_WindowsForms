namespace ProjectsGenerator_WindowsForms
{
    partial class AddProject
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddProject));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lUploadImage = new System.Windows.Forms.Label();
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
            this.bUploadImage = new System.Windows.Forms.Button();
            this.lLoadedImageInfo = new System.Windows.Forms.Label();
            this.bAddProject = new System.Windows.Forms.Button();
            this.bCancelAddingProject = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.82019F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.17981F));
            this.tableLayoutPanel1.Controls.Add(this.lUploadImage, 0, 6);
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
            this.tableLayoutPanel1.Controls.Add(this.bUploadImage, 1, 6);
            this.tableLayoutPanel1.Controls.Add(this.lLoadedImageInfo, 1, 7);
            this.tableLayoutPanel1.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tableLayoutPanel1.RowCount = 8;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.4916F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49159F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49159F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49159F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.49159F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.28774F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.98789F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7.266402F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(951, 527);
            this.tableLayoutPanel1.TabIndex = 2;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // lUploadImage
            // 
            this.lUploadImage.Location = new System.Drawing.Point(3, 389);
            this.lUploadImage.Name = "lUploadImage";
            this.lUploadImage.Size = new System.Drawing.Size(191, 65);
            this.lUploadImage.TabIndex = 17;
            this.lUploadImage.Text = "Załaduj plik";
            this.lUploadImage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbProjectState
            // 
            this.tbProjectState.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProjectState.Location = new System.Drawing.Point(201, 198);
            this.tbProjectState.Name = "tbProjectState";
            this.tbProjectState.Size = new System.Drawing.Size(739, 45);
            this.tbProjectState.TabIndex = 12;
            // 
            // tbProjectCompany
            // 
            this.tbProjectCompany.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProjectCompany.Location = new System.Drawing.Point(201, 133);
            this.tbProjectCompany.Name = "tbProjectCompany";
            this.tbProjectCompany.Size = new System.Drawing.Size(739, 45);
            this.tbProjectCompany.TabIndex = 11;
            // 
            // projectStateLabel
            // 
            this.projectStateLabel.Location = new System.Drawing.Point(3, 195);
            this.projectStateLabel.Name = "projectStateLabel";
            this.projectStateLabel.Size = new System.Drawing.Size(191, 65);
            this.projectStateLabel.TabIndex = 6;
            this.projectStateLabel.Text = "Status";
            this.projectStateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // projectCompanyLabel
            // 
            this.projectCompanyLabel.Location = new System.Drawing.Point(3, 130);
            this.projectCompanyLabel.Name = "projectCompanyLabel";
            this.projectCompanyLabel.Size = new System.Drawing.Size(191, 65);
            this.projectCompanyLabel.TabIndex = 4;
            this.projectCompanyLabel.Text = "Firma";
            this.projectCompanyLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // projectAddressLabel
            // 
            this.projectAddressLabel.Location = new System.Drawing.Point(3, 65);
            this.projectAddressLabel.Name = "projectAddressLabel";
            this.projectAddressLabel.Size = new System.Drawing.Size(191, 65);
            this.projectAddressLabel.TabIndex = 2;
            this.projectAddressLabel.Text = "Adres";
            this.projectAddressLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // projectNameLabel
            // 
            this.projectNameLabel.Location = new System.Drawing.Point(3, 0);
            this.projectNameLabel.Name = "projectNameLabel";
            this.projectNameLabel.Size = new System.Drawing.Size(191, 65);
            this.projectNameLabel.TabIndex = 0;
            this.projectNameLabel.Text = "Nazwa projektu";
            this.projectNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // projectCollectionDateLabel
            // 
            this.projectCollectionDateLabel.Location = new System.Drawing.Point(3, 260);
            this.projectCollectionDateLabel.Name = "projectCollectionDateLabel";
            this.projectCollectionDateLabel.Size = new System.Drawing.Size(191, 65);
            this.projectCollectionDateLabel.TabIndex = 7;
            this.projectCollectionDateLabel.Text = "Data oddania";
            this.projectCollectionDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // projectCompleteDateLabel
            // 
            this.projectCompleteDateLabel.Location = new System.Drawing.Point(3, 325);
            this.projectCompleteDateLabel.Name = "projectCompleteDateLabel";
            this.projectCompleteDateLabel.Size = new System.Drawing.Size(191, 64);
            this.projectCompleteDateLabel.TabIndex = 8;
            this.projectCompleteDateLabel.Text = "Data ukończenia";
            this.projectCompleteDateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.projectCompleteDateLabel.Click += new System.EventHandler(this.label4_Click);
            // 
            // tbProjectAddress
            // 
            this.tbProjectAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProjectAddress.Location = new System.Drawing.Point(201, 68);
            this.tbProjectAddress.Name = "tbProjectAddress";
            this.tbProjectAddress.Size = new System.Drawing.Size(739, 45);
            this.tbProjectAddress.TabIndex = 10;
            // 
            // tbProjectName
            // 
            this.tbProjectName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProjectName.Location = new System.Drawing.Point(201, 3);
            this.tbProjectName.Name = "tbProjectName";
            this.tbProjectName.Size = new System.Drawing.Size(739, 45);
            this.tbProjectName.TabIndex = 9;
            // 
            // dtpProjectCollectionDate
            // 
            this.dtpProjectCollectionDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpProjectCollectionDate.Location = new System.Drawing.Point(201, 263);
            this.dtpProjectCollectionDate.Name = "dtpProjectCollectionDate";
            this.dtpProjectCollectionDate.Size = new System.Drawing.Size(273, 38);
            this.dtpProjectCollectionDate.TabIndex = 15;
            this.dtpProjectCollectionDate.Value = new System.DateTime(2020, 11, 29, 21, 23, 3, 0);
            // 
            // dtpProjectCompleteDate
            // 
            this.dtpProjectCompleteDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpProjectCompleteDate.Location = new System.Drawing.Point(201, 328);
            this.dtpProjectCompleteDate.Name = "dtpProjectCompleteDate";
            this.dtpProjectCompleteDate.Size = new System.Drawing.Size(273, 38);
            this.dtpProjectCompleteDate.TabIndex = 16;
            // 
            // bUploadImage
            // 
            this.bUploadImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bUploadImage.Location = new System.Drawing.Point(201, 392);
            this.bUploadImage.Name = "bUploadImage";
            this.bUploadImage.Size = new System.Drawing.Size(191, 42);
            this.bUploadImage.TabIndex = 18;
            this.bUploadImage.Text = "Załaduj obrazek";
            this.bUploadImage.UseVisualStyleBackColor = true;
            this.bUploadImage.Click += new System.EventHandler(this.bUploadImage_Click_1);
            // 
            // lLoadedImageInfo
            // 
            this.lLoadedImageInfo.Location = new System.Drawing.Point(201, 483);
            this.lLoadedImageInfo.Name = "lLoadedImageInfo";
            this.lLoadedImageInfo.Size = new System.Drawing.Size(507, 44);
            this.lLoadedImageInfo.TabIndex = 19;
            this.lLoadedImageInfo.Text = "Wybierz plik";
            this.lLoadedImageInfo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // bAddProject
            // 
            this.bAddProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bAddProject.Location = new System.Drawing.Point(0, 545);
            this.bAddProject.Name = "bAddProject";
            this.bAddProject.Size = new System.Drawing.Size(198, 48);
            this.bAddProject.TabIndex = 3;
            this.bAddProject.Text = "Dodaj projekt";
            this.bAddProject.UseVisualStyleBackColor = true;
            this.bAddProject.Click += new System.EventHandler(this.bAddProject_Click);
            // 
            // bCancelAddingProject
            // 
            this.bCancelAddingProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bCancelAddingProject.Location = new System.Drawing.Point(204, 545);
            this.bCancelAddingProject.Name = "bCancelAddingProject";
            this.bCancelAddingProject.Size = new System.Drawing.Size(202, 48);
            this.bCancelAddingProject.TabIndex = 5;
            this.bCancelAddingProject.Text = "Anuluj";
            this.bCancelAddingProject.UseVisualStyleBackColor = true;
            this.bCancelAddingProject.Click += new System.EventHandler(this.cancelAddingProjectButton_Click);
            // 
            // AddProject
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 614);
            this.Controls.Add(this.bCancelAddingProject);
            this.Controls.Add(this.bAddProject);
            this.Controls.Add(this.tableLayoutPanel1);
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddProject";
            this.Text = "Dodaj projekt";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button bAddProject;
        private System.Windows.Forms.Button bCancelAddingProject;
        private System.Windows.Forms.Label projectStateLabel;
        private System.Windows.Forms.Label projectCompanyLabel;
        private System.Windows.Forms.Label projectAddressLabel;
        private System.Windows.Forms.Label projectNameLabel;
        private System.Windows.Forms.TextBox tbProjectState;
        private System.Windows.Forms.TextBox tbProjectCompany;
        private System.Windows.Forms.Label projectCollectionDateLabel;
        private System.Windows.Forms.Label projectCompleteDateLabel;
        private System.Windows.Forms.MaskedTextBox tbProjectName;
        private System.Windows.Forms.TextBox tbProjectAddress;
        private System.Windows.Forms.DateTimePicker dtpProjectCompleteDate;
        private System.Windows.Forms.DateTimePicker dtpProjectCollectionDate;
        private System.Windows.Forms.Label lUploadImage;
        private System.Windows.Forms.Button bUploadImage;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lLoadedImageInfo;
    }
}