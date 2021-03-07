﻿namespace WindowsFormsApp1
{
    partial class AddIssue
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
            this.bAddIssue = new System.Windows.Forms.Button();
            this.bCancelAddingIssue = new System.Windows.Forms.Button();
            this.tlpAddIssueForm = new System.Windows.Forms.TableLayoutPanel();
            this.tbIssuePlace = new System.Windows.Forms.TextBox();
            this.lIssuePlace = new System.Windows.Forms.Label();
            this.lIssueDescription = new System.Windows.Forms.Label();
            this.lIssueName = new System.Windows.Forms.Label();
            this.tbIssueDescription = new System.Windows.Forms.TextBox();
            this.tbIssueName = new System.Windows.Forms.MaskedTextBox();
            this.pProjectInfoInIssueForm = new System.Windows.Forms.Panel();
            this.tbProjectInfoDateOutInIssueForm = new System.Windows.Forms.TextBox();
            this.tbProjectInfoDateInInIssueForm = new System.Windows.Forms.TextBox();
            this.lProjectInfoDateOutInIssueForm = new System.Windows.Forms.Label();
            this.lProjectInfoDateInInIssueForm = new System.Windows.Forms.Label();
            this.tbProjectInfoGeneralInIssueForm = new System.Windows.Forms.TextBox();
            this.lProjectInfoInIssueForm = new System.Windows.Forms.Label();
            this.tlpAddIssueForm.SuspendLayout();
            this.pProjectInfoInIssueForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // bAddIssue
            // 
            this.bAddIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(125)))), ((int)(((byte)(75)))));
            this.bAddIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bAddIssue.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAddIssue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bAddIssue.Location = new System.Drawing.Point(6, 487);
            this.bAddIssue.Name = "bAddIssue";
            this.bAddIssue.Size = new System.Drawing.Size(198, 48);
            this.bAddIssue.TabIndex = 1;
            this.bAddIssue.Text = "Dodaj poprawkę";
            this.bAddIssue.UseVisualStyleBackColor = false;
            this.bAddIssue.Click += new System.EventHandler(this.bAddIssue_Click);
            // 
            // bCancelAddingIssue
            // 
            this.bCancelAddingIssue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(9)))), ((int)(((byte)(0)))));
            this.bCancelAddingIssue.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.bCancelAddingIssue.Font = new System.Drawing.Font("Century Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bCancelAddingIssue.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bCancelAddingIssue.Location = new System.Drawing.Point(210, 487);
            this.bCancelAddingIssue.Name = "bCancelAddingIssue";
            this.bCancelAddingIssue.Size = new System.Drawing.Size(198, 48);
            this.bCancelAddingIssue.TabIndex = 2;
            this.bCancelAddingIssue.Text = "Anuluj";
            this.bCancelAddingIssue.UseVisualStyleBackColor = false;
            this.bCancelAddingIssue.Click += new System.EventHandler(this.bCancelAddingIssue_Click);
            // 
            // tlpAddIssueForm
            // 
            this.tlpAddIssueForm.AutoSize = true;
            this.tlpAddIssueForm.ColumnCount = 2;
            this.tlpAddIssueForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.54545F));
            this.tlpAddIssueForm.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 85.45454F));
            this.tlpAddIssueForm.Controls.Add(this.tbIssuePlace, 1, 2);
            this.tlpAddIssueForm.Controls.Add(this.lIssuePlace, 0, 2);
            this.tlpAddIssueForm.Controls.Add(this.lIssueDescription, 0, 1);
            this.tlpAddIssueForm.Controls.Add(this.lIssueName, 0, 0);
            this.tlpAddIssueForm.Controls.Add(this.tbIssueDescription, 1, 1);
            this.tlpAddIssueForm.Controls.Add(this.tbIssueName, 1, 0);
            this.tlpAddIssueForm.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tlpAddIssueForm.Location = new System.Drawing.Point(0, 110);
            this.tlpAddIssueForm.Name = "tlpAddIssueForm";
            this.tlpAddIssueForm.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tlpAddIssueForm.RowCount = 3;
            this.tlpAddIssueForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpAddIssueForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpAddIssueForm.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tlpAddIssueForm.Size = new System.Drawing.Size(1275, 342);
            this.tlpAddIssueForm.TabIndex = 3;
            this.tlpAddIssueForm.Paint += new System.Windows.Forms.PaintEventHandler(this.tlpAddIssueForm_Paint);
            // 
            // tbIssuePlace
            // 
            this.tbIssuePlace.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIssuePlace.Location = new System.Drawing.Point(188, 231);
            this.tbIssuePlace.Multiline = true;
            this.tbIssuePlace.Name = "tbIssuePlace";
            this.tbIssuePlace.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbIssuePlace.Size = new System.Drawing.Size(1082, 45);
            this.tbIssuePlace.TabIndex = 11;
            // 
            // lIssuePlace
            // 
            this.lIssuePlace.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIssuePlace.Location = new System.Drawing.Point(3, 228);
            this.lIssuePlace.Name = "lIssuePlace";
            this.lIssuePlace.Size = new System.Drawing.Size(179, 48);
            this.lIssuePlace.TabIndex = 4;
            this.lIssuePlace.Text = "Lokalizacja";
            this.lIssuePlace.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lIssuePlace.Click += new System.EventHandler(this.projectCompanyLabel_Click);
            // 
            // lIssueDescription
            // 
            this.lIssueDescription.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIssueDescription.Location = new System.Drawing.Point(3, 114);
            this.lIssueDescription.Name = "lIssueDescription";
            this.lIssueDescription.Size = new System.Drawing.Size(179, 48);
            this.lIssueDescription.TabIndex = 2;
            this.lIssueDescription.Text = "Opis";
            this.lIssueDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lIssueName
            // 
            this.lIssueName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIssueName.Location = new System.Drawing.Point(3, 0);
            this.lIssueName.Name = "lIssueName";
            this.lIssueName.Size = new System.Drawing.Size(179, 51);
            this.lIssueName.TabIndex = 0;
            this.lIssueName.Text = "Nazwa poprawki";
            this.lIssueName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tbIssueDescription
            // 
            this.tbIssueDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIssueDescription.Location = new System.Drawing.Point(188, 117);
            this.tbIssueDescription.Multiline = true;
            this.tbIssueDescription.Name = "tbIssueDescription";
            this.tbIssueDescription.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbIssueDescription.Size = new System.Drawing.Size(1082, 45);
            this.tbIssueDescription.TabIndex = 10;
            // 
            // tbIssueName
            // 
            this.tbIssueName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIssueName.Location = new System.Drawing.Point(188, 3);
            this.tbIssueName.Name = "tbIssueName";
            this.tbIssueName.Size = new System.Drawing.Size(1082, 38);
            this.tbIssueName.TabIndex = 9;
            // 
            // pProjectInfoInIssueForm
            // 
            this.pProjectInfoInIssueForm.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pProjectInfoInIssueForm.Controls.Add(this.tbProjectInfoDateOutInIssueForm);
            this.pProjectInfoInIssueForm.Controls.Add(this.tbProjectInfoDateInInIssueForm);
            this.pProjectInfoInIssueForm.Controls.Add(this.lProjectInfoDateOutInIssueForm);
            this.pProjectInfoInIssueForm.Controls.Add(this.lProjectInfoDateInInIssueForm);
            this.pProjectInfoInIssueForm.Controls.Add(this.tbProjectInfoGeneralInIssueForm);
            this.pProjectInfoInIssueForm.Controls.Add(this.lProjectInfoInIssueForm);
            this.pProjectInfoInIssueForm.Location = new System.Drawing.Point(6, 2);
            this.pProjectInfoInIssueForm.Name = "pProjectInfoInIssueForm";
            this.pProjectInfoInIssueForm.Size = new System.Drawing.Size(1269, 89);
            this.pProjectInfoInIssueForm.TabIndex = 4;
            this.pProjectInfoInIssueForm.Paint += new System.Windows.Forms.PaintEventHandler(this.pProjectInfoInIssueForm_Paint);
            // 
            // tbProjectInfoDateOutInIssueForm
            // 
            this.tbProjectInfoDateOutInIssueForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProjectInfoDateOutInIssueForm.Location = new System.Drawing.Point(1134, 4);
            this.tbProjectInfoDateOutInIssueForm.Name = "tbProjectInfoDateOutInIssueForm";
            this.tbProjectInfoDateOutInIssueForm.ReadOnly = true;
            this.tbProjectInfoDateOutInIssueForm.Size = new System.Drawing.Size(128, 29);
            this.tbProjectInfoDateOutInIssueForm.TabIndex = 6;
            // 
            // tbProjectInfoDateInInIssueForm
            // 
            this.tbProjectInfoDateInInIssueForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProjectInfoDateInInIssueForm.Location = new System.Drawing.Point(952, 3);
            this.tbProjectInfoDateInInIssueForm.Name = "tbProjectInfoDateInInIssueForm";
            this.tbProjectInfoDateInInIssueForm.ReadOnly = true;
            this.tbProjectInfoDateInInIssueForm.Size = new System.Drawing.Size(120, 29);
            this.tbProjectInfoDateInInIssueForm.TabIndex = 5;
            this.tbProjectInfoDateInInIssueForm.TextChanged += new System.EventHandler(this.tbProjectInfoDateIn_TextChanged);
            // 
            // lProjectInfoDateOutInIssueForm
            // 
            this.lProjectInfoDateOutInIssueForm.AutoSize = true;
            this.lProjectInfoDateOutInIssueForm.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProjectInfoDateOutInIssueForm.Location = new System.Drawing.Point(1078, 5);
            this.lProjectInfoDateOutInIssueForm.Name = "lProjectInfoDateOutInIssueForm";
            this.lProjectInfoDateOutInIssueForm.Size = new System.Drawing.Size(41, 22);
            this.lProjectInfoDateOutInIssueForm.TabIndex = 4;
            this.lProjectInfoDateOutInIssueForm.Text = "Do:";
            // 
            // lProjectInfoDateInInIssueForm
            // 
            this.lProjectInfoDateInInIssueForm.AutoSize = true;
            this.lProjectInfoDateInInIssueForm.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProjectInfoDateInInIssueForm.Location = new System.Drawing.Point(894, 5);
            this.lProjectInfoDateInInIssueForm.Name = "lProjectInfoDateInInIssueForm";
            this.lProjectInfoDateInInIssueForm.Size = new System.Drawing.Size(45, 22);
            this.lProjectInfoDateInInIssueForm.TabIndex = 3;
            this.lProjectInfoDateInInIssueForm.Text = "Od:";
            // 
            // tbProjectInfoGeneralInIssueForm
            // 
            this.tbProjectInfoGeneralInIssueForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbProjectInfoGeneralInIssueForm.Location = new System.Drawing.Point(96, 8);
            this.tbProjectInfoGeneralInIssueForm.Multiline = true;
            this.tbProjectInfoGeneralInIssueForm.Name = "tbProjectInfoGeneralInIssueForm";
            this.tbProjectInfoGeneralInIssueForm.ReadOnly = true;
            this.tbProjectInfoGeneralInIssueForm.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tbProjectInfoGeneralInIssueForm.Size = new System.Drawing.Size(792, 31);
            this.tbProjectInfoGeneralInIssueForm.TabIndex = 2;
            // 
            // lProjectInfoInIssueForm
            // 
            this.lProjectInfoInIssueForm.AutoSize = true;
            this.lProjectInfoInIssueForm.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lProjectInfoInIssueForm.Location = new System.Drawing.Point(3, 8);
            this.lProjectInfoInIssueForm.Name = "lProjectInfoInIssueForm";
            this.lProjectInfoInIssueForm.Size = new System.Drawing.Size(76, 22);
            this.lProjectInfoInIssueForm.TabIndex = 1;
            this.lProjectInfoInIssueForm.Text = "Projekt:";
            // 
            // AddIssue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1287, 614);
            this.Controls.Add(this.bAddIssue);
            this.Controls.Add(this.bCancelAddingIssue);
            this.Controls.Add(this.pProjectInfoInIssueForm);
            this.Controls.Add(this.tlpAddIssueForm);
            this.Name = "AddIssue";
            this.Text = "Dodaj poprawkę";
            this.tlpAddIssueForm.ResumeLayout(false);
            this.tlpAddIssueForm.PerformLayout();
            this.pProjectInfoInIssueForm.ResumeLayout(false);
            this.pProjectInfoInIssueForm.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button bAddIssue;
        private System.Windows.Forms.Button bCancelAddingIssue;
        private System.Windows.Forms.TableLayoutPanel tlpAddIssueForm;
        private System.Windows.Forms.Label lIssuePlace;
        private System.Windows.Forms.Label lIssueDescription;
        private System.Windows.Forms.Label lIssueName;
        private System.Windows.Forms.Panel pProjectInfoInIssueForm;
        public System.Windows.Forms.TextBox tbProjectInfoDateOutInIssueForm;
        public System.Windows.Forms.TextBox tbProjectInfoDateInInIssueForm;
        private System.Windows.Forms.Label lProjectInfoDateOutInIssueForm;
        private System.Windows.Forms.Label lProjectInfoDateInInIssueForm;
        public System.Windows.Forms.TextBox tbProjectInfoGeneralInIssueForm;
        private System.Windows.Forms.Label lProjectInfoInIssueForm;
        private System.Windows.Forms.TextBox tbIssuePlace;
        private System.Windows.Forms.TextBox tbIssueDescription;
        private System.Windows.Forms.MaskedTextBox tbIssueName;
    }
}