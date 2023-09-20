using FacultyApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultyApp.ViewModels
{
    internal class StudentMainFormViewModel : INotifyPropertyChanged
    {
        public BindingList<GradeDto> Grades { get; set; }
        public List<Subject> Subjects { get; set; }
        public Student Student { get; set; }
        private string ConnectionString = Properties.Settings.Default.Database;

        private Timer statusTimer;
        public const float STATUS_DISPLAY_TIME = 10;

        #region SubjectId
        private string _subjectId;
        public string SubjectId
        {
            get { return _subjectId; }
            set
            {
                if (_subjectId == value)
                    return;
                _subjectId = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region SubjectName
        private string _subjectName;
        public string SubjectName
        {
            get { return _subjectName; }
            set
            {
                if (_subjectName == value)
                    return;
                _subjectName = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region GradeValue
        private string _gradeValue;
        public string GradeValue
        {
            get { return _gradeValue; }
            set
            {
                if (_gradeValue == value)
                    return;
                _gradeValue = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region StatusMessage
        private string _statusMessage;
        public string StatusMessage
        {
            get { return _statusMessage; }
            set
            {
                if (_statusMessage == value)
                {
                    ResetTimer();
                    return;
                }
                _statusMessage = value;
                OnPropertyChanged();
                if (value == string.Empty)
                    return;
                ResetTimer();
            }
        }
        #endregion

        public StudentMainFormViewModel(Student student)
        {
            Grades = new BindingList<GradeDto>();
            Subjects = Subject.GetSubjects().Where(x => x.YearId == student.YearId).ToList();
            Student = student;
            InitTimer();
            LoadGradesFromDatabase();
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public void ChangePassword()
        {

        }

        #region Searching
        public void SearchGrade()
        {
            SearchGradeInDatabase();
            SearchMessage();
        }
        private void SearchGradeInDatabase()
        {
            Grades.Clear();
            string query = "SELECT * FROM Grades g JOIN Subjects s ON g.SubjectId=s.Id WHERE YearId=@YearId AND SubjectId=IIF(@SubjectId IS NOT NULL AND @SubjectId!='', @SubjectId, SubjectId) AND StudentId=@StudentId AND Value=IIF(@Value IS NOT NULL AND @Value!='', @Value, Value);";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                string subjectId = String.IsNullOrEmpty(SubjectName) ? SubjectId : Subject.GetSubjectId(SubjectName).ToString();
                command.Parameters.AddWithValue("@YearId", Student.YearId);
                command.Parameters.AddWithValue("@SubjectId", subjectId);
                command.Parameters.AddWithValue("@StudentId", Student.Id);
                command.Parameters.AddWithValue("@Value", GradeValue);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        double _value = (double)reader["Value"];
                        string _date = (string)reader["Date"];
                        int _subjectId = (int)reader["SubjectId"];

                        Grade grade = new Grade((float)_value, DateTime.Parse(_date), _subjectId, Student.Id);
                        Grades.Add(new GradeDto(grade));
                    }
            }
        }
        #endregion

        private void SearchMessage()
        {
            StatusMessage = Grades.Count > 0 ? "Search returned " + Grades.Count + " lines." : "No data found";
        }

        #region Sorting
        public void SortGrades(int columnIndex)
        {
            switch (columnIndex)
            {
                case 0:
                    SortGradesBySubjectName();
                    break;
                case 1:
                    SortGradesByCredits();
                    break;
                case 2:
                    SortGradesByValue();
                    break;
                case 3:
                    SortGradesByDate();
                    break;
                default:
                    break;
            }
        }
        private void SortGradesBySubjectName()
        {
            var temp = Grades.OrderBy(x => x.SubjectName).ToList<GradeDto>();
            if (Grades.SequenceEqual(temp))
                temp = Grades.Reverse().ToList<GradeDto>();
            Grades = new BindingList<GradeDto>(temp);
        }
        private void SortGradesByCredits()
        {
            var temp = Grades.OrderBy(x => x.Credits).ToList<GradeDto>();
            if (Grades.SequenceEqual(temp))
                temp = Grades.Reverse().ToList<GradeDto>();
            Grades = new BindingList<GradeDto>(temp);
        }
        private void SortGradesByValue()
        {
            var temp = Grades.OrderBy(x => x.Grade).ToList<GradeDto>();
            if (Grades.SequenceEqual(temp))
                temp = Grades.Reverse().ToList<GradeDto>();
            Grades = new BindingList<GradeDto>(temp);
        }
        private void SortGradesByDate()
        {
            var temp = Grades.OrderBy(x => x.Date).ToList<GradeDto>();
            if (Grades.SequenceEqual(temp))
                temp = Grades.Reverse().ToList<GradeDto>();
            Grades = new BindingList<GradeDto>(temp);
        }
        #endregion

        private void LoadGradesFromDatabase()
        {
            Grades.Clear();
            string query = "SELECT * FROM Grades g JOIN Subjects s ON g.SubjectId=s.Id WHERE StudentId=@StudentId AND s.YearId=@YearId;";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@StudentId", Student.Id);
                command.Parameters.AddWithValue("@YearId", Student.YearId);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {

                        double _value = (double)reader["Value"];
                        string _date = (string)reader["Date"];
                        int _subjectId = (int)reader["SubjectId"];


                        Grade grade = new Grade((float)_value, DateTime.Parse(_date), _subjectId, Student.Id);
                        Grades.Add(new GradeDto(grade));
                    }
            }
        }
        private void InitTimer()
        {
            statusTimer = new Timer();
            statusTimer.Interval = (int)(STATUS_DISPLAY_TIME * 1000);
            statusTimer.Tick += (sender, e) =>
            {
                statusTimer.Stop();
                StatusMessage = string.Empty;
            };
        }
        private void ResetTimer()
        {
            statusTimer.Stop();
            statusTimer.Start();
        }
        public void ResetValues()
        {
            SubjectId = String.Empty;
            SubjectName = String.Empty;
            GradeValue = String.Empty;
        }
    }
}
