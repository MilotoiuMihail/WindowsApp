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
    public partial class ManageGradesForm : Form
    {
        ManageGradesFormViewModel viewModel;
        public ManageGradesForm(Student student)
        {
            InitializeComponent();
            viewModel = new ManageGradesFormViewModel(student);
        }
        private void ManageGradesForm_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            viewModel.SortGrades(0);
            InitalizeValues();
            DataBind();
            viewModel.ResetValues();
            dgvGrades.ClearSelection();
        }
        private void ManageGradesForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void InitalizeValues()
        {
            lStudentId.Text = viewModel.Student.Id;
            lLastName.Text = viewModel.Student.LastName;
            lFirstName.Text = viewModel.Student.FirstName;
            lDegree.Text = Year.ComputeDegree(viewModel.Student.YearId);
            lValue.Text = Year.ComputeValue(viewModel.Student.YearId).ToString();
        }
        private void DataBind()
        {
            dgvGrades.DataSource = viewModel.Grades;
            cbId.DataSource = viewModel.Subjects.Where(x => x.YearId == viewModel.Student.YearId).Select(x => x.Id).OrderBy(x => x).ToList();
            cbId.DataBindings.Add("Text", viewModel, nameof(viewModel.SubjectId), true, DataSourceUpdateMode.OnPropertyChanged);
            cbSubject.DataSource = viewModel.Subjects.Where(x => x.YearId == viewModel.Student.YearId).Select(x => x.Name).OrderBy(x => x).ToList();
            cbSubject.DataBindings.Add("Text", viewModel, nameof(viewModel.SubjectName), true, DataSourceUpdateMode.OnPropertyChanged);
            tbGrade.DataBindings.Add("Text", viewModel, nameof(viewModel.GradeValue), true, DataSourceUpdateMode.OnPropertyChanged);
            statusStrip.DataBindings.Add("Text", viewModel, nameof(viewModel.StatusMessage), true, DataSourceUpdateMode.OnPropertyChanged);
        }
        #region Adding
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren(ValidationConstraints.Visible))
            {
                MessageBox.Show("The form contains errors", "Add Grade", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                viewModel.AddGrade();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Grade already exists.", "Add Grade", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cbId.Select();
            dgvGrades.ClearSelection();
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
            GradeDto grade = (GradeDto)dgvGrades.SelectedRows[0].DataBoundItem;

            EditGradeForm editForm = new EditGradeForm(grade, viewModel.Student);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                viewModel.EditGrade(grade);
                dgvGrades.Refresh();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvGrades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Choose a grade!", "Edit grade", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EditSelectedRow();
        }
        private void ctxBtnEditRow_Click(object sender, EventArgs e)
        {
            EditSelectedRow();
        }
        private void dgvGrades_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvGrades.SelectedRows.Count > 0 && e.RowIndex == dgvGrades.SelectedRows[0].Index)
            {
                EditSelectedRow();
            }
        }
        #endregion

        #region Deleting
        private void DeleteSelectedRow()
        {
            if (MessageBox.Show("Delete selected grade?", "Delete grade", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                GradeDto grade = (GradeDto)dgvGrades.SelectedRows[0].DataBoundItem;
                viewModel.DeleteGrade(grade);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvGrades.SelectedRows.Count == 0)
            {
                MessageBox.Show("Choose a grade!", "Delete grade", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            viewModel.SearchGrade();
            dgvGrades.ClearSelection();
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
                    writer.WriteLine(Year.CSV_HEADER);
                    foreach (var grade in viewModel.Grades)
                    {
                        writer.WriteLine(grade.ToString());
                    }
                }
            }
        }
        private void dgvGrades_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvGrades.SelectedRows.Count == 0)
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
        private void dgvGrades_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgvGrades.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0 && hti.RowIndex < dgvGrades.Rows.Count)
                {
                    dgvGrades.ClearSelection();
                    dgvGrades.Rows[hti.RowIndex].Selected = true;
                }
            }
        }
        private void dgvGrades_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            viewModel.SortGrades(e.ColumnIndex);
            dgvGrades.DataSource = viewModel.Grades;
        }
        #endregion

        #region Validations
        private void control_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }
        private void tbId_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbGrade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '.')
            {
                e.Handled = true;
            }
        }
        private void gbSubject_Validating(object sender, CancelEventArgs e)
        {
            if (!viewModel.Subjects.Any(x => x.Id.ToString() == cbId.Text || x.Name == cbSubject.Text))
            {
                e.Cancel = true;
                errorProvider.SetError(gbSubject, "Subject does not exist");
            }
        }

        private void gbGrade_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Grade.ValidateValue(tbGrade.Text);
            }
            catch (FormatException ex)
            {
                e.Cancel = true;
                errorProvider.SetError(gbGrade, "Invalid Grade");
            }
        }

        private void control_Enter(object sender, EventArgs e)
        {
            control_Validated((Control)sender, e);
        }

        private void cbId_Enter(object sender, EventArgs e)
        {
            cbSubject.Text = String.Empty;
        }

        private void cbSubject_Enter(object sender, EventArgs e)
        {
            cbId.Text = String.Empty;
        }
        #endregion

        #region DragDrop
        private void dgvGrades_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void dgvGrades_DragDrop(object sender, DragEventArgs e)
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

        private void cbId_KeyUp(object sender, KeyEventArgs e)
        {
            Subject subject = viewModel.Subjects.Where(x => x.Id.ToString() == cbId.Text).FirstOrDefault();
            if (subject != null)
            {
                cbSubject.Text = subject.Name;
            }
            else
            {
                cbSubject.Text = string.Empty;
            }
        }

        private void cbId_SelectedValueChanged(object sender, EventArgs e)
        {
            Subject subject = viewModel.Subjects.Where(x => x.Id.ToString() == cbId.Text).FirstOrDefault();
            if (subject != null)
            {
                cbSubject.Text = subject.Name;
            }
            else
            {
                cbSubject.Text = string.Empty;
            }
        }

        private void cbSubject_KeyUp(object sender, KeyEventArgs e)
        {
            Subject subject = viewModel.Subjects.Where(x => x.Name.ToLower() == cbSubject.Text.ToLower()).FirstOrDefault();
            if (subject != null)
            {
                cbId.Text = subject.Id.ToString();
            }
            else
            {
                cbId.Text = string.Empty;
            }
        }

        private void cbSubject_SelectedValueChanged(object sender, EventArgs e)
        {
            Subject subject = viewModel.Subjects.Where(x => x.Name.ToLower() == cbSubject.Text.ToLower()).FirstOrDefault();
            if (subject != null)
            {
                cbId.Text = subject.Id.ToString();
            }
            else
            {
                cbId.Text = string.Empty;
            }
        }
        private void statusStrip_TextChanged(object sender, EventArgs e)
        {
            lStatus.Text = statusStrip.Text;
        }
    }
}
