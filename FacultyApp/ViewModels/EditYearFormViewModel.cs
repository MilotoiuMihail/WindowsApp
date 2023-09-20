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
    internal class EditYearFormViewModel : INotifyPropertyChanged
    {
        #region Year
        private Year _year;
        public Year Year
        {
            get { return _year; }
            set
            {
                if (_year == value)
                    return;
                _year = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region RequiredCredits
        private string _requiredCredits;
        public string RequiredCredits
        {
            get { return _requiredCredits; }
            set
            {
                if (_requiredCredits == value)
                    return;
                _requiredCredits = value;
                OnPropertyChanged();
            }
        }
        #endregion
        public EditYearFormViewModel(Year year)
        {
            Year = year;
            RequiredCredits = year.RequiredCredits.ToString();
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
            Year.RequiredCredits = Int32.Parse(RequiredCredits);
        }
    }
}
