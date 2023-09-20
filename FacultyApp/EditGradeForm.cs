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
    public partial class EditGradeForm : Form
    {
        EditGradeFormViewModel viewModel;
        public EditGradeForm(GradeDto grade, Student student)
        {
            InitializeComponent();
            viewModel = new EditGradeFormViewModel(grade, student);
        }
        private void EditGradeForm_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            DataBind();
        }
        private void DataBind()
        {
            lLastName.Text = viewModel.Student.LastName;
            lFirstName.Text = viewModel.Student.FirstName;
            lSubject.Text = viewModel.Grade.SubjectName;
            tbGrade.DataBindings.Add("Text", viewModel, nameof(viewModel.Value));
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
        private void tbGrade_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Grade.ValidateValue(tbGrade.Text);
            }
            catch (FormatException ex)
            {
                e.Cancel = true;
                errorProvider.SetError(tbGrade, "Invalid Grade");
            }
        }

        private void control_Enter(object sender, EventArgs e)
        {
            control_Validated((Control)sender, e);
        }
        private void tbGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void control_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }
        #endregion

    }
}
