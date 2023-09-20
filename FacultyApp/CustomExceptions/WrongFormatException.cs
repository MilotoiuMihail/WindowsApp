using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyApp.CustomExceptions
{
    internal class WrongFormatException : Exception
    {
        public string FileName { get; set; }
        public WrongFormatException(string fileName)
        {
            FileName = fileName;
        }
        public override string Message => FileName + " has wrong format.";
    }
}
