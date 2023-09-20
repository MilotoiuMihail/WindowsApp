using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyApp.Entities
{
    public class GradeDto
    {
        public string SubjectName { get; set; }
        public int Credits { get; set; }
        public float Grade { get; set; }
        public DateTime Date { get; set; }
        public const string CSV_HEADER = nameof(SubjectName) + "," + nameof(Credits) + "," + nameof(Grade) + "," + nameof(Date);
        public GradeDto(Grade grade)
        {
            Subject subject = Subject.GetSubjects().Where(x => x.Id == grade.SubjectId).First();
            SubjectName = subject.Name;
            Credits = subject.Credits;
            Grade = grade.Value;
            Date = grade.Date;
        }
        public override string ToString()
        {
            return SubjectName + "," + Credits.ToString() + "," + Grade.ToString() + "," + Date.ToShortDateString();
        }
    }
}
