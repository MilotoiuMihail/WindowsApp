using FacultyApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FacultyApp.ViewModels
{
    internal class EditStudentFormViewModel : INotifyPropertyChanged
    {
        public List<Year> Years { get; set; }

        #region Student
        private StudentDto _student;
        public StudentDto Student
        {
            get { return _student; }
            set
            {
                if (_student == value)
                    return;
                _student = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Degree
        private string _degree;
        public string Degree
        {
            get { return _degree; }
            set
            {
                if (_degree == value)
                    return;
                _degree = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Value
        private string _value;
        public string Value
        {
            get { return _value; }
            set
            {
                if (_value == value)
                    return;
                _value = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region YearId
        private string _yearId;
        public string YearId
        {
            get { return _yearId; }
            set
            {
                if (_yearId == value)
                    return;
                _yearId = value;
                OnPropertyChanged();
            }
        }
        #endregion
        public EditStudentFormViewModel(StudentDto student)
        {
            Years = Year.GetYears();
            Student = student;
            Degree = student.Degree;
            Value = student.Year.ToString();
            YearId = Year.ComputeId(student.Degree, student.Year).ToString();
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public void UpdateValues()
        {
            if (string.IsNullOrEmpty(YearId))
            {
                Student.Degree = Degree;
                Student.Year = Int32.Parse(Value);
            }
            else
            {
                int id = Int32.Parse(YearId);
                Student.Degree = Year.ComputeDegree(id);
                Student.Year = Year.ComputeValue(id);
            }
        }
    }
}
