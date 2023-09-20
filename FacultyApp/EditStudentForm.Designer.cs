namespace FacultyApp
{
    partial class EditStudentForm
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
            this.components = new System.ComponentModel.Container();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lLastName = new System.Windows.Forms.Label();
            this.lFirstName = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lEmail = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbValue = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lYear = new System.Windows.Forms.Label();
            this.lDegree = new System.Windows.Forms.Label();
            this.cbDegree = new System.Windows.Forms.ComboBox();
            this.lYearId = new System.Windows.Forms.Label();
            this.cbYearId = new System.Windows.Forms.ComboBox();
            this.gbYear = new System.Windows.Forms.GroupBox();
            this.gbStudent = new System.Windows.Forms.GroupBox();
            this.btnManageGrades = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.gbYear.SuspendLayout();
            this.gbStudent.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(308, 161);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 32;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(227, 161);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 25;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProvider.ContainerControl = this;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(207, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Id:";
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(229, 16);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(0, 13);
            this.lId.TabIndex = 39;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "LastName:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "FirstName:";
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Location = new System.Drawing.Point(67, 16);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(0, 13);
            this.lLastName.TabIndex = 34;
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Location = new System.Drawing.Point(67, 39);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(0, 13);
            this.lFirstName.TabIndex = 33;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(191, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Email:";
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(229, 39);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(0, 13);
            this.lEmail.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(261, 21);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 17);
            this.label5.TabIndex = 67;
            this.label5.Text = "&";
            this.label5.UseMnemonic = false;
            // 
            // cbValue
            // 
            this.cbValue.FormattingEnabled = true;
            this.cbValue.Location = new System.Drawing.Point(312, 19);
            this.cbValue.Name = "cbValue";
            this.cbValue.Size = new System.Drawing.Size(40, 21);
            this.cbValue.TabIndex = 63;
            this.cbValue.SelectedValueChanged += new System.EventHandler(this.cbDegreeValue_SelectedValueChanged);
            this.cbValue.Enter += new System.EventHandler(this.cbValue_Enter);
            this.cbValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integer_KeyPress);
            this.cbValue.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbDegreeValue_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(105, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 13);
            this.label6.TabIndex = 66;
            this.label6.Text = "OR";
            // 
            // lYear
            // 
            this.lYear.AutoSize = true;
            this.lYear.Location = new System.Drawing.Point(277, 23);
            this.lYear.Name = "lYear";
            this.lYear.Size = new System.Drawing.Size(32, 13);
            this.lYear.TabIndex = 60;
            this.lYear.Text = "Year:";
            // 
            // lDegree
            // 
            this.lDegree.AutoSize = true;
            this.lDegree.Location = new System.Drawing.Point(130, 23);
            this.lDegree.Name = "lDegree";
            this.lDegree.Size = new System.Drawing.Size(45, 13);
            this.lDegree.TabIndex = 61;
            this.lDegree.Text = "Degree:";
            // 
            // cbDegree
            // 
            this.cbDegree.FormattingEnabled = true;
            this.cbDegree.Location = new System.Drawing.Point(181, 19);
            this.cbDegree.Name = "cbDegree";
            this.cbDegree.Size = new System.Drawing.Size(74, 21);
            this.cbDegree.TabIndex = 62;
            this.cbDegree.SelectedValueChanged += new System.EventHandler(this.cbDegreeValue_SelectedValueChanged);
            this.cbDegree.Enter += new System.EventHandler(this.cbDegree_Enter);
            this.cbDegree.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letter_KeyPress);
            this.cbDegree.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbDegreeValue_KeyUp);
            // 
            // lYearId
            // 
            this.lYearId.AutoSize = true;
            this.lYearId.Location = new System.Drawing.Point(9, 23);
            this.lYearId.Name = "lYearId";
            this.lYearId.Size = new System.Drawing.Size(44, 13);
            this.lYearId.TabIndex = 64;
            this.lYearId.Text = "Year Id:";
            // 
            // cbYearId
            // 
            this.cbYearId.FormattingEnabled = true;
            this.cbYearId.Location = new System.Drawing.Point(59, 19);
            this.cbYearId.Name = "cbYearId";
            this.cbYearId.Size = new System.Drawing.Size(40, 21);
            this.cbYearId.TabIndex = 65;
            this.cbYearId.SelectedValueChanged += new System.EventHandler(this.cbYearId_SelectedValueChanged);
            this.cbYearId.Enter += new System.EventHandler(this.cbYearId_Enter);
            this.cbYearId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integer_KeyPress);
            this.cbYearId.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbYearId_KeyUp);
            // 
            // gbYear
            // 
            this.gbYear.Controls.Add(this.cbValue);
            this.gbYear.Controls.Add(this.label5);
            this.gbYear.Controls.Add(this.cbYearId);
            this.gbYear.Controls.Add(this.lYearId);
            this.gbYear.Controls.Add(this.label6);
            this.gbYear.Controls.Add(this.cbDegree);
            this.gbYear.Controls.Add(this.lYear);
            this.gbYear.Controls.Add(this.lDegree);
            this.gbYear.Location = new System.Drawing.Point(13, 103);
            this.gbYear.Name = "gbYear";
            this.gbYear.Size = new System.Drawing.Size(371, 52);
            this.gbYear.TabIndex = 68;
            this.gbYear.TabStop = false;
            this.gbYear.Text = "Year";
            this.gbYear.Enter += new System.EventHandler(this.control_Enter);
            this.gbYear.Validating += new System.ComponentModel.CancelEventHandler(this.gbYear_Validating);
            this.gbYear.Validated += new System.EventHandler(this.control_Validated);
            // 
            // gbStudent
            // 
            this.gbStudent.Controls.Add(this.btnManageGrades);
            this.gbStudent.Controls.Add(this.label1);
            this.gbStudent.Controls.Add(this.lFirstName);
            this.gbStudent.Controls.Add(this.label4);
            this.gbStudent.Controls.Add(this.lLastName);
            this.gbStudent.Controls.Add(this.lEmail);
            this.gbStudent.Controls.Add(this.label2);
            this.gbStudent.Controls.Add(this.label3);
            this.gbStudent.Controls.Add(this.lId);
            this.gbStudent.Location = new System.Drawing.Point(12, 12);
            this.gbStudent.Name = "gbStudent";
            this.gbStudent.Size = new System.Drawing.Size(371, 92);
            this.gbStudent.TabIndex = 69;
            this.gbStudent.TabStop = false;
            this.gbStudent.Text = "Student";
            // 
            // btnManageGrades
            // 
            this.btnManageGrades.Location = new System.Drawing.Point(269, 62);
            this.btnManageGrades.Name = "btnManageGrades";
            this.btnManageGrades.Size = new System.Drawing.Size(96, 23);
            this.btnManageGrades.TabIndex = 47;
            this.btnManageGrades.Text = "Manage &Grades";
            this.btnManageGrades.UseVisualStyleBackColor = true;
            this.btnManageGrades.Click += new System.EventHandler(this.btnManageGrades_Click);
            // 
            // EditStudentForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(396, 191);
            this.Controls.Add(this.gbStudent);
            this.Controls.Add(this.gbYear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditStudentForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Student";
            this.Load += new System.EventHandler(this.EditStudentForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.gbYear.ResumeLayout(false);
            this.gbYear.PerformLayout();
            this.gbStudent.ResumeLayout(false);
            this.gbStudent.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbValue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lYear;
        private System.Windows.Forms.Label lDegree;
        private System.Windows.Forms.ComboBox cbDegree;
        private System.Windows.Forms.Label lYearId;
        private System.Windows.Forms.ComboBox cbYearId;
        private System.Windows.Forms.GroupBox gbStudent;
        private System.Windows.Forms.GroupBox gbYear;
        private System.Windows.Forms.Button btnManageGrades;
    }
}