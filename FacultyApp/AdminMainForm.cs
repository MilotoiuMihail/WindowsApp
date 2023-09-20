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
    public partial class AdminMainForm : Form
    {
        AdminMainFormViewModel viewModel;
        private bool closedX = true;
        public AdminMainForm()
        {
            InitializeComponent();
            viewModel = new AdminMainFormViewModel();
        }

        private void AdminMainForm_Load(object sender, EventArgs e)
        {
            lineChart1.Values = viewModel.Grades.Values.ToArray();
            lineChart1.XLabels = viewModel.Grades.Keys.Select(x => x.ToString()).ToArray();
            DataBind();
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
            this.CenterToParent();
        }
        private void DataBind()
        {
            lYearCount.DataBindings.Add("Text", viewModel, nameof(viewModel.YearCount), true, DataSourceUpdateMode.OnPropertyChanged);
            lSubjectCount.DataBindings.Add("Text", viewModel, nameof(viewModel.SubjectCount), true, DataSourceUpdateMode.OnPropertyChanged);
            lStudentCount.DataBindings.Add("Text", viewModel, nameof(viewModel.StudentCount), true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            closedX = false;
            Owner.Show();
            this.Close();
        }

        private void AdminMainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closedX)
                Application.Exit();

        }

        private void btnManageYears_Click(object sender, EventArgs e)
        {
            ManageYearsForm yearsForm = new ManageYearsForm();
            this.Hide();
            yearsForm.Show(this);
        }

        private void btnManageStudents_Click(object sender, EventArgs e)
        {
            ManageStudentsForm studentsForm = new ManageStudentsForm();
            this.Hide();
            studentsForm.Show(this);
        }

        private void btnManageSubjects_Click(object sender, EventArgs e)
        {
            ManageSubjectsForm subjectsForm = new ManageSubjectsForm();
            this.Hide();
            subjectsForm.Show(this);
        }

    }
}
