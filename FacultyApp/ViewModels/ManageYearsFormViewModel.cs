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
    internal class ManageYearsFormViewModel : INotifyPropertyChanged
    {
        public BindingList<Year> Years { get; set; }
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
        public ManageYearsFormViewModel()
        {
            Years = new BindingList<Year>();
            InitTimer();
            LoadYearsFromDatabase();
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
        public void AddYear()
        {
            Year year = new Year(Degree, Int32.Parse(Value), Int32.Parse(RequiredCredits));
            AddYear(year);
        }

        private void AddYear(Year year)
        {
            AddYearInDatabase(year);
            Years.Add(year);
            ResetValues();
            AddMessage();
        }

        public void AddBulkFromFile(string fileName)
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                if (reader.ReadLine() != Year.CSV_HEADER)
                    throw new WrongFormatException(fileName);
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    var values = line.Split(',');
                    try
                    {
                        Year.ValidateId(values[0], values[1], values[2]);
                        Year.ValidateValue(values[2]);
                        Year.ValidateRequiredCredits(values[3]);
                        string degree = values[1];
                        int value = Int32.Parse(values[2]);
                        int credits = Int32.Parse(values[3]);

                        Year year = new Year(degree, value, credits);
                        AddYear(year);
                        lines += 1;
                    }
                    catch (Exception ex)
                    {
                        incorrectLines += 1;
                    }
                }
            }
        }
        private void AddYearInDatabase(Year year)
        {
            string query = "INSERT INTO Years(Id, Degree, Value, RequiredCredits) VALUES (@Id, @Degree, @Value, @RequiredCredits);";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", year.Id);
                command.Parameters.AddWithValue("@Degree", year.Degree);
                command.Parameters.AddWithValue("@Value", year.Value);
                command.Parameters.AddWithValue("@RequiredCredits", year.RequiredCredits);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region Deleting
        public void DeleteYear(Year year)
        {
            DeleteYearInDatabase(year);
            Years.Remove(year);
            ResetValues();
            DeleteMessage();
        }
        private void DeleteYearInDatabase(Year year)
        {
            string query = "DELETE FROM Years WHERE Id=@Id;";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", year.Id);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region Editing
        public void EditYear(Year year)
        {
            UpdateYearInDatabase(year);
            EditMessage();
        }
        private void UpdateYearInDatabase(Year year)
        {
            string query = "UPDATE Years SET RequiredCredits = @RequiredCredits WHERE Id=@Id;";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", year.Id);
                command.Parameters.AddWithValue("@RequiredCredits", year.RequiredCredits);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region Searching
        public void SearchYear()
        {
            SearchYearsInDatabase();
            SearchMessage();
        }
        private void SearchYearsInDatabase()
        {
            Years.Clear();

            string query = "SELECT * FROM Years WHERE Id=IIF(@Id IS NOT NULL AND @Id!='', @Id, Id) AND Degree=IIF(@Degree IS NOT NULL AND @Degree!='', @Degree, Degree) AND Value=IIF(@Value IS NOT NULL AND @Value!='', @Value, Value) AND RequiredCredits=IIF(@RequiredCredits IS NOT NULL AND @RequiredCredits!='', @RequiredCredits, RequiredCredits);";
            using (SQLiteConnection connection = new SQLiteConnection(ConnectionString))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Id", Id);
                command.Parameters.AddWithValue("@Degree", Degree);
                command.Parameters.AddWithValue("@Value", Value);
                command.Parameters.AddWithValue("@RequiredCredits", RequiredCredits);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        string _degree = (string)reader["Degree"];
                        int _value = (int)reader["Value"];
                        int _requiredCredits = (int)reader["RequiredCredits"];

                        Year year = new Year(_degree, _value, _requiredCredits);
                        Years.Add(year);
                    }
            }
        }
        #endregion

        #region Messages
        private void AddMessage()
        {
            StatusMessage = "Entry added." + (!String.IsNullOrEmpty(Id) ? "\nId is set automatically." : null);
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
            StatusMessage = Years.Count > 0 ? "Search returned " + Years.Count + " lines." : "No data found";
        }
        public void AddBulkMessage()
        {
            StatusMessage = "Added " + lines + " lines." + (incorrectLines > 0 ? " Skipped " + incorrectLines + " incorrect lines." : null);
            lines = 0;
            incorrectLines = 0;
        }
        #endregion

        #region Sorting
        public void SortYears(int columnIndex)
        {
            switch (columnIndex)
            {
                case 0:
                    SortYearsById();
                    break;
                case 1:
                    SortYearsByDegree();
                    break;
                case 2:
                    SortYearsByValue();
                    break;
                case 3:
                    SortYearsByRequiredCredits();
                    break;
                default:
                    break;
            }
        }
        private void SortYearsById()
        {
            var temp = Years.OrderBy(x => x.Id).ToList<Year>();
            if (Years.SequenceEqual(temp))
                temp = Years.Reverse().ToList<Year>();
            Years = new BindingList<Year>(temp);
        }
        private void SortYearsByDegree()
        {
            var temp = Years.OrderBy(x => x.Degree).ToList<Year>();
            if (Years.SequenceEqual(temp))
                temp = Years.Reverse().ToList<Year>();
            Years = new BindingList<Year>(temp);
        }
        private void SortYearsByValue()
        {
            var temp = Years.OrderBy(x => x.Value).ToList<Year>();
            if (Years.SequenceEqual(temp))
                temp = Years.Reverse().ToList<Year>();
            Years = new BindingList<Year>(temp);
        }
        private void SortYearsByRequiredCredits()
        {
            var temp = Years.OrderBy(x => x.RequiredCredits).ToList<Year>();
            if (Years.SequenceEqual(temp))
                temp = Years.Reverse().ToList<Year>();
            Years = new BindingList<Year>(temp);
        }
        #endregion

        #region Utils
        private void LoadYearsFromDatabase()
        {
            Years = new BindingList<Year>(Year.GetYears());
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
            Degree = string.Empty;
            Value = string.Empty;
            RequiredCredits = string.Empty;
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

            var yearProperties = typeof(Year).GetProperties();

            int rowHeight = 40;
            var columnWidth = printAreaWidth / yearProperties.Length;

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
                        "Years",
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
                for (int i = 0; i < yearProperties.Length; i++)
                {
                    graphics.DrawRectangle(
                        Pens.Black,
                        currentX,
                        currentY,
                        columnWidth,
                        rowHeight);

                    graphics.DrawString(
                        yearProperties[i].Name,
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

            while (printIndex < Years.Count)
            {
                if (currentY + rowHeight > printAreaHeight)
                {
                    throw new HasMorePagesException();
                }
                currentX = marginLeft;

                #region Rows
                for (int i = 0; i < yearProperties.Length; i++)
                {
                    graphics.DrawRectangle(
                    Pens.Black,
                    currentX,
                    currentY,
                    columnWidth,
                    rowHeight);

                    stringFormat.Alignment = yearProperties[i].PropertyType == typeof(int) ? StringAlignment.Far : StringAlignment.Near;

                    graphics.DrawString(
                        yearProperties[i].GetValue(Years[printIndex]).ToString(),
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
