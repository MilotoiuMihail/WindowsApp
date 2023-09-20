using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyApp.Entities
{
    [Serializable]
    public class Year
    {
        public int Id { get; set; }
        public string Degree { get; set; }
        public int Value { get; set; }
        public int RequiredCredits { get; set; }

        [NonSerialized]
        public const string CSV_HEADER = nameof(Id) + "," + nameof(Degree) + "," + nameof(Value) + "," + nameof(RequiredCredits);
        [NonSerialized]
        public const int MAX_VALUE = 9;
        [NonSerialized]
        public const int MIN_VALUE = 1;
        [NonSerialized]
        public const int MAX_REQUIRED_CREDITS = 200;
        [NonSerialized]
        public const int MIN_REQUIRED_CREDITS = 0;

        public Year()
        {

        }
        public Year(string degree, int value, int requiredCredits)
        {
            Id = ComputeId(degree, value);
            Degree = degree;
            Value = value;
            RequiredCredits = requiredCredits;
        }

        public override string ToString()
        {
            return Id + "," + Degree + "," + Value + "," + RequiredCredits;
        }
        public static int ComputeId(string degree, int value)
        {
            if (Enum.TryParse(degree, out DegreeEnum _degree))
                return (int)_degree * 10 + value;
            return Enum.GetNames(typeof(DegreeEnum)).Length + 1;
        }
        public static string ComputeDegree(int id)
        {
            return Enum.GetName(typeof(DegreeEnum), id / 10);
        }
        public static int ComputeValue(int id)
        {
            return id % 10;
        }
        public static List<Year> GetYears()
        {
            List<Year> years = new List<Year>();
            string query = "SELECT * FROM Years;";
            using (SQLiteConnection connection = new SQLiteConnection(Properties.Settings.Default.Database))
            {
                SQLiteCommand command = new SQLiteCommand(query, connection);
                connection.Open();
                using (SQLiteDataReader reader = command.ExecuteReader())
                    while (reader.Read())
                    {
                        string degree = (string)reader["Degree"];
                        int value = (int)reader["Value"];
                        int requiredCredits = (int)reader["RequiredCredits"];

                        Year year = new Year(degree, value, requiredCredits);
                        years.Add(year);
                    }
                return years;
            }
        }

        #region Validations
        public static void ValidateId(string id, string degree, string value)
        {
            int _id = (int)Enum.Parse(typeof(DegreeEnum), degree) * 10 + Int32.Parse(value);
            if (id != _id.ToString())
                throw new FormatException();
        }
        public static void ValidateDegree(string degree)
        {
            if (!Enum.TryParse(degree, out DegreeEnum _degree))
                throw new FormatException();
        }
        public static void ValidateValue(string value)
        {
            if (Int32.TryParse(value, out int _value))
                if (_value >= MIN_VALUE && _value <= MAX_VALUE)
                    return;
            throw new FormatException();
        }
        public static void ValidateRequiredCredits(string requiredCredits)
        {
            if (Int32.TryParse(requiredCredits, out int _requiredCredits))
                if (_requiredCredits >= MIN_REQUIRED_CREDITS && _requiredCredits <= MAX_REQUIRED_CREDITS)
                    return;
            throw new FormatException();
        }
        #endregion
    }
}
