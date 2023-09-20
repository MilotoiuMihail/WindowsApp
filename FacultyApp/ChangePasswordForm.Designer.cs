namespace FacultyApp
{
    partial class ChangePasswordForm
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
            this.btnChangePassword = new System.Windows.Forms.Button();
            this.tbNew = new System.Windows.Forms.TextBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.tbCurrent = new System.Windows.Forms.TextBox();
            this.lUser = new System.Windows.Forms.Label();
            this.tbConfirm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Location = new System.Drawing.Point(194, 123);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(126, 23);
            this.btnChangePassword.TabIndex = 48;
            this.btnChangePassword.Text = "Change Password";
            this.btnChangePassword.UseVisualStyleBackColor = true;
            // 
            // tbNew
            // 
            this.tbNew.Location = new System.Drawing.Point(137, 56);
            this.tbNew.Name = "tbNew";
            this.tbNew.Size = new System.Drawing.Size(183, 20);
            this.tbNew.TabIndex = 52;
            this.tbNew.UseSystemPasswordChar = true;
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(50, 59);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(81, 13);
            this.lPassword.TabIndex = 51;
            this.lPassword.Text = "New Password:";
            // 
            // tbCurrent
            // 
            this.tbCurrent.Location = new System.Drawing.Point(137, 30);
            this.tbCurrent.Name = "tbCurrent";
            this.tbCurrent.Size = new System.Drawing.Size(183, 20);
            this.tbCurrent.TabIndex = 50;
            // 
            // lUser
            // 
            this.lUser.AutoSize = true;
            this.lUser.Location = new System.Drawing.Point(38, 33);
            this.lUser.Name = "lUser";
            this.lUser.Size = new System.Drawing.Size(93, 13);
            this.lUser.TabIndex = 49;
            this.lUser.Text = "Current Password:";
            // 
            // tbConfirm
            // 
            this.tbConfirm.Location = new System.Drawing.Point(137, 82);
            this.tbConfirm.Name = "tbConfirm";
            this.tbConfirm.Size = new System.Drawing.Size(183, 20);
            this.tbConfirm.TabIndex = 54;
            this.tbConfirm.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Confirm New Password:";
            // 
            // ChangePasswordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 160);
            this.Controls.Add(this.tbConfirm);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNew);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.tbCurrent);
            this.Controls.Add(this.lUser);
            this.Controls.Add(this.btnChangePassword);
            this.Name = "ChangePasswordForm";
            this.Text = "Change Password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnChangePassword;
        private System.Windows.Forms.TextBox tbNew;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox tbCurrent;
        private System.Windows.Forms.Label lUser;
        private System.Windows.Forms.TextBox tbConfirm;
        private System.Windows.Forms.Label label1;
    }
}