using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Facultate
    {
        public string FacultyName;
        public Student[] Students;
        public Facultate(string FacultyName)
        {
            this.FacultyName = FacultyName;
        }

        public string Index(string NumarMatricol)
        {
            for (int i = 0; i < Students.Length; i++)
            {
                if (string.Equals(NumarMatricol, Students[i].NumarMatricol))
                {
                    string s = Students[i].FirstName + " " + Students[i].LastName;
                    return s;
                }
            }
            return "Student not found! ";
        }
        
    }
}
