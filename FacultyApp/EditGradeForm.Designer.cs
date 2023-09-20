namespace FacultyApp
{
    partial class EditGradeForm
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
            this.gbGrade = new System.Windows.Forms.GroupBox();
            this.lSubject = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbGrade = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbStudent = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lFirstName = new System.Windows.Forms.Label();
            this.lLastName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbGrade.SuspendLayout();
            this.gbStudent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(315, 100);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 34;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(234, 100);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 33;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // gbGrade
            // 
            this.gbGrade.Controls.Add(this.lSubject);
            this.gbGrade.Controls.Add(this.label5);
            this.gbGrade.Controls.Add(this.tbGrade);
            this.gbGrade.Controls.Add(this.label1);
            this.gbGrade.Location = new System.Drawing.Point(12, 53);
            this.gbGrade.Name = "gbGrade";
            this.gbGrade.Size = new System.Drawing.Size(378, 41);
            this.gbGrade.TabIndex = 75;
            this.gbGrade.TabStop = false;
            this.gbGrade.Text = "Grade";
            // 
            // lSubject
            // 
            this.lSubject.AutoSize = true;
            this.lSubject.Location = new System.Drawing.Point(83, 19);
            this.lSubject.Name = "lSubject";
            this.lSubject.Size = new System.Drawing.Size(0, 13);
            this.lSubject.TabIndex = 47;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 48;
            this.label5.Text = "Subject Name:";
            // 
            // tbGrade
            // 
            this.tbGrade.Location = new System.Drawing.Point(237, 15);
            this.tbGrade.Name = "tbGrade";
            this.tbGrade.Size = new System.Drawing.Size(41, 20);
            this.tbGrade.TabIndex = 46;
            this.tbGrade.Enter += new System.EventHandler(this.control_Enter);
            this.tbGrade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbGrade_KeyPress);
            this.tbGrade.Validating += new System.ComponentModel.CancelEventHandler(this.tbGrade_Validating);
            this.tbGrade.Validated += new System.EventHandler(this.control_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(192, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 44;
            this.label1.Text = "Grade:";
            // 
            // gbStudent
            // 
            this.gbStudent.Controls.Add(this.label2);
            this.gbStudent.Controls.Add(this.lFirstName);
            this.gbStudent.Controls.Add(this.lLastName);
            this.gbStudent.Controls.Add(this.label3);
            this.gbStudent.Location = new System.Drawing.Point(12, 12);
            this.gbStudent.Name = "gbStudent";
            this.gbStudent.Size = new System.Drawing.Size(378, 35);
            this.gbStudent.TabIndex = 76;
            this.gbStudent.TabStop = false;
            this.gbStudent.Text = "Student";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 38;
            this.label2.Text = "LastName:";
            // 
            // lFirstName
            // 
            this.lFirstName.AutoSize = true;
            this.lFirstName.Location = new System.Drawing.Point(234, 16);
            this.lFirstName.Name = "lFirstName";
            this.lFirstName.Size = new System.Drawing.Size(0, 13);
            this.lFirstName.TabIndex = 33;
            // 
            // lLastName
            // 
            this.lLastName.AutoSize = true;
            this.lLastName.Location = new System.Drawing.Point(67, 16);
            this.lLastName.Name = "lLastName";
            this.lLastName.Size = new System.Drawing.Size(0, 13);
            this.lLastName.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "FirstName:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EditGradeForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(402, 134);
            this.Controls.Add(this.gbStudent);
            this.Controls.Add(this.gbGrade);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditGradeForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Grade";
            this.Load += new System.EventHandler(this.EditGradeForm_Load);
            this.gbGrade.ResumeLayout(false);
            this.gbGrade.PerformLayout();
            this.gbStudent.ResumeLayout(false);
            this.gbStudent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox gbGrade;
        private System.Windows.Forms.TextBox tbGrade;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbStudent;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lFirstName;
        private System.Windows.Forms.Label lLastName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lSubject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}