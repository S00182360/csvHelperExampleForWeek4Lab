using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week4.Console
{
    class Student
    {
        public string StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }

        public override string ToString()
        {
            return FirstName + " " + Surname + "\tStudent Number: " + StudentNumber;
        }
    }
}
