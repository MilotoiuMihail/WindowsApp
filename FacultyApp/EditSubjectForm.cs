using FacultyApp.CustomExceptions;
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
    public partial class EditSubjectForm : Form
    {
        EditSubjectFormViewModel viewModel;
        public EditSubjectForm(SubjectDto subject)
        {
            InitializeComponent();
            viewModel = new EditSubjectFormViewModel(subject);
        }

        private void EditSubjectForm_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            DataBind();
        }
        private void DataBind()
        {
            cbYearId.DataSource = viewModel.Years.Select(x => x.Id).OrderBy(x => x).ToList();
            cbYearId.DataBindings.Add("Text", viewModel, nameof(viewModel.YearId), true, DataSourceUpdateMode.OnPropertyChanged);
            cbDegree.DataSource = viewModel.Years.Select(x => x.Degree).Distinct().OrderBy(x => x, new DegreeComparer()).ToList();
            cbDegree.DataBindings.Add("Text", viewModel, nameof(viewModel.Degree), true, DataSourceUpdateMode.OnPropertyChanged);
            cbValue.DataSource = viewModel.Years.Select(x => x.Value).Distinct().OrderBy(x => x).ToList();
            cbValue.DataBindings.Add("Text", viewModel, nameof(viewModel.Value), true, DataSourceUpdateMode.OnPropertyChanged);
            lId.DataBindings.Add("Text", viewModel.Subject, nameof(viewModel.Subject.Id), true, DataSourceUpdateMode.OnPropertyChanged);
            tbName.DataBindings.Add("Text", viewModel, nameof(viewModel.Name), true, DataSourceUpdateMode.OnPropertyChanged);
            tbCredits.DataBindings.Add("Text", viewModel, nameof(viewModel.Credits), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Visible))
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
        private void control_Enter(object sender, EventArgs e)
        {
            control_Validated((Control)sender, e);
        }
        private void integer_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void letter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != (char)Keys.Space)
            {
                e.Handled = true;
            }
        }
        private void cbYearId_Enter(object sender, EventArgs e)
        {
            cbDegree.Text = string.Empty;
            cbValue.Text = string.Empty;
        }
        private void cbDegree_Enter(object sender, EventArgs e)
        {
            cbYearId.Text = string.Empty;
        }

        private void cbValue_Enter(object sender, EventArgs e)
        {
            cbYearId.Text = string.Empty;
        }

        private void control_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }
        private void gbYear_Validating(object sender, CancelEventArgs e)
        {
            if (!viewModel.Years.Any(x => x.Id.ToString() == cbYearId.Text || x.Degree == cbDegree.Text && x.Value.ToString() == cbValue.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(gbYear, "Year does not exist");
            }
        }
        private void tbCredits_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Subject.ValidateCredits(tbCredits.Text);
            }
            catch (FormatException ex)
            {
                e.Cancel = true;
                errorProvider.SetError(tbCredits, "Invalid credits");
            }
        }
        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Subject.ValidateName(tbName.Text);
            }
            catch (NameException ex)
            {
                e.Cancel = true;
                errorProvider.SetError(tbName, ex.Message);
            }
        }
        private void cbYearId_KeyUp(object sender, KeyEventArgs e)
        {
            Year year = viewModel.Years.Where(x => x.Id.ToString() == cbYearId.Text).FirstOrDefault();
            if (year != null)
            {
                cbDegree.Text = year.Degree;
                cbValue.Text = year.Value.ToString();
            }
            else
            {
                cbDegree.Text = string.Empty;
                cbValue.Text = string.Empty;
            }
        }
        private void cbYearId_SelectedValueChanged(object sender, EventArgs e)
        {
            Year year = viewModel.Years.Where(x => x.Id.ToString() == cbYearId.Text).FirstOrDefault();
            if (year != null)
            {
                cbDegree.Text = year.Degree;
                cbValue.Text = year.Value.ToString();
            }
            else
            {
                cbDegree.Text = string.Empty;
                cbValue.Text = string.Empty;
            }
        }

        private void cbDegreeValue_KeyUp(object sender, KeyEventArgs e)
        {
            Year year = viewModel.Years.Where(x => x.Degree.ToLower() == cbDegree.Text.ToLower() && x.Value.ToString() == cbValue.Text).FirstOrDefault();
            if (year != null)
            {
                cbYearId.Text = year.Id.ToString();
            }
            else
            {
                cbYearId.Text = string.Empty;
            }
        }

        private void cbDegreeValue_SelectedValueChanged(object sender, EventArgs e)
        {
            Year year = viewModel.Years.Where(x => x.Degree.ToLower() == cbDegree.Text.ToLower() && x.Value.ToString() == cbValue.Text).FirstOrDefault();
            if (year != null)
            {
                cbYearId.Text = year.Id.ToString();
            }
            else
            {
                cbYearId.Text = string.Empty;
            }
        }
        #endregion
    }
}
