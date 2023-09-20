using FacultyApp.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyApp.Entities
{
    public class Student
    {
        public string Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int YearId { get; set; }
        private static string CNP_CONSTANT = "279146358279";
        public Student(StudentDto student) : this(student.Id, student.LastName, student.FirstName, Year.ComputeId(student.Degree, student.Year))
        { }
        public Student(string id, string lastName, string firstName, int yearId)
        {
            Id = id;
            LastName = lastName;
            FirstName = firstName;
            Email = GenerateEmail(lastName, firstName, id);
            Password = GenerateRandomPassword(10);
            YearId = yearId;
        }
        private static string GenerateRandomPassword(int length)
        {
            const string chars = "0123456789abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";

            StringBuilder sb = new StringBuilder();
            Random rnd = new Random();

            for (int i = 0; i < length; i++)
            {
                int index = rnd.Next(chars.Length);
                sb.Append(chars[index]);
            }

            return sb.ToString();
        }
        private static string GenerateEmail(string lastName, string firstName, string id)
        {
            return lastName + firstName + id[11] + id[12] + "@stud.ase.ro";
        }
        public static void ValidateId(string id)
        {
            if (id.Length != 13)
                throw new StudentIdException(id);
            long.TryParse(id, out long temp);
            int sum = 0;
            for (int i = 0; i < 12; i++)
            {
                sum += (id[i] - '0') * (CNP_CONSTANT[i] - '0');
            }
            int c = sum % 11 == 10 ? 1 : sum % 11;
            if (c != (id[12] - '0'))
                throw new StudentIdException(id);
        }
        public static void ValidateEmail(string email, string lastName, string firstName, string id)
        {
            if (email != GenerateEmail(lastName, firstName, id))
                throw new EmailException();
        }
        public static void ValidateName(string name)
        {
            if (name.Length < 3)
                throw new NameException("Name is too short");
            foreach (char c in name)
            {
                if (!char.IsLetter(c) && c != ' ' && c != '-' && c != '.')
                    throw new NameException("Invalid Name");
            }
        }
    }
}
