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
    internal class EditGradeFormViewModel : INotifyPropertyChanged
    {
        #region Grade
        private GradeDto _grade;
        public GradeDto Grade
        {
            get { return _grade; }
            set
            {
                if (_grade == value)
                    return;
                _grade = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Student
        private Student _student;
        public Student Student
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
        public EditGradeFormViewModel(GradeDto grade, Student student)
        {
            Grade = grade;
            Student = student;
            Value = Grade.Grade.ToString();
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
            Grade.Grade = Int32.Parse(Value);
        }
    }
}
