using FacultyApp.CustomExceptions;
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
    internal class LoginFormViewModel : INotifyPropertyChanged
    {

        #region Username
        private string _username;
        public string Username
        {
            get { return _username; }
            set
            {
                if (_username == value)
                    return;
                _username = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Password
        private string _password;
        public string Password
        {
            get { return _password; }
            set
            {
                if (_password == value)
                    return;
                _password = value;
                OnPropertyChanged();
            }
        }
        #endregion

        public LoginFormViewModel()
        {
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion

        public void ValidateUser()
        {
            string query = "SELECT * FROM (SELECT Username FROM Admins UNION SELECT Email AS Username FROM Students) WHERE Username=@Username;";
            using (SQLiteConnection connection = new SQLiteConnection(Properties.Settings.Default.Database))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Username", Username);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                        throw new LoginException("Username does not exist");
                    string username = (string)reader["Username"];
                }
            }
        }
        public Student GetStudent()
        {
            string query = "SELECT * FROM Students WHERE Email=@Username AND Password=@Password;";
            using (SQLiteConnection connection = new SQLiteConnection(Properties.Settings.Default.Database))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", Password);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                        return null;
                    string id = (string)reader["Id"];
                    string lastName = (string)reader["LastName"];
                    string firstName = (string)reader["FirstName"];
                    int yearId = (int)reader["YearId"];

                    Student student = new Student(id, lastName, firstName, yearId);
                    student.Password = Password;
                    return student;
                }

            }
        }
        public void ValidatePassword()
        {
            string query = "SELECT * FROM (SELECT Username, Password FROM Admins UNION SELECT Email AS Username, Password FROM Students) WHERE Username=@Username AND Password=@Password;";
            using (SQLiteConnection connection = new SQLiteConnection(Properties.Settings.Default.Database))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Username", Username);
                command.Parameters.AddWithValue("@Password", Password);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                        throw new LoginException("Incorrect Password");
                    string username = (string)reader["Username"];
                    string password = (string)reader["Password"];
                }
            }
        }

        public bool IsAdmin()
        {
            string query = "SELECT Username FROM Admins WHERE Username=@Username;";
            using (SQLiteConnection connection = new SQLiteConnection(Properties.Settings.Default.Database))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                command.Parameters.AddWithValue("@Username", Username);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                {
                    if (!reader.Read())
                        return false;
                    string username = (string)reader["Username"];
                    if (string.IsNullOrEmpty(username))
                        return false;
                }
            }
            return true;
        }
    }
}
