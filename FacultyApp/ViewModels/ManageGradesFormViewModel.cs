using FacultyApp.CustomExceptions;
using FacultyApp.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SQLite;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FacultyApp.ViewModels
{
    internal class ManageGradesFormViewModel : INotifyPropertyChanged
    {
        public BindingList<GradeDto> Grades { get; set; }
        public List<Subject> Subjects { get; set; }
        public Student Student { get; set; }
        private string ConnectionString = Properties.Settings.Default.Database;

        private int lines = 0;
        private int incorrectLines = 0;

        private Timer statusTimer;
        public const float STATUS_DISPLAY_TIME = 10;

        private int printIndex = 0;
        private bool firstPagePrinted = false;

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
        public ManageGradesFormViewModel(Student student)
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

        #region Adding
        public void AddGrade()
        {
            int id = string.IsNullOrEmpty(SubjectId) ? Subjects.Where(x => x.Name == SubjectName).First().Id : Int32.Parse(SubjectId);
            Grade grade = new Grade(float.Parse(GradeValue), id, Student.Id);
            AddGrade(grade);
        }
        private void AddGrade(Grade grade)
        {
            AddGradeInDatabase(grade);
            Grades.Add(new GradeDto(grade));
            ResetValues();
            AddMessage();
        }
        public void AddBulkFromFile(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                if (reader.ReadLine() != GradeDto.CSV_HEADER)
                    throw new WrongFormatException(fileName);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var values = line.Split(',');
                    try
                    {
                        Subject.ValidateName(values[0]);
                        Grade.ValidateValue(values[2]);

                        string subjectName = values[0];
                        float value = float.Parse(values[2]);
                        DateTime date = DateTime.Parse(values[3]);
                        int subjectId = Subject.GetSubjectId(subjectName);

                        Grade grade = new Grade(value, date, subjectId, Student.Id);
                        AddGrade(grade);
                        lines += 1;
                    }
                    catch (Exception ex)
                    {
                        incorrectLines += 1;
                    }
                }
            }
        }
        private void AddGradeInDatabase(Grade grade)
        {
            string query = "INSERT INTO Grades(Id, Value, Date, SubjectId, StudentId) VALUES (@Id, @Value, @Date, @SubjectId, @StudentId);";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", grade.Id);
                command.Parameters.AddWithValue("@Value", grade.Value);
                command.Parameters.AddWithValue("@Date", grade.Date.ToShortDateString());
                command.Parameters.AddWithValue("@SubjectId", grade.SubjectId);
                command.Parameters.AddWithValue("@StudentId", grade.StudentId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region Deleting
        public void DeleteGrade(GradeDto grade)
        {
            DeleteGradeInDatabase(new Grade(grade, Student.Id));
            Grades.Remove(grade);
            ResetValues();
            DeleteMessage();
        }
        private void DeleteGradeInDatabase(Grade grade)
        {
            string query = "DELETE FROM Grades WHERE Id=@Id;";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", grade.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region Editing
        public void EditGrade(GradeDto grade)
        {
            UpdateGradeInDatabase(new Grade(grade, Student.Id));
            EditMessage();
        }
        private void UpdateGradeInDatabase(Grade grade)
        {
            string query = "UPDATE Grades SET Value = @Value WHERE Id=@Id;";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", grade.Id);
                command.Parameters.AddWithValue("@Value", grade.Value);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        #endregion

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

        #region Messages
        private void AddMessage()
        {
            StatusMessage = "Entry added.";
        }
        private void DeleteMessage()
        {
            StatusMessage = "Entry has been deleted.";
        }
        private void EditMessage()
        {
            StatusMessage = "Entry edited.";
        }
        private void SearchMessage()
        {
            StatusMessage = Grades.Count > 0 ? "Search returned " + Grades.Count + " lines." : "No data found";
        }
        public void AddBulkMessage()
        {
            StatusMessage = "Added " + lines + " lines." + (incorrectLines > 0 ? " Skipped " + incorrectLines + " incorrect lines." : null);
            lines = 0;
            incorrectLines = 0;
        }
        #endregion

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

        #region Utils
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
        #endregion

        #region Printing
        public void BeginPrint()
        {
            firstPagePrinted = false;
            printIndex = 0;
        }

        public void PrintPage(Graphics graphics, Rectangle marginBounds, PageSettings pageSettings)
        {
            Font font = new Font("Microsoft Sans Serif", 12);

            PageSettings _pageSettings = pageSettings;

            var printAreaHeight = marginBounds.Height;
            var printAreaWidth = marginBounds.Width;

            var marginLeft = _pageSettings.Margins.Left;
            var marginTop = _pageSettings.Margins.Top;

            if (_pageSettings.Landscape)
            {
                printAreaWidth = marginBounds.Height;
                printAreaHeight = marginBounds.Width;
            }

            var gradeProperties = typeof(GradeDto).GetProperties();

            int rowHeight = 40;
            var columnWidth = printAreaWidth / gradeProperties.Length;

            StringFormat stringFormat = new StringFormat(StringFormatFlags.LineLimit);
            stringFormat.Trimming = StringTrimming.EllipsisCharacter;

            var currentY = marginTop;
            var currentX = marginLeft;

            #region FirstPage
            if (!firstPagePrinted)
            {
                stringFormat.Alignment = StringAlignment.Center;

                #region Title
                graphics.DrawString(
                        Student.LastName + " " + Student.FirstName + "\'s " + "Grades",
                        new Font(font.Name, font.Size + 8, FontStyle.Bold),
                        Brushes.Black,
                        new RectangleF(
                            currentX,
                            currentY,
                            printAreaWidth,
                            printAreaHeight / 12),
                        stringFormat);
                #endregion

                stringFormat.LineAlignment = StringAlignment.Center;

                #region Date
                graphics.DrawString(
                       "Date: " + DateTime.Now.ToShortDateString(),
                       new Font(font.Name, font.Size - 2),
                       Brushes.Black,
                       new RectangleF(
                           currentX,
                           currentY,
                           printAreaWidth,
                           printAreaHeight / 12),
                       stringFormat);
                #endregion

                currentY += printAreaHeight / 12;

                #region ColumnsHeader
                for (int i = 0; i < gradeProperties.Length; i++)
                {
                    graphics.DrawRectangle(
                        Pens.Black,
                        currentX,
                        currentY,
                        columnWidth,
                        rowHeight);

                    graphics.DrawString(
                        gradeProperties[i].Name,
                        new Font(font.Name, font.Size + 2, FontStyle.Bold),
                        Brushes.Black,
                        new RectangleF(currentX, currentY, columnWidth, rowHeight),
                        stringFormat);

                    currentX += columnWidth;
                }
                #endregion

                currentY += rowHeight;

                firstPagePrinted = true;

            }
            #endregion

            stringFormat.LineAlignment = StringAlignment.Center;
            stringFormat.Alignment = StringAlignment.Near;

            while (printIndex < Grades.Count)
            {
                if (currentY + rowHeight > printAreaHeight)
                {
                    throw new HasMorePagesException();
                }
                currentX = marginLeft;

                #region Rows
                for (int i = 0; i < gradeProperties.Length; i++)
                {
                    graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);

                    stringFormat.Alignment = gradeProperties[i].PropertyType == typeof(int) ? StringAlignment.Far : StringAlignment.Near;

                    graphics.DrawString(
                        gradeProperties[i].GetValue(Grades[printIndex]).ToString(),
                        font,
                        Brushes.Black,
                        new RectangleF(currentX, currentY, columnWidth, rowHeight),
                        stringFormat);

                    currentX += columnWidth;
                }
                #endregion

                printIndex += 1;
                currentY += rowHeight;
            }
        }
        #endregion
    }
}