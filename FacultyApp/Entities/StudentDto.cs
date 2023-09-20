using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyApp.Entities
{
    public class StudentDto
    {
        public string Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Email { get; set; }
        public string Degree { get; set; }
        public int Year { get; set; }

        public const string CSV_HEADER = nameof(Id) + "," + nameof(LastName) + "," + nameof(FirstName) + "," + nameof(Email) + "," + nameof(Degree) + "," + nameof(Year);

        public StudentDto(Student student)
        {
            Id = student.Id;
            LastName = student.LastName;
            FirstName = student.FirstName;
            Email = student.Email;
            Degree = Entities.Year.ComputeDegree(student.YearId);
            Year = Entities.Year.ComputeValue(student.YearId);
        }

        public override string ToString()
        {
            return Id + "," + LastName + "," + FirstName + "," + Email + "," + Degree + "," + Year;
        }
    }
}
