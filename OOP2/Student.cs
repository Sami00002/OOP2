using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Student
    { //INDEXATOR!!!!
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public DateTime BirthDate
        {
            get;
            set;
        }
        public string NumarMatricol
        {
            get;
            set;
        }

        public Student(string FirstName, string LastName, DateTime BirthDate, string NumarMatricol)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.BirthDate = BirthDate;
            this.NumarMatricol = NumarMatricol;
        }
    }
}
