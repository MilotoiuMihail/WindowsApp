namespace FacultyApp
{
    partial class AdminMainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminMainForm));
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.btnManageYears = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnManageStudents = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btnManageSubjects = new System.Windows.Forms.ToolStripButton();
            this.btnLogout = new System.Windows.Forms.Button();
            this.gbStats = new System.Windows.Forms.GroupBox();
            this.gbYears = new System.Windows.Forms.GroupBox();
            this.lYearCount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lineChart1 = new ControlsLibrary.LineChart();
            this.gbSubjects = new System.Windows.Forms.GroupBox();
            this.lSubjectCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbStudents = new System.Windows.Forms.GroupBox();
            this.lStudentCount = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.toolStrip.SuspendLayout();
            this.gbStats.SuspendLayout();
            this.gbYears.SuspendLayout();
            this.gbSubjects.SuspendLayout();
            this.gbStudents.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnManageYears,
            this.toolStripSeparator1,
            this.btnManageStudents,
            this.toolStripSeparator2,
            this.btnManageSubjects});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(639, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // btnManageYears
            // 
            this.btnManageYears.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnManageYears.Image = ((System.Drawing.Image)(resources.GetObject("btnManageYears.Image")));
            this.btnManageYears.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnManageYears.Name = "btnManageYears";
            this.btnManageYears.Size = new System.Drawing.Size(38, 22);
            this.btnManageYears.Text = "Years";
            this.btnManageYears.Click += new System.EventHandler(this.btnManageYears_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // btnManageStudents
            // 
            this.btnManageStudents.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnManageStudents.Image = ((System.Drawing.Image)(resources.GetObject("btnManageStudents.Image")));
            this.btnManageStudents.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnManageStudents.Name = "btnManageStudents";
            this.btnManageStudents.Size = new System.Drawing.Size(57, 22);
            this.btnManageStudents.Text = "Students";
            this.btnManageStudents.Click += new System.EventHandler(this.btnManageStudents_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // btnManageSubjects
            // 
            this.btnManageSubjects.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.btnManageSubjects.Image = ((System.Drawing.Image)(resources.GetObject("btnManageSubjects.Image")));
            this.btnManageSubjects.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnManageSubjects.Name = "btnManageSubjects";
            this.btnManageSubjects.Size = new System.Drawing.Size(55, 22);
            this.btnManageSubjects.Text = "Subjects";
            this.btnManageSubjects.Click += new System.EventHandler(this.btnManageSubjects_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(528, 371);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 2;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // gbStats
            // 
            this.gbStats.Controls.Add(this.gbStudents);
            this.gbStats.Controls.Add(this.gbSubjects);
            this.gbStats.Controls.Add(this.gbYears);
            this.gbStats.Location = new System.Drawing.Point(12, 51);
            this.gbStats.Name = "gbStats";
            this.gbStats.Size = new System.Drawing.Size(223, 343);
            this.gbStats.TabIndex = 3;
            this.gbStats.TabStop = false;
            this.gbStats.Text = "Stats";
            // 
            // gbYears
            // 
            this.gbYears.Controls.Add(this.lYearCount);
            this.gbYears.Controls.Add(this.label1);
            this.gbYears.Location = new System.Drawing.Point(6, 19);
            this.gbYears.Name = "gbYears";
            this.gbYears.Size = new System.Drawing.Size(211, 100);
            this.gbYears.TabIndex = 0;
            this.gbYears.TabStop = false;
            this.gbYears.Text = "Years";
            // 
            // lYearCount
            // 
            this.lYearCount.AutoSize = true;
            this.lYearCount.Location = new System.Drawing.Point(50, 16);
            this.lYearCount.Name = "lYearCount";
            this.lYearCount.Size = new System.Drawing.Size(0, 13);
            this.lYearCount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Count:";
            // 
            // lineChart1
            // 
            this.lineChart1.LineColor = System.Drawing.Color.Black;
            this.lineChart1.Location = new System.Drawing.Point(291, 51);
            this.lineChart1.MaxValue = 10;
            this.lineChart1.Name = "lineChart1";
            this.lineChart1.Size = new System.Drawing.Size(263, 168);
            this.lineChart1.TabIndex = 4;
            this.lineChart1.Text = "lineChart1";
            this.lineChart1.Title = "Avg Grade per Year";
            this.lineChart1.Values = new float[] {
        1F};
            this.lineChart1.XLabel = "Year Id";
            this.lineChart1.XLabels = new string[] {
        null};
            this.lineChart1.YLabel = "Avg Grade";
            // 
            // gbSubjects
            // 
            this.gbSubjects.Controls.Add(this.lSubjectCount);
            this.gbSubjects.Controls.Add(this.label3);
            this.gbSubjects.Location = new System.Drawing.Point(6, 125);
            this.gbSubjects.Name = "gbSubjects";
            this.gbSubjects.Size = new System.Drawing.Size(211, 100);
            this.gbSubjects.TabIndex = 2;
            this.gbSubjects.TabStop = false;
            this.gbSubjects.Text = "Subjects";
            // 
            // lSubjectCount
            // 
            this.lSubjectCount.AutoSize = true;
            this.lSubjectCount.Location = new System.Drawing.Point(50, 16);
            this.lSubjectCount.Name = "lSubjectCount";
            this.lSubjectCount.Size = new System.Drawing.Size(0, 13);
            this.lSubjectCount.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Count:";
            // 
            // gbStudents
            // 
            this.gbStudents.Controls.Add(this.lStudentCount);
            this.gbStudents.Controls.Add(this.label5);
            this.gbStudents.Location = new System.Drawing.Point(6, 229);
            this.gbStudents.Name = "gbStudents";
            this.gbStudents.Size = new System.Drawing.Size(211, 100);
            this.gbStudents.TabIndex = 2;
            this.gbStudents.TabStop = false;
            this.gbStudents.Text = "Students";
            // 
            // lStudentCount
            // 
            this.lStudentCount.AutoSize = true;
            this.lStudentCount.Location = new System.Drawing.Point(50, 16);
            this.lStudentCount.Name = "lStudentCount";
            this.lStudentCount.Size = new System.Drawing.Size(0, 13);
            this.lStudentCount.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Count:";
            // 
            // AdminMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 406);
            this.Controls.Add(this.lineChart1);
            this.Controls.Add(this.gbStats);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.toolStrip);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdminMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Faculty App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.AdminMainForm_FormClosing);
            this.Load += new System.EventHandler(this.AdminMainForm_Load);
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.gbStats.ResumeLayout(false);
            this.gbYears.ResumeLayout(false);
            this.gbYears.PerformLayout();
            this.gbSubjects.ResumeLayout(false);
            this.gbSubjects.PerformLayout();
            this.gbStudents.ResumeLayout(false);
            this.gbStudents.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripButton btnManageYears;
        private System.Windows.Forms.ToolStripButton btnManageStudents;
        private System.Windows.Forms.ToolStripButton btnManageSubjects;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.GroupBox gbStats;
        private ControlsLibrary.LineChart lineChart1;
        private System.Windows.Forms.GroupBox gbYears;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lYearCount;
        private System.Windows.Forms.GroupBox gbStudents;
        private System.Windows.Forms.Label lStudentCount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbSubjects;
        private System.Windows.Forms.Label lSubjectCount;
        private System.Windows.Forms.Label label3;
    }
}