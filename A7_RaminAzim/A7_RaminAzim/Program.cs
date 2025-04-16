using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A7_RaminAzim
{
    /*
    Create a program that stores and manages student grades in a classroom.
    Ask the user first to see how many students the user would like to enter.
    Then ask the user of the student’s Lastname, FirstName, and grade. You will
    need to create three different arrays to store the mentioned values. You’re
    trying to come up with something like this:
    Last Name   FirstName   Grade
    King        Ryan        87
    Chan        Connie      85
    Gupta       Sanjay      95
    Rand        Annie       78
    After the user inputs the data, using a menu, you should be able to:
    a. Show Original Unsorted List
    b. Show Sorted List by Last Name (A-Z)
    c. Show Sorted List by First Name (A-Z)
    d. Show Sorted List by Grades (High-Low)
    e. Delete a student
    f. Add a student
    g. Student Average for the glass
    h. Student with Highest Grade
    i. Student with Lowest Grade
    j. Median Student(s) Grade
    k. Exit
    Couple of important things to note is that first, you should keep the original
    copy of the array entered by the user and have a copy of that array for the
    sorting portion. You need a for loop to make a copy. That way you can
    always go back and see what you started with. Secondly, as you sort
    based on one array, other corresponding arrays must be sorted in the
    same sequence. For example, if you sort by last name, the first name and
    grades also must be in the same orde
    */
    internal class Program
    {
        static string[] strFirstName;
        static string[] strLastName;
        static int[] intGrade;
        static void Main(string[] args)
        {
            Console.WriteLine("");
        }
        public static void OriginalList() 
        { 
        }
        public static void SortLast()
        {
        }
        public static void SortFirst()
        {
        }
        public static void SortGrade()
        {
        }
        public static void Delete()
        {
        }
        public static void Add()
        {
        }

        public static void Avg()
        {
        }
        public static void GradeHigh()
        {
        }
        public static void GradeLow()
        {
        }
        public static void Median()
        {
        }
    }
}
