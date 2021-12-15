using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Student
    {
        public string FirstName;
        public string LastName;
        public DateTime BirthDate;
        public string NumarMatricol;
        
        public Student(string FirstName, string LastName, DateTime BirthDate, string NumarMatricol)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
            this.NumarMatricol = NumarMatricol;
        }
    }
}
