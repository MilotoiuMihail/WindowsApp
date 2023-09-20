using FacultyApp.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyApp.Entities
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public int YearId { get; set; }
        public static int MAX_ID = 999;
        public const int MAX_CREDITS = 10;
        public const int MIN_CREDITS = 0;
        public Subject(SubjectDto subject) : this(subject.Id, subject.Name, subject.Credits, Year.ComputeId(subject.Degree, subject.Year))
        {

        }
        public Subject(int id, string name, int credits, int yearId)
        {
            Id = id;
            Name = name;
            Credits = credits;
            YearId = yearId;
        }
        public static void ValidateName(string name)
        {
            if (name.Length < 3)
                throw new NameException("Name is too short");
            foreach (char c in name)
            {
                if (!char.IsLetterOrDigit(c) && c != ' ' && c != '-' && c != '.')
                    throw new NameException("Invalid Name");
            }
        }
        public static void ValidateCredits(string credits)
        {
            if (Int32.TryParse(credits, out int _credits))
                if (_credits >= MIN_CREDITS && _credits <= MAX_CREDITS)
                    return;
            throw new FormatException();
        }
        public static void ValidateId(string id)
        {
            if (Int32.TryParse(id, out int _id))
                if (_id >= 0 && _id <= MAX_ID)
                    return;
            throw new FormatException();
        }
        public static List<Subject> GetSubjects()
        {
            List<Subject> subjects = new List<Subject>();
            string query = "SELECT * FROM Subjects;";
            using (SQLiteConnection connection = new SQLiteConnection(Properties.Settings.Default.Database))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        int id = (int)reader["Id"];
                        string name = (string)reader["Name"];
                        int credits = (int)reader["Credits"];
                        int yearId = (int)reader["YearId"];

                        Subject subject = new Subject(id, name, credits, yearId);
                        subjects.Add(subject);
                    }
                return subjects;
            }
        }
        public static int GetSubjectId(string name)
        {
            Subject subject = GetSubjects().Where(x => x.Name == name).FirstOrDefault();
            return subject != null ? subject.Id : MAX_ID + 1;
        }
    }
}
