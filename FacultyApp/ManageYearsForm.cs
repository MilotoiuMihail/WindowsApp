using FacultyApp.CustomExceptions;
using FacultyApp.Entities;
using FacultyApp.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace FacultyApp
{
    public partial class ManageYearsForm : Form
    {
        ManageYearsFormViewModel viewModel;
        private bool closedX = true;
        public ManageYearsForm()
        {
            InitializeComponent();
            viewModel = new ManageYearsFormViewModel();
        }
        private void ManageYearsForm_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            this.CenterToParent();
            viewModel.SortYears(0);
            DataBind();
            dgvYears.ClearSelection();
        }
        private void ManageYearsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
            if (closedX)
                Application.Exit();
        }

        private void DataBind()
        {
            dgvYears.DataSource = viewModel.Years;
            cbDegree.DataSource = Enum.GetNames(typeof(DegreeEnum));
            cbDegree.DataBindings.Add("Text", viewModel, nameof(viewModel.Degree), true, DataSourceUpdateMode.OnPropertyChanged);
            tbValue.DataBindings.Add("Text", viewModel, nameof(viewModel.Value), true, DataSourceUpdateMode.OnPropertyChanged);
            tbRequiredCredits.DataBindings.Add("Text", viewModel, nameof(viewModel.RequiredCredits), true, DataSourceUpdateMode.OnPropertyChanged);
            tbId.DataBindings.Add("Text", viewModel, nameof(viewModel.Id), true, DataSourceUpdateMode.OnPropertyChanged);
            statusStrip.DataBindings.Add("Text", viewModel, nameof(viewModel.StatusMessage), true, DataSourceUpdateMode.OnPropertyChanged);
        }

        #region Adding
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("The form contains errors", "Add Year", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            try
            {
                viewModel.AddYear();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Year already exists.", "Add Year", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cbDegree.Select();
            dgvYears.ClearSelection();
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
            Year year = (Year)dgvYears.SelectedRows[0].DataBoundItem;

            EditYearForm editForm = new EditYearForm(year);
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                viewModel.EditYear(year);
                dgvYears.Refresh();
            }
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgvYears.SelectedRows.Count == 0)
            {
                MessageBox.Show("Choose a year!", "Edit year", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            EditSelectedRow();
        }
        private void ctxBtnEditRow_Click(object sender, EventArgs e)
        {
            EditSelectedRow();
        }
        private void dgvYears_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvYears.SelectedRows.Count > 0 && e.RowIndex == dgvYears.SelectedRows[0].Index)
            {
                EditSelectedRow();
            }
        }
        #endregion

        #region Deleting
        private void DeleteSelectedRow()
        {
            if (MessageBox.Show("Delete selected year?", "Delete year", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                Year year = (Year)dgvYears.SelectedRows[0].DataBoundItem;
                viewModel.DeleteYear(year);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvYears.SelectedRows.Count == 0)
            {
                MessageBox.Show("Choose a year!", "Delete year", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            viewModel.SearchYear();
            dgvYears.ClearSelection();
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
                    foreach (var year in viewModel.Years)
                    {
                        writer.WriteLine(year.ToString());
                    }
                }
            }
        }
        private void dgvYears_KeyDown(object sender, KeyEventArgs e)
        {
            if (dgvYears.SelectedRows.Count == 0)
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
        private void dgvYears_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hti = dgvYears.HitTest(e.X, e.Y);
                if (hti.RowIndex >= 0 && hti.RowIndex < dgvYears.Rows.Count)
                {
                    dgvYears.ClearSelection();
                    dgvYears.Rows[hti.RowIndex].Selected = true;
                }
            }
        }
        private void dgvYears_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            viewModel.SortYears(e.ColumnIndex);
            dgvYears.DataSource = viewModel.Years;
        }
        #endregion

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
        private void control_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private void cbDegree_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Year.ValidateDegree(cbDegree.Text);
            }
            catch (FormatException ex)
            {
                e.Cancel = true;
                errorProvider.SetError(cbDegree, "Invalid Degree");
            }
        }

        private void tbValue_Validating(object sender, CancelEventArgs e)
        {
            try
            {
                Year.ValidateValue(tbValue.Text);
            }
            catch (FormatException ex)
            {
                e.Cancel = true;
                errorProvider.SetError(tbValue, "Invalid Year");
            }
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

        #region DragDrop
        private void dgvYears_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, true))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private void dgvYears_DragDrop(object sender, DragEventArgs e)
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
        #region XML
        private void btnSaveXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Year>));
            using (FileStream stream = File.Create("YearsXML.xml"))
                serializer.Serialize(stream, viewModel.Years);
        }

        private void btnLoadXML_Click(object sender, EventArgs e)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(BindingList<Year>));
            using (FileStream stream = File.OpenRead("YearsXML.xml"))
            {
                viewModel.Years = (BindingList<Year>)serializer.Deserialize(stream);
                dgvYears.DataSource=viewModel.Years;
            }
        }
        #endregion
    }
}
