using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyApp.Entities
{
    public class SubjectDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Credits { get; set; }
        public string Degree { get; set; }
        public int Year { get; set; }

        public const string CSV_HEADER = nameof(Id) + "," + nameof(Name) + "," + nameof(Credits) + "," + nameof(Degree) + "," + nameof(Year);

        public SubjectDto(Subject subject)
        {
            Id = subject.Id;
            Name = subject.Name;
            Credits = subject.Credits;
            Degree = Entities.Year.ComputeDegree(subject.YearId);
            Year = Entities.Year.ComputeValue(subject.YearId);
        }
        public override string ToString()
        {
            return Id + "," + Name + "," + Credits + "," + Degree + "," + Year;
        }
    }
}
