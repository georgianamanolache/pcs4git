using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pcs4_demo_week3_all_types_sorting
{
    public partial class Form1 : Form
    {
        List<Student> students;

   
        public Form1()
        {
            InitializeComponent();

            //Initialzie list students with random data.
            initialzieListStudent();

            //Add items to listbox from list students.
            displayListStudent();
        }

        /// <summary>
        /// Initialzie list students with random data.
        /// </summary>
        private void initialzieListStudent()
        {
            students = new List<Student>
            {
                new Student(12345, "John", "Doe", 8.5),
                new Student(12346, "Anne", "Smith", 7.8),
                new Student(12645, "Noah", "Johnson", 8.5),
                new Student(42345, "James", "Williams", 9.1),
                new Student(42367, "Benjamin", "Brown", 9.1),
                new Student(82345, "Oliver", "Jones", 6.3),
                new Student(82367, "Jacob", "Davis", 7.0),
                new Student(12395, "Amelia", "Miller", 6.1),
                new Student(82346, "Abigail", "Wilson", 6.1),
            };
        }

        /// <summary>
        /// Add items to listbox from list students.
        /// </summary>
        private void displayListStudent()
        {
            listBox1.Items.Clear();

            foreach (Student student in students)
            {
                listBox1.Items.Add(student);
            }
        }

        /// <summary>
        /// Sort by student number with IComparable.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortByStudentNumber_Click(object sender, EventArgs e)
        {
            initialzieListStudent();
            students.Sort();
            displayListStudent();
        }

        /// <summary>
        /// Sort by first name with selection sort algorithm.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStortByFirstName_Click(object sender, EventArgs e)
        {
            initialzieListStudent();
            SortByFirstName();
            displayListStudent();
        }

        /// <summary>
        /// Sort by last name with delegate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortByLastName_Click(object sender, EventArgs e)
        {
            initialzieListStudent();
            students.Sort(this.compareByLastName);
            displayListStudent();
        }

        /// <summary>
        /// Sort by grade with delegate
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSortByGrade_Click(object sender, EventArgs e)
        {
            initialzieListStudent();
            students.Sort(this.compareByGrade);
            displayListStudent();
        }

        /// <summary>
        /// Sort by first name with selection algorithm
        /// </summary>
        private void SortByFirstName()
        {
            Student[] arr = students.ToArray();

            int smallest, n = students.Count;
            Student temp;
            for (int i = 0; i < n - 1; i++)
            {
                smallest = i;
                for (int j = i + 1; j < n; j++)
                {
                    int x = String.Compare(arr[j].FirstName, arr[smallest].FirstName);
                    if (x == -1)
                        smallest = j;

                }
                temp = arr[smallest];
                arr[smallest] = arr[i];
                arr[i] = temp;
            }

            students = new List<Student>();
            foreach (Student student in arr)
            {
                students.Add(student);
            }
        }

        private int compareByLastName(object objA, object objB)
        {
            Student studentA = (Student)objA;
            Student studentB = (Student)objB;
            return String.Compare(studentA.LastName, studentB.LastName);
        }

        private int compareByGrade(Student studentA, Student studentB)
        {
            if (studentA.Grade == studentB.Grade) { return 0; }
            else if (studentA.Grade < studentB.Grade) { return -1; }
            return 1;
        }
        
    }
}
