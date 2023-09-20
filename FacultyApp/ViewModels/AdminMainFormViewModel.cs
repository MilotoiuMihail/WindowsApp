using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FacultyApp.ViewModels
{
    internal class AdminMainFormViewModel : INotifyPropertyChanged
    {
        private string ConnectionString = Properties.Settings.Default.Database;

        #region Grades
        private Dictionary<int, float> _grades;
        public Dictionary<int, float> Grades
        {
            get { return _grades; }
            set
            {
                if (_grades == value)
                    return;
                _grades = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region StudentCount
        private string _studentCount;
        public string StudentCount
        {
            get { return _studentCount; }
            set
            {
                if (_studentCount == value)
                    return;
                _studentCount = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region YearCount
        private string _yearCount;
        public string YearCount
        {
            get { return _yearCount; }
            set
            {
                if (_yearCount == value)
                    return;
                _yearCount = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region SubjectCount
        private string _subjectCount;
        public string SubjectCount
        {
            get { return _subjectCount; }
            set
            {
                if (_subjectCount == value)
                    return;
                _subjectCount = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public AdminMainFormViewModel()
        {
            Grades = new Dictionary<int, float>();
            Refresh();
        }
        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
        private void CountStudents()
        {
            string query = "SELECT  COUNT(*) AS Count FROM Students;";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    long count = reader.Read() ? (long)reader["Count"] : 0;
                    StudentCount = count.ToString();
                }
            }
        }
        private void CountYears()
        {
            string query = "SELECT  COUNT(*) AS Count FROM Years;";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    long count = reader.Read() ? (long)reader["Count"] : 0;
                    YearCount = count.ToString();
                }
            }
        }
        private void CountSubjects()
        {
            string query = "SELECT  COUNT(*) AS Count FROM Subjects;";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    long count = reader.Read() ? (long)reader["Count"] : 0;
                    SubjectCount = count.ToString();
                }
            }
        }
        private void YearGrades()
        {
            Grades.Clear();
            string query = "SELECT  s.YearId, AVG(g.Value) AS Grade FROM Grades g JOIN Subjects s ON g.SubjectId=s.Id GROUP BY s.YearId ORDER BY s.YearId";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        int yearId = (int)reader["YearId"];
                        float grade = (float)(double)reader["Grade"];

                        Grades.Add(yearId, grade);
                    }
            }
        }

        public void Refresh()
        {
            CountStudents();
            CountSubjects();
            CountYears();
            YearGrades();
        }
    }
}
