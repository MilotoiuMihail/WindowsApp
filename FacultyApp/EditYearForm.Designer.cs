namespace FacultyApp
{
    partial class EditYearForm
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
            this.btnOk = new System.Windows.Forms.Button();
            this.lDegree = new System.Windows.Forms.Label();
            this.lValue = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.lRequiredCredits = new System.Windows.Forms.Label();
            this.tbRequiredCredits = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lId = new System.Windows.Forms.Label();
            this.gbYear = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.gbYear.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(48, 126);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 14;
            this.btnOk.Text = "&Ok";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lDegree
            // 
            this.lDegree.AutoSize = true;
            this.lDegree.Location = new System.Drawing.Point(96, 37);
            this.lDegree.Name = "lDegree";
            this.lDegree.Size = new System.Drawing.Size(0, 13);
            this.lDegree.TabIndex = 12;
            // 
            // lValue
            // 
            this.lValue.AutoSize = true;
            this.lValue.Location = new System.Drawing.Point(96, 60);
            this.lValue.Name = "lValue";
            this.lValue.Size = new System.Drawing.Size(0, 13);
            this.lValue.TabIndex = 11;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(129, 126);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // lRequiredCredits
            // 
            this.lRequiredCredits.AutoSize = true;
            this.lRequiredCredits.Location = new System.Drawing.Point(8, 85);
            this.lRequiredCredits.Name = "lRequiredCredits";
            this.lRequiredCredits.Size = new System.Drawing.Size(85, 13);
            this.lRequiredCredits.TabIndex = 16;
            this.lRequiredCredits.Text = "Required Credits";
            // 
            // tbRequiredCredits
            // 
            this.tbRequiredCredits.Location = new System.Drawing.Point(99, 82);
            this.tbRequiredCredits.Name = "tbRequiredCredits";
            this.tbRequiredCredits.Size = new System.Drawing.Size(50, 20);
            this.tbRequiredCredits.TabIndex = 17;
            this.tbRequiredCredits.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbRequiredCredits_KeyPress);
            this.tbRequiredCredits.Validating += new System.ComponentModel.CancelEventHandler(this.tbRequiredCredits_Validating);
            this.tbRequiredCredits.Validated += new System.EventHandler(this.tbRequiredCredits_Validated);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Degree:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "Year:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Id:";
            // 
            // lId
            // 
            this.lId.AutoSize = true;
            this.lId.Location = new System.Drawing.Point(96, 16);
            this.lId.Name = "lId";
            this.lId.Size = new System.Drawing.Size(0, 13);
            this.lId.TabIndex = 20;
            // 
            // gbYear
            // 
            this.gbYear.Controls.Add(this.label1);
            this.gbYear.Controls.Add(this.label3);
            this.gbYear.Controls.Add(this.lValue);
            this.gbYear.Controls.Add(this.lId);
            this.gbYear.Controls.Add(this.lDegree);
            this.gbYear.Controls.Add(this.lRequiredCredits);
            this.gbYear.Controls.Add(this.label2);
            this.gbYear.Controls.Add(this.tbRequiredCredits);
            this.gbYear.Location = new System.Drawing.Point(12, 12);
            this.gbYear.Name = "gbYear";
            this.gbYear.Size = new System.Drawing.Size(192, 108);
            this.gbYear.TabIndex = 22;
            this.gbYear.TabStop = false;
            this.gbYear.Text = "Year";
            // 
            // EditYearForm
            // 
            this.AcceptButton = this.btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(219, 159);
            this.Controls.Add(this.gbYear);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOk);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "EditYearForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Year";
            this.Load += new System.EventHandler(this.EditYearForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.gbYear.ResumeLayout(false);
            this.gbYear.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lDegree;
        private System.Windows.Forms.Label lValue;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label lRequiredCredits;
        private System.Windows.Forms.TextBox tbRequiredCredits;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lId;
        private System.Windows.Forms.GroupBox gbYear;
    }
}