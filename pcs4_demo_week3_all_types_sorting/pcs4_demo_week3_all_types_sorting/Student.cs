using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pcs4_demo_week3_all_types_sorting
{
    class Student : IComparable
    {
        public int StudentNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        public Student(int studentNumber, string firstName, string lastName, double grade)
        {
            StudentNumber = studentNumber;
            FirstName = firstName;
            LastName = lastName;
            Grade = grade;
        }

        /// <summary>
        /// Use CompareTo interface to sort ascending by Studentnumber
        /// </summary>
        /// <param name="otherObj"></param>
        /// <returns></returns>
        public int CompareTo(object otherObj)
        {
            Student other = (Student)otherObj;
            if (this.StudentNumber == other.StudentNumber) { return 0; }
            else if (this.StudentNumber < other.StudentNumber) { return -1; }
            else { return 1; }
        }

        public override string ToString()
        {
            return StudentNumber + " " + FirstName + " "+ LastName + " "+ Grade;
        }
    }
}
