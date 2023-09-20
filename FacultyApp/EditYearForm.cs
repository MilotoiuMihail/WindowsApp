using FacultyApp.Entities;
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
    public partial class EditYearForm : Form
    {
        EditYearFormViewModel viewModel;
        public EditYearForm(Year year)
        {
            InitializeComponent();
            viewModel = new EditYearFormViewModel(year);
        }

        private void EditYearForm_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            DataBind();
        }
        private void DataBind()
        {
            lDegree.DataBindings.Add("Text", viewModel.Year, nameof(viewModel.Year.Degree));
            lValue.DataBindings.Add("Text", viewModel.Year, nameof(viewModel.Year.Value));
            lId.DataBindings.Add("Text", viewModel.Year, nameof(viewModel.Year.Id));
            tbRequiredCredits.DataBindings.Add("Text", viewModel, nameof(viewModel.RequiredCredits));
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("The form contains errors!",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            this.DialogResult = DialogResult.OK;
            viewModel.UpdateValues();
        }

        #region Validations
        private void tbRequiredCredits_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbRequiredCredits_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }
        private void tbRequiredCredits_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Year.ValidateRequiredCredits(tbRequiredCredits.Text);
            }
            catch (FormatException ex)
            {
                e.Cancel = true;
                errorProvider.SetError(tbRequiredCredits, "Invalid Credits");
            }
        }
        #endregion

    }
}
