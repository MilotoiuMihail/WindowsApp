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
    internal class ManageStudentsFormViewModel : INotifyPropertyChanged
    {
        public BindingList<StudentDto> Students { get; set; }
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

        #region LastName
        private string _lastName;
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName == value)
                    return;
                _lastName = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region FirstName
        private string _firstName;
        public string FirstName
        {
            get { return _firstName; }
            set
            {
                if (_firstName == value)
                    return;
                _firstName = value;
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
        public ManageStudentsFormViewModel()
        {
            Students = new BindingList<StudentDto>();
            Years = Year.GetYears();
            InitTimer();
            LoadStudentsFromDatabase();
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
        public void AddStudent()
        {
            int id = string.IsNullOrEmpty(YearId) ? Year.ComputeId(Degree, Int32.Parse(Value)) : Int32.Parse(YearId);
            Student student = new Student(Id, LastName, FirstName, id);
            AddStudent(student);
        }
        private void AddStudent(Student student)
        {
            AddStudentInDatabase(student);
            Students.Add(new StudentDto(student));
            ResetValues();
            AddMessage();
        }
        public void AddBulkFromFile(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                if (reader.ReadLine() != StudentDto.CSV_HEADER)
                    throw new WrongFormatException(fileName);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var values = line.Split(',');
                    try
                    {
                        Student.ValidateId(values[0]);
                        Student.ValidateName(values[1]);
                        Student.ValidateName(values[2]);
                        Student.ValidateEmail(values[3], values[1], values[2], values[0]);
                        Year.ValidateDegree(values[4]);
                        Year.ValidateValue(values[5]);
                        string id = values[0];
                        string lastName = values[1];
                        string firstName = values[2];
                        string degree = values[4];
                        int year = Int32.Parse(values[5]);

                        Student student = new Student(id, lastName, firstName, Year.ComputeId(degree, year));
                        AddStudent(student);
                        lines += 1;
                    }
                    catch (Exception ex)
                    {
                        incorrectLines += 1;
                    }
                }
            }
        }
        private void AddStudentInDatabase(Student student)
        {
            string query = "INSERT INTO Students(Id, LastName, FirstName, Email, Password, YearId) VALUES (@Id, @LastName, @FirstName, @Email, @Password, @YearId);";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", student.Id);
                command.Parameters.AddWithValue("@LastName", student.LastName);
                command.Parameters.AddWithValue("@FirstName", student.FirstName);
                command.Parameters.AddWithValue("@Email", student.Email);
                command.Parameters.AddWithValue("@Password", student.Password);
                command.Parameters.AddWithValue("@YearId", student.YearId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region Deleting
        public void DeleteStudent(StudentDto student)
        {
            DeleteStudentInDatabase(new Student(student));
            Students.Remove(student);
            ResetValues();
            DeleteMessage();
        }
        private void DeleteStudentInDatabase(Student student)
        {
            string query = "DELETE FROM Students WHERE Id=@Id;";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", student.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region Editing
        public void EditStudent(StudentDto student)
        {
            UpdateStudentInDatabase(new Student(student));
            EditMessage();
        }
        private void UpdateStudentInDatabase(Student student)
        {
            string query = "UPDATE Students SET YearId = @YearId WHERE Id=@Id;";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", student.Id);
                command.Parameters.AddWithValue("@YearId", student.YearId);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region Searching
        public void SearchStudent()
        {
            SearchStudentInDatabase();
            SearchMessage();
        }
        private void SearchStudentInDatabase()
        {
            Students.Clear();

            string query = "SELECT * FROM Students s join Years y on s.YearId=y.Id WHERE Degree=IIF(@Degree IS NOT NULL AND @Degree!='', @Degree, Degree) AND Value=IIF(@Value IS NOT NULL AND @Value!='', @Value, Value) AND s.Id=IIF(@Id IS NOT NULL AND @Id!='', @Id, s.Id) AND LastName=IIF(@LastName IS NOT NULL AND @LastName!='', @LastName, LastName) AND FirstName=IIF(@FirstName IS NOT NULL AND @FirstName!='', @FirstName, FirstName) AND YearId LIKE IIF(@YearId IS NOT NULL AND @YearId!='', @YearId, YearId);";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@Degree", Degree);
                command.Parameters.AddWithValue("@Value", Value);
                command.Parameters.AddWithValue("@LastName", LastName);
                command.Parameters.AddWithValue("@FirstName", FirstName);
                command.Parameters.AddWithValue("@YearId", YearId);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        string _id = (string)reader["Id"];
                        string _lastName = (string)reader["LastName"];
                        string _firstName = (string)reader["FirstName"];
                        int _yearId = (int)reader["YearId"];

                        Student student = new Student(_id, _lastName, _firstName, _yearId);
                        Students.Add(new StudentDto(student));
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
            StatusMessage = Students.Count > 0 ? "Search returned " + Students.Count + " lines." : "No data found";
        }
        public void AddBulkMessage()
        {
            StatusMessage = "Added " + lines + " lines." + (incorrectLines > 0 ? " Skipped " + incorrectLines + " incorrect lines." : null);
            lines = 0;
            incorrectLines = 0;
        }
        #endregion

        #region Sorting
        public void SortStudents(int columnIndex)
        {
            switch (columnIndex)
            {
                case 0:
                    SortStudentsById();
                    break;
                case 1:
                    SortStudentsByLastName();
                    break;
                case 2:
                    SortStudentsByFirstName();
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
        private void SortStudentsById()
        {
            var temp = Students.OrderBy(x => x.Id).ToList<StudentDto>();
            if (Students.SequenceEqual(temp))
                temp = Students.Reverse().ToList<StudentDto>();
            Students = new BindingList<StudentDto>(temp);
        }
        private void SortStudentsByLastName()
        {
            var temp = Students.OrderBy(x => x.LastName).ToList<StudentDto>();
            if (Students.SequenceEqual(temp))
                temp = Students.Reverse().ToList<StudentDto>();
            Students = new BindingList<StudentDto>(temp);
        }
        private void SortStudentsByFirstName()
        {
            var temp = Students.OrderBy(x => x.FirstName).ToList<StudentDto>();
            if (Students.SequenceEqual(temp))
                temp = Students.Reverse().ToList<StudentDto>();
            Students = new BindingList<StudentDto>(temp);
        }
        private void SortStudentsByDegree()
        {
            var temp = Students.OrderBy(x => x.Degree).ToList<StudentDto>();
            if (Students.SequenceEqual(temp))
                temp = Students.Reverse().ToList<StudentDto>();
            Students = new BindingList<StudentDto>(temp);
        }
        private void SortStudentsByValue()
        {
            var temp = Students.OrderBy(x => x.Year).ToList<StudentDto>();
            if (Students.SequenceEqual(temp))
                temp = Students.Reverse().ToList<StudentDto>();
            Students = new BindingList<StudentDto>(temp);
        }
        #endregion

        #region Utils
        private void LoadStudentsFromDatabase()
        {
            Students.Clear();
            string query = "SELECT * FROM Students;";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        string _id = (string)reader["Id"];
                        string _lastName = (string)reader["LastName"];
                        string _firstName = (string)reader["FirstName"];
                        int _yearId = (int)reader["YearId"];

                        Student student = new Student(_id, _lastName, _firstName, _yearId);
                        Students.Add(new StudentDto(student));
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
            LastName = string.Empty;
            FirstName = string.Empty;
            Degree = string.Empty;
            Value = string.Empty;
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
            Font font = new Font("Microsoft Sans Serif", 8);

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

            var studentProperties = typeof(StudentDto).GetProperties();

            int rowHeight = 40;
            var columnWidth = printAreaWidth / studentProperties.Length;

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
                        "Students",
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
                for (int i = 0; i < studentProperties.Length; i++)
                {
                    graphics.DrawRectangle(
                        Pens.Black,
                        currentX,
                        currentY,
                        columnWidth,
                        rowHeight);

                    graphics.DrawString(
                        studentProperties[i].Name,
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

            while (printIndex < Students.Count)
            {
                if (currentY + rowHeight > printAreaHeight)
                {
                    throw new HasMorePagesException();
                }
                currentX = marginLeft;

                #region Rows
                for (int i = 0; i < studentProperties.Length; i++)
                {
                    graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);

                    stringFormat.Alignment = studentProperties[i].PropertyType == typeof(int) ? StringAlignment.Far : StringAlignment.Near;

                    graphics.DrawString(
                        studentProperties[i].GetValue(Students[printIndex]).ToString(),
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
