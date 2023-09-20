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
    public partial class StudentMainForm : Form
    {
        StudentMainFormViewModel viewModel;
        private bool closedX = true;
        public StudentMainForm(Student student)
        {
            InitializeComponent();
            viewModel = new StudentMainFormViewModel(student);
        }

        private void StudentMainForm_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            this.CenterToParent();
            viewModel.SortGrades(0);
            InitalizeValues();
            DataBind();
            viewModel.ResetValues();
            dgvGrades.ClearSelection();
        }
        private void InitalizeValues()
        {
            lStudentId.Text = viewModel.Student.Id;
            lLastName.Text = viewModel.Student.LastName;
            lFirstName.Text = viewModel.Student.FirstName;
            lDegree.Text = Year.ComputeDegree(viewModel.Student.YearId);
            lValue.Text = Year.ComputeValue(viewModel.Student.YearId).ToString();
            lEmail.Text = viewModel.Student.Email;

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
        private void btnSearch_Click(object sender, EventArgs e)
        {
            viewModel.SearchGrade();
            dgvGrades.ClearSelection();
        }
        private void dgvGrades_ColumnHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            viewModel.SortGrades(e.ColumnIndex);
            dgvGrades.DataSource = viewModel.Grades;
        }
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

        private void btnChangePassword_Click(object sender, EventArgs e)
        {

        }

        private void StudentMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closedX)
                Application.Exit();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            closedX = false;
            Owner.Show();
            this.Close();
        }
    }
}
