namespace FacultyApp
{
    partial class EditSubjectForm
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
            this.gbSubject = new System.Windows.Forms.GroupBox();
            this.tbCredits = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbName = new System.Windows.Forms.TextBox();
            this.lEmail = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.gbYear = new System.Windows.Forms.GroupBox();
            this.cbValue = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cbYearId = new System.Windows.Forms.ComboBox();
            this.lYearId = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbDegree = new System.Windows.Forms.ComboBox();
            this.lYear = new System.Windows.Forms.Label();
            this.lDegree = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbSubject.SuspendLayout();
            this.gbYear.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(308, 181);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 13;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(227, 181);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // gbSubject
            // 
            this.gbSubject.Controls.Add(this.tbCredits);
            this.gbSubject.Controls.Add(this.label1);
            this.gbSubject.Controls.Add(this.tbName);
            this.gbSubject.Controls.Add(this.lEmail);
            this.gbSubject.Controls.Add(this.label2);
            this.gbSubject.Controls.Add(this.label3);
            this.gbSubject.Controls.Add(this.lId);
            this.gbSubject.Location = new System.Drawing.Point(12, 12);
            this.gbSubject.Name = "gbSubject";
            this.gbSubject.Size = new System.Drawing.Size(371, 112);
            this.gbSubject.TabIndex = 71;
            this.gbSubject.TabStop = false;
            this.gbSubject.Text = "Subject";
            // 
            // tbCredits
            // 
            this.tbCredits.Location = new System.Drawing.Point(70, 63);
            this.tbCredits.Name = "tbCredits";
            this.tbCredits.Size = new System.Drawing.Size(43, 20);
            this.tbCredits.TabIndex = 73;
            this.tbCredits.Enter += new System.EventHandler(this.control_Enter);
            this.tbCredits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.integer_KeyPress);
            this.tbCredits.Validating += new System.ComponentModel.CancelEventHandler(this.tbCredits_Validating);
            this.tbCredits.Validated += new System.EventHandler(this.control_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 38;
            this.label1.Text = "Name:";
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(70, 40);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(116, 20);
            this.tbName.TabIndex = 72;
            this.tbName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.letter_KeyPress);
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            this.tbName.Validated += new System.EventHandler(this.control_Validated);
            // 
            // lEmail
            // 
            this.lEmail.AutoSize = true;
            this.lEmail.Location = new System.Drawing.Point(70, 89);
            this.lEmail.Name = "lEmail";
            this.lEmail.Size = new System.Drawing.Size(0, 13);
            this.lEmail.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 37;
            this.label2.Text = "Credits:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Id:";
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(67, 23);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(0, 13);
            this.lId.TabIndex = 39;
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
            this.gbYear.Location = new System.Drawing.Point(12, 123);
            this.gbYear.Name = "gbYear";
            this.gbYear.Size = new System.Drawing.Size(371, 52);
            this.gbYear.TabIndex = 70;
            this.gbYear.TabStop = false;
            this.gbYear.Text = "Year";
            this.gbYear.Enter += new System.EventHandler(this.control_Enter);
            this.gbYear.Validating += new System.ComponentModel.CancelEventHandler(this.gbYear_Validating);
            this.gbYear.Validated += new System.EventHandler(this.control_Validated);
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
            // lYearId
            // 
            this.lYearId.AutoSize = true;
            this.lYearId.Location = new System.Drawing.Point(9, 23);
            this.lYearId.Name = "lYearId";
            this.lYearId.Size = new System.Drawing.Size(44, 13);
            this.lYearId.TabIndex = 64;
            this.lYearId.Text = "Year Id:";
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
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // EditSubjectForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(396, 216);
            this.Controls.Add(this.gbSubject);
            this.Controls.Add(this.gbYear);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditSubjectForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Subject";
            this.Load += new System.EventHandler(this.EditSubjectForm_Load);
            this.gbSubject.ResumeLayout(false);
            this.gbSubject.PerformLayout();
            this.gbYear.ResumeLayout(false);
            this.gbYear.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.GroupBox gbSubject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.GroupBox gbYear;
        private System.Windows.Forms.ComboBox cbValue;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbYearId;
        private System.Windows.Forms.Label lYearId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbDegree;
        private System.Windows.Forms.Label lYear;
        private System.Windows.Forms.Label lDegree;
        private System.Windows.Forms.TextBox tbCredits;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}