using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyApp.CustomExceptions
{
    public class StudentIdException : Exception
    {
        public string Id { get; set; }
        public StudentIdException(string id)
        {
            Id = id;
        }

        public override string Message => "Invalid CNP: " + Id;
    }
}
