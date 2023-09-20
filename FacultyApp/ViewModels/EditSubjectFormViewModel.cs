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
    internal class EditSubjectFormViewModel : INotifyPropertyChanged
    {
        public List<Year> Years { get; set; }

        #region Subject
        private SubjectDto _subject;
        public SubjectDto Subject
        {
            get { return _subject; }
            set
            {
                if (_subject == value)
                    return;
                _subject = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Name
        private string _name;
        public string Name
        {
            get { return _name; }
            set
            {
                if (_name == value)
                    return;
                _name = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Credits
        private string _credits;
        public string Credits
        {
            get { return _credits; }
            set
            {
                if (_credits == value)
                    return;
                _credits = value;
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

        public EditSubjectFormViewModel(SubjectDto subject)
        {
            Years = Year.GetYears();
            Subject = subject;
            Name = subject.Name;
            Credits = subject.Credits.ToString();
            Degree = subject.Degree;
            Value = subject.Year.ToString();
            YearId = Year.ComputeId(subject.Degree, subject.Year).ToString();
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
                Subject.Degree = Degree;
                Subject.Year = Int32.Parse(Value);
            }
            else
            {
                int id = Int32.Parse(YearId);
                Subject.Degree = Year.ComputeDegree(id);
                Subject.Year = Year.ComputeValue(id);
            }
            Subject.Name = Name;
            Subject.Credits = Int32.Parse(Credits);
        }
    }
}
