using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyApp.Entities
{
    public class Grade
    {
        public string Id { get; set; }
        public float Value { get; set; }
        public DateTime Date { get; set; }
        public int SubjectId { get; set; }
        public string StudentId { get; set; }

        public Grade(float value, int subjectId, string studentId)
        {
            Id = ComputeId(subjectId, studentId);
            Value = value;
            Date = DateTime.Now.Date;
            SubjectId = subjectId;
            StudentId = studentId;
        }
        public Grade(float value, DateTime date, int subjectId, string studentId)
        {
            Id = ComputeId(subjectId, studentId);
            Value = value;
            Date = date;
            SubjectId = subjectId;
            StudentId = studentId;
        }
        public Grade(GradeDto grade, string studentId)
        {
            Value = grade.Grade;
            Date = grade.Date;
            SubjectId = Subject.GetSubjectId(grade.SubjectName);
            StudentId = studentId;
            Id = ComputeId(SubjectId, studentId);
        }

        private static string ComputeId(int subjectId, string studentId)
        {
            return subjectId.ToString() + studentId;
        }
        public static void ValidateValue(string value)
        {
            if (Int32.TryParse(value, out int _value))
                if (_value >= 0 && _value <= 10)
                    return;
            throw new FormatException();
        }
    }
}
