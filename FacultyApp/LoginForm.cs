using FacultyApp.CustomExceptions;
using FacultyApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultyApp
{
    public partial class LoginForm : Form
    {
        LoginFormViewModel viewModel;
        public LoginForm()
        {
            viewModel = new LoginFormViewModel();
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            DataBind();
        }

        private void DataBind()
        {
            tbUser.DataBindings.Add("Text", viewModel, nameof(viewModel.Username), true, DataSourceUpdateMode.OnPropertyChanged);
            tbPassword.DataBindings.Add("Text", viewModel, nameof(viewModel.Password), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }
            if (viewModel.IsAdmin())
            {
                AdminMainForm adminForm = new AdminMainForm();
                this.Hide();
                adminForm.Show(this);
            }
            else
            {
                StudentMainForm studentForm = new StudentMainForm(viewModel.GetStudent());
                tbPassword.ResetText();
                this.Hide();
                studentForm.Show(this);
            }
        }
        private void control_Enter(object sender, EventArgs e)
        {
            control_Validated((Control)sender, e);
        }
        private void control_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private void tbUser_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                viewModel.ValidateUser();
            }
            catch (LoginException ex)
            {
                e.Cancel = true;
                errorProvider.SetError(tbUser, ex.Message);
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                viewModel.ValidatePassword();
            }
            catch (LoginException ex)
            {
                e.Cancel = true;
                errorProvider.SetError(tbPassword, ex.Message);
            }
        }

    }
}
