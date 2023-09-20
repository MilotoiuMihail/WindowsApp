using FacultyApp.CustomExceptions;
using FacultyApp.Entities;
using FacultyApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultyApp
{
    public partial class ManageSubjectsForm : Form
    {
        ManageSubjectsFormViewModel viewModel;
        private bool closedX = true;
        public ManageSubjectsForm()
        {
            InitializeComponent();
            viewModel = new ManageSubjectsFormViewModel();
        }

        private void ManageSubjectsForm_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            this.CenterToParent();
            viewModel.SortSubjects(0);
            DataBind();
            dgvSubjects.ClearSelection();
        }
        private void ManageSubjectsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            if (closedX)
                Application.Exit();
        }

        private void DataBind()
        {
            dgvSubjects.DataSource = viewModel.Subjects;
            cbYearId.DataSource = viewModel.Years.Select(x => x.Id).OrderBy(x => x).ToList();
            cbYearId.DataBindings.Add("Text", viewModel, nameof(viewModel.YearId), true, DataSourceUpdateMode.OnPropertyChanged);
            cbDegree.DataSource = viewModel.Years.Select(x => x.Degree).Distinct().OrderBy(x => x, new DegreeComparer()).ToList();
            cbDegree.DataBindings.Add("Text", viewModel, nameof(viewModel.Degree), true, DataSourceUpdateMode.OnPropertyChanged);
            cbValue.DataSource = viewModel.Years.Select(x => x.Value).Distinct().OrderBy(x => x).ToList();
            cbValue.DataBindings.Add("Text", viewModel, nameof(viewModel.Value), true, DataSourceUpdateMode.OnPropertyChanged);
            tbId.DataBindings.Add("Text", viewModel, nameof(viewModel.Id), true, DataSourceUpdateMode.OnPropertyChanged);
            tbName.DataBindings.Add("Text", viewModel, nameof(viewModel.Name), true, DataSourceUpdateMode.OnPropertyChanged);
            tbCredits.DataBindings.Add("Text", viewModel, nameof(viewModel.Credits), true, DataSourceUpdateMode.OnPropertyChanged);
            statusStrip.DataBindings.Add("Text", viewModel, nameof(viewModel.StatusMessage), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        #region Adding
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Visible))
            {
                MessageBox.Show("The form contains errors", "Add Subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                viewModel.AddSubject();

            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Subject already exists.", "Add Subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            tbId.Select();
            dgvSubjects.ClearSelection();
        }
        private void btnAddBulk_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV File | *.csv; *.txt";
            openFileDialog.Title = "Import File";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    viewModel.AddBulkFromFile(openFileDialog.FileName);
                    viewModel.AddBulkMessage();
                }
                catch (WrongFormatException ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        #endregion

        #region Editing
        private void EditSelectedRow()
        {
            SubjectDto subject = (SubjectDto)dgvSubjects.SelectedRows[0].DataBoundItem;

            EditSubjectForm editForm = new EditSubjectForm(subject);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    viewModel.EditSubject(subject);
                }
                catch (SQLiteException ex)
                {
                    MessageBox.Show("Subject already exists.", "Add Subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    viewModel.LoadSubjectsFromDatabase();
                }
                dgvSubjects.Refresh();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvSubjects.SelectedRows.Count == 0)
            {
                MessageBox.Show("Choose a subject!", "Edit subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EditSelectedRow();
        }

        private void ctxBtnEditRow_Click(object sender, EventArgs e)
        {
            EditSelectedRow();
        }

        private void dgvSubjects_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvSubjects.SelectedRows.Count > 0 && e.RowIndex == dgvSubjects.SelectedRows[0].Index)
            {
                EditSelectedRow();
            }
        }
        #endregion

        #region Deleting
        private void DeleteSelectedRow()
        {
            if (MessageBox.Show("Delete selected subject?", "Delete subject", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SubjectDto subject = (SubjectDto)dgvSubjects.SelectedRows[0].DataBoundItem;
                viewModel.DeleteSubject(subject);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvSubjects.SelectedRows.Count == 0)
            {
                MessageBox.Show("Choose a subject!", "Delete subject", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DeleteSelectedRow();
        }

        private void ctxBtnDeleteRow_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow();
        }
        #endregion

        #region Misc
        private void btnSearch_Click(object sender, EventArgs e)
        {
            viewModel.SearchSubject();
            dgvSubjects.ClearSelection();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV | *.csv | Text | *.txt";
            saveFileDialog.Title = "Export File";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    writer.WriteLine(SubjectDto.CSV_HEADER);
                    foreach (var subject in viewModel.Subjects)
                    {
                        writer.WriteLine(subject.ToString());
                    }
                }
            }
        }

        private void dgvSubjects_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvSubjects.SelectedRows.Count == 0)
                return;
            switch (e.KeyCode)
            {
                case Keys.Delete:
                    DeleteSelectedRow();
                    break;
                case Keys.Enter:
                    EditSelectedRow();
                    break;
                default:
                    break;
            }
        }

        private void dgvSubjects_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgvSubjects.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0 && hti.RowIndex < dgvSubjects.Rows.Count)
                {
                    dgvSubjects.ClearSelection();
                    dgvSubjects.Rows[hti.RowIndex].Selected = true;
                }
            }
        }

        private void dgvSubjects_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            viewModel.SortSubjects(e.ColumnIndex);
            dgvSubjects.DataSource = viewModel.Subjects;
        }
        #endregion

        #region Validations
        private void control_Enter(object sender, EventArgs e)
        {
            control_Validated((Control)sender, e);
        }
        private void control_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
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

        private void cbDegree_Enter(object sender, EventArgs e)
        {
            cbYearId.Text = string.Empty;
        }

        private void cbValue_Enter(object sender, EventArgs e)
        {
            cbYearId.Text = string.Empty;
        }
        private void tbId_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Subject.ValidateId(tbId.Text);
            }
            catch (FormatException ex)
            {
                e.Cancel = true;
                errorProvider.SetError(tbId, "Invalid id");
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

        #region DragDrop
        private void dgvSubjects_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void dgvSubjects_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
            {
                string[] files = (string[])e.Data.GetData(DataFormats.FileDrop);
                foreach (string file in files)
                    try
                    {
                        viewModel.AddBulkFromFile(file);
                    }
                    catch (WrongFormatException ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                viewModel.AddBulkMessage();
            }
        }
        #endregion

        #region Printing
        private void btnPrintDocument_Click(object sender, EventArgs e)
        {
            try
            {
                if (printDialog.ShowDialog() == DialogResult.OK)
                    printDocument.Print();
            }
            catch (Exception)
            {
                MessageBox.Show("Cannot access the file because it is being used by another process", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrintPreview_Click(object sender, EventArgs e)
        {
            try
            {
                printPreviewDialog.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("An error occurred while trying to load the document for Print Preview. Make sure you currently have access to a printer. A printer must be connected and accessible for Print Preview to work.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrintSetup_Click(object sender, EventArgs e)
        {
            pageSetupDialog.PageSettings = printDocument.DefaultPageSettings;

            if (pageSetupDialog.ShowDialog() == DialogResult.OK)
                printDocument.DefaultPageSettings = pageSetupDialog.PageSettings;
        }

        private void printDocument_BeginPrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            viewModel.BeginPrint();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            try
            {
                viewModel.PrintPage(e.Graphics, e.MarginBounds, e.PageSettings);
            }
            catch (HasMorePagesException ex)
            {
                e.HasMorePages = true;
            }
        }
        #endregion

        private void btnBack_Click(object sender, EventArgs e)
        {
            closedX = false;
            Owner.Show();
            this.Close();
        }
        private void statusStrip_TextChanged(object sender, EventArgs e)
        {
            lStatus.Text = statusStrip.Text;
        }
    }
}
