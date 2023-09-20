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
    internal class ManageSubjectsFormViewModel : INotifyPropertyChanged
    {
        public BindingList<SubjectDto> Subjects { get; set; }
        public List<Year> Years { get; set; }
        private string ConnectionString = Properties.Settings.Default.Database;

        private int lines = 0;
        private int incorrectLines = 0;

        private Timer statusTimer;
        public const float STATUS_DISPLAY_TIME = 10;

        private int printIndex = 0;
        private bool firstPagePrinted = false;

        #region Id
        private string _id;
        public string Id
        {
            get { return _id; }
            set
            {
                if (_id == value)
                    return;
                _id = value;
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
        public ManageSubjectsFormViewModel()
        {
            Subjects = new BindingList<SubjectDto>();
            Years = Year.GetYears();
            InitTimer();
            LoadSubjectsFromDatabase();
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
        public void AddSubject()
        {
            int yearId = string.IsNullOrEmpty(YearId) ? Year.ComputeId(Degree, Int32.Parse(Value)) : Int32.Parse(YearId);
            Subject subject = new Subject(Int32.Parse(Id), Name, Int32.Parse(Credits), yearId);
            AddSubject(subject);
        }
        private void AddSubject(Subject subject)
        {
            AddSubjectInDatabase(subject);
            Subjects.Add(new SubjectDto(subject));
            ResetValues();
            AddMessage();
        }
        public void AddBulkFromFile(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                if (reader.ReadLine() != SubjectDto.CSV_HEADER)
                    throw new WrongFormatException(fileName);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var values = line.Split(',');
                    try
                    {
                        Subject.ValidateId(values[0]);
                        Subject.ValidateName(values[1]);
                        Subject.ValidateCredits(values[2]);
                        Year.ValidateDegree(values[3]);
                        Year.ValidateValue(values[4]);
                        int id = Int32.Parse(values[0]);
                        string name = values[1];
                        int credits = Int32.Parse(values[2]);
                        string degree = values[3];
                        int year = Int32.Parse(values[4]);

                        Subject subject = new Subject(id, name, credits, Year.ComputeId(degree, year));
                        AddSubject(subject);
                        lines += 1;
                    }
                    catch (Exception ex)
                    {
                        incorrectLines += 1;
                    }
                }
            }
        }
        private void AddSubjectInDatabase(Subject subject)
        {
            string query = "INSERT INTO Subjects(Id, Name, Credits, YearId) VALUES (@Id, @Name, @Credits, @YearId);";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", subject.Id);
                command.Parameters.AddWithValue("@Name", subject.Name);
                command.Parameters.AddWithValue("@Credits", subject.Credits);
                command.Parameters.AddWithValue("@YearId", subject.YearId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region Deleting
        public void DeleteSubject(SubjectDto subject)
        {
            DeleteSubjectInDatabase(new Subject(subject));
            Subjects.Remove(subject);
            ResetValues();
            DeleteMessage();
        }
        private void DeleteSubjectInDatabase(Subject subject)
        {
            string query = "DELETE FROM Subjects WHERE Id=@Id;";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", subject.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region Editing
        public void EditSubject(SubjectDto subject)
        {
            UpdateSubjectInDatabase(new Subject(subject));
            EditMessage();
        }
        private void UpdateSubjectInDatabase(Subject subject)
        {
            string query = "UPDATE Subjects SET Credits = @Credits, Name = @Name, YearId = @YearId WHERE Id=@Id;";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", subject.Id);
                command.Parameters.AddWithValue("@Credits", subject.Credits);
                command.Parameters.AddWithValue("@Name", subject.Name);
                command.Parameters.AddWithValue("@YearId", subject.YearId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region Searching
        public void SearchSubject()
        {
            SearchSubjectInDatabase();
            SearchMessage();
        }
        private void SearchSubjectInDatabase()
        {
            Subjects.Clear();

            string query = "SELECT * FROM Subjects s join Years y on s.YearId=y.Id WHERE Degree=IIF(@Degree IS NOT NULL AND @Degree!='', @Degree, Degree) AND Value=IIF(@Value IS NOT NULL AND @Value!='', @Value, Value) AND s.Id=IIF(@Id IS NOT NULL AND @Id!='', @Id, s.Id) AND Name=IIF(@Name IS NOT NULL AND @Name!='', @Name, Name) AND Credits=IIF(@Credits IS NOT NULL AND @Credits!='', @Credits, Credits) AND YearId LIKE IIF(@YearId IS NOT NULL AND @YearId!='', @YearId, YearId);";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@Degree", Degree);
                command.Parameters.AddWithValue("@Value", Value);
                command.Parameters.AddWithValue("@Name", Name);
                command.Parameters.AddWithValue("@Credits", Credits);
                command.Parameters.AddWithValue("@YearId", YearId);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        int _id = (int)reader["Id"];
                        string _name = (string)reader["Name"];
                        int _credits = (int)reader["Credits"];
                        int _yearId = (int)reader["YearId"];

                        Subject subject = new Subject(_id, _name, _credits, _yearId);
                        Subjects.Add(new SubjectDto(subject));
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
            StatusMessage = Subjects.Count > 0 ? "Search returned " + Subjects.Count + " lines." : "No data found";
        }
        public void AddBulkMessage()
        {
            StatusMessage = "Added " + lines + " lines." + (incorrectLines > 0 ? " Skipped " + incorrectLines + " incorrect lines." : null);
            lines = 0;
            incorrectLines = 0;
        }
        #endregion

        #region Sorting
        public void SortSubjects(int columnIndex)
        {
            switch (columnIndex)
            {
                case 0:
                    SortSubjectsById();
                    break;
                case 1:
                    SortSubjectsByName();
                    break;
                case 2:
                    SortSubjectsByCredits();
                    break;
                case 3:
                    SortStudentsByDegree();
                    break;
                case 4:
                    SortStudentsByValue();
                    break;
                default:
                    break;
            }
        }
        private void SortSubjectsById()
        {
            var temp = Subjects.OrderBy(x => x.Id).ToList<SubjectDto>();
            if (Subjects.SequenceEqual(temp))
                temp = Subjects.Reverse().ToList<SubjectDto>();
            Subjects = new BindingList<SubjectDto>(temp);
        }
        private void SortSubjectsByName()
        {
            var temp = Subjects.OrderBy(x => x.Name).ToList<SubjectDto>();
            if (Subjects.SequenceEqual(temp))
                temp = Subjects.Reverse().ToList<SubjectDto>();
            Subjects = new BindingList<SubjectDto>(temp);
        }
        private void SortSubjectsByCredits()
        {
            var temp = Subjects.OrderBy(x => x.Credits).ToList<SubjectDto>();
            if (Subjects.SequenceEqual(temp))
                temp = Subjects.Reverse().ToList<SubjectDto>();
            Subjects = new BindingList<SubjectDto>(temp);
        }
        private void SortStudentsByDegree()
        {
            var temp = Subjects.OrderBy(x => x.Degree).ToList<SubjectDto>();
            if (Subjects.SequenceEqual(temp))
                temp = Subjects.Reverse().ToList<SubjectDto>();
            Subjects = new BindingList<SubjectDto>(temp);
        }
        private void SortStudentsByValue()
        {
            var temp = Subjects.OrderBy(x => x.Year).ToList<SubjectDto>();
            if (Subjects.SequenceEqual(temp))
                temp = Subjects.Reverse().ToList<SubjectDto>();
            Subjects = new BindingList<SubjectDto>(temp);
        }
        #endregion

        #region Utils
        public void LoadSubjectsFromDatabase()
        {
            Subjects.Clear();
            string query = "SELECT * FROM Subjects;";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        int _id = (int)reader["Id"];
                        string _name = (string)reader["Name"];
                        int _credits = (int)reader["Credits"];
                        int _yearId = (int)reader["YearId"];

                        Subject subject = new Subject(_id, _name, _credits, _yearId);
                        Subjects.Add(new SubjectDto(subject));
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
        private void ResetValues()
        {
            Id = string.Empty;
            Degree = string.Empty;
            Value = string.Empty;
            Name = string.Empty;
            Credits = string.Empty;
            YearId = string.Empty;
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

            var subjectProperties = typeof(SubjectDto).GetProperties();

            int rowHeight = 40;
            var columnWidth = printAreaWidth / subjectProperties.Length;

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
                        "Subjects",
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
                for (int i = 0; i < subjectProperties.Length; i++)
                {
                    graphics.DrawRectangle(
                        Pens.Black,
                        currentX,
                        currentY,
                        columnWidth,
                        rowHeight);

                    graphics.DrawString(
                        subjectProperties[i].Name,
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

            while (printIndex < Subjects.Count)
            {
                if (currentY + rowHeight > printAreaHeight)
                {
                    throw new HasMorePagesException();
                }
                currentX = marginLeft;

                #region Rows
                for (int i = 0; i < subjectProperties.Length; i++)
                {
                    graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);

                    stringFormat.Alignment = subjectProperties[i].PropertyType == typeof(int) ? StringAlignment.Far : StringAlignment.Near;

                    graphics.DrawString(
                        subjectProperties[i].GetValue(Subjects[printIndex]).ToString(),
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
