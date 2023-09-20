namespace FacultyApp
{
    partial class StudentMainForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbGrade = new System.Windows.Forms.GroupBox();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.lGrade = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gbResults = new System.Windows.Forms.GroupBox();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.gbStudent = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lValue = new System.Windows.Forms.Label();
            this.lDegree = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lFirstName = new System.Windows.Forms.Label();
            this.lLastName = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lStudentId = new System.Windows.Forms.Label();
            this.gbSubject = new System.Windows.Forms.GroupBox();
            this.cbId = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.lSubject = new System.Windows.Forms.Label();
            this.cbSubject = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.lStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.gbGrade.SuspendLayout();
            this.gbResults.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.gbStudent.SuspendLayout();
            this.gbSubject.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbGrade
            // 
            this.gbGrade.Controls.Add(this.tbGrade);
            this.gbGrade.Controls.Add(this.lGrade);
            this.gbGrade.Location = new System.Drawing.Point(329, 117);
            this.gbGrade.Name = "gbGrade";
            this.gbGrade.Size = new System.Drawing.Size(97, 53);
            this.gbGrade.TabIndex = 78;
            this.gbGrade.TabStop = false;
            this.gbGrade.Text = "Grade";
            // 
            // tbGrade
            // 
            this.tbGrade.Location = new System.Drawing.Point(47, 19);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(41, 20);
            this.tbGrade.TabIndex = 46;
            // 
            // lGrade
            // 
            this.lGrade.AutoSize = true;
            this.lGrade.Location = new System.Drawing.Point(7, 23);
            this.lGrade.Name = "lGrade";
            this.lGrade.Size = new System.Drawing.Size(39, 13);
            this.lGrade.TabIndex = 44;
            this.lGrade.Text = "Grade:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(447, 136);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 74;
            this.btnSearch.Text = "&Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gbResults
            // 
            this.gbResults.Controls.Add(this.dgvGrades);
            this.gbResults.Location = new System.Drawing.Point(12, 176);
            this.gbResults.Name = "gbResults";
            this.gbResults.Size = new System.Drawing.Size(536, 182);
            this.gbResults.TabIndex = 77;
            this.gbResults.TabStop = false;
            this.gbResults.Text = "Results";
            // 
            // dgvGrades
            // 
            this.dgvGrades.AllowDrop = true;
            this.dgvGrades.AllowUserToAddRows = false;
            this.dgvGrades.AllowUserToDeleteRows = false;
            this.dgvGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrades.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Location = new System.Drawing.Point(6, 19);
            this.dgvGrades.MultiSelect = false;
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvGrades.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvGrades.RowHeadersVisible = false;
            this.dgvGrades.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvGrades.Size = new System.Drawing.Size(522, 150);
            this.dgvGrades.TabIndex = 55;
            this.dgvGrades.ColumnHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGrades_ColumnHeaderMouseDoubleClick);
            // 
            // gbStudent
            // 
            this.gbStudent.Controls.Add(this.btnChangePassword);
            this.gbStudent.Controls.Add(this.label7);
            this.gbStudent.Controls.Add(this.lEmail);
            this.gbStudent.Controls.Add(this.label4);
            this.gbStudent.Controls.Add(this.lValue);
            this.gbStudent.Controls.Add(this.lDegree);
            this.gbStudent.Controls.Add(this.label5);
            this.gbStudent.Controls.Add(this.label1);
            this.gbStudent.Controls.Add(this.lFirstName);
            this.gbStudent.Controls.Add(this.lLastName);
            this.gbStudent.Controls.Add(this.label2);
            this.gbStudent.Controls.Add(this.label3);
            this.gbStudent.Controls.Add(this.lStudentId);
            this.gbStudent.Location = new System.Drawing.Point(12, 12);
            this.gbStudent.Name = "gbStudent";
            this.gbStudent.Size = new System.Drawing.Size(536, 99);
            this.gbStudent.TabIndex = 75;
            this.gbStudent.TabStop = false;
            this.gbStudent.Text = "Student";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(221, 47);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 44;
            this.label4.Text = "Degree:";
            // 
            // lValue
            // 
            this.lValue.AutoSize = true;
            this.lValue.Location = new System.Drawing.Point(269, 65);
            this.lValue.Name = "lValue";
            this.lValue.Size = new System.Drawing.Size(0, 13);
            this.lValue.TabIndex = 41;
            // 
            // lDegree
            // 
            this.lDegree.AutoSize = true;
            this.lDegree.Location = new System.Drawing.Point(269, 47);
            this.lDegree.Name = "lDegree";
            this.lDegree.Size = new System.Drawing.Size(0, 13);
            this.lDegree.TabIndex = 42;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(234, 65);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 43;
            this.label5.Text = "Year:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "LastName:";
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Location = new System.Drawing.Point(66, 66);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(0, 13);
            this.lFirstName.TabIndex = 33;
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Location = new System.Drawing.Point(66, 45);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(0, 13);
            this.lLastName.TabIndex = 34;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "FirstName:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Id:";
            // 
            // lStudentId
            // 
            this.lStudentId.AutoSize = true;
            this.lStudentId.Location = new System.Drawing.Point(66, 29);
            this.lStudentId.Name = "lStudentId";
            this.lStudentId.Size = new System.Drawing.Size(0, 13);
            this.lStudentId.TabIndex = 39;
            // 
            // gbSubject
            // 
            this.gbSubject.Controls.Add(this.cbId);
            this.gbSubject.Controls.Add(this.label6);
            this.gbSubject.Controls.Add(this.lId);
            this.gbSubject.Controls.Add(this.lSubject);
            this.gbSubject.Controls.Add(this.cbSubject);
            this.gbSubject.Location = new System.Drawing.Point(12, 117);
            this.gbSubject.Name = "gbSubject";
            this.gbSubject.Size = new System.Drawing.Size(311, 53);
            this.gbSubject.TabIndex = 76;
            this.gbSubject.TabStop = false;
            this.gbSubject.Text = "Subject";
            // 
            // cbId
            // 
            this.cbId.FormattingEnabled = true;
            this.cbId.Location = new System.Drawing.Point(32, 20);
            this.cbId.Name = "cbId";
            this.cbId.Size = new System.Drawing.Size(40, 21);
            this.cbId.TabIndex = 75;
            this.cbId.SelectedValueChanged += new System.EventHandler(this.cbId_SelectedValueChanged);
            this.cbId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbId_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(83, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 74;
            this.label6.Text = "OR";
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(7, 24);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(19, 13);
            this.lId.TabIndex = 49;
            this.lId.Text = "Id:";
            // 
            // lSubject
            // 
            this.lSubject.AutoSize = true;
            this.lSubject.Location = new System.Drawing.Point(112, 24);
            this.lSubject.Name = "lSubject";
            this.lSubject.Size = new System.Drawing.Size(38, 13);
            this.lSubject.TabIndex = 42;
            this.lSubject.Text = "Name:";
            // 
            // cbSubject
            // 
            this.cbSubject.FormattingEnabled = true;
            this.cbSubject.Location = new System.Drawing.Point(156, 20);
            this.cbSubject.Name = "cbSubject";
            this.cbSubject.Size = new System.Drawing.Size(149, 21);
            this.cbSubject.TabIndex = 43;
            this.cbSubject.SelectedValueChanged += new System.EventHandler(this.cbSubject_SelectedValueChanged);
            this.cbSubject.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbSubject_KeyUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(231, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 46;
            this.label7.Text = "Email:";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(269, 29);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(0, 13);
            this.lEmail.TabIndex = 45;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(384, 61);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(126, 23);
            this.btnChangePassword.TabIndex = 47;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lStatus});
            this.statusStrip.Location = new System.Drawing.Point(0, 392);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(569, 22);
            this.statusStrip.TabIndex = 79;
            this.statusStrip.Text = "statusStrip1";
            this.statusStrip.TextChanged += new System.EventHandler(this.statusStrip_TextChanged);
            // 
            // lStatus
            // 
            this.lStatus.Name = "lStatus";
            this.lStatus.Size = new System.Drawing.Size(0, 17);
            // 
            // btnLogout
            // 
            this.btnLogout.Location = new System.Drawing.Point(447, 364);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(75, 23);
            this.btnLogout.TabIndex = 80;
            this.btnLogout.Text = "Log out";
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // StudentMainForm
            // 
            this.AcceptButton = this.btnSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(569, 414);
            this.Controls.Add(this.btnLogout);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.gbGrade);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbResults);
            this.Controls.Add(this.gbStudent);
            this.Controls.Add(this.gbSubject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StudentMainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Faculty App";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.StudentMainForm_FormClosing);
            this.Load += new System.EventHandler(this.StudentMainForm_Load);
            this.gbGrade.ResumeLayout(false);
            this.gbGrade.PerformLayout();
            this.gbResults.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.gbStudent.ResumeLayout(false);
            this.gbStudent.PerformLayout();
            this.gbSubject.ResumeLayout(false);
            this.gbSubject.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbGrade;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.Label lGrade;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox gbResults;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.GroupBox gbStudent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lValue;
        private System.Windows.Forms.Label lDegree;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lStudentId;
        private System.Windows.Forms.GroupBox gbSubject;
        private System.Windows.Forms.ComboBox cbId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Label lSubject;
        private System.Windows.Forms.ComboBox cbSubject;
        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel lStatus;
        private System.Windows.Forms.Button btnLogout;
    }
}