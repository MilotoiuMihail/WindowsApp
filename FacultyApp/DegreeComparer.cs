using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacultyApp
{
    internal class DegreeComparer : Comparer<string>
    {
        public override int Compare(string x, string y)
        {
            int a = (int)Enum.Parse(typeof(DegreeEnum), x);
            int b = (int)Enum.Parse(typeof(DegreeEnum), y);
            return a.CompareTo(b);
        }
    }
}
