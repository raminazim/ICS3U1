using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        static string[] strFirstNameOG;
        static string[] strLastNameOG;
        static int[] intGradeOG;
        static void Main(string[] args)
        {
            int intInputNum;

            //Asking For How Many Students For OG List
            Console.WriteLine("How Many Students Entering");
            intInputNum = Int32.Parse(Console.ReadLine());
            string strInput;

            //Getting OG List
            for (int i = 0; i < intInputNum; i++)
            {
                Console.WriteLine("Enter First Name " + i + ": ");
                strFirstName[i] = Console.ReadLine();

                Console.WriteLine("Enter Last Name " + i + ": ");
                strLastName[i] = Console.ReadLine();

                Console.WriteLine("Enter Grade " + i + ": ");
                intGrade[i] = Int32.Parse(Console.ReadLine());
            }

            //Copying OG List To Perma Copy
            for (int i = 0; i < intInputNum; i++)
            {
                strFirstNameOG[i] = strFirstName[i];

                strLastNameOG[i] = strLastName[i];

                intGradeOG[i] = intGrade[i];
            }

            //Asking User What To Do To List
            Console.WriteLine("1: Show Original Unsorted List");
            Console.WriteLine("2: Show Sorted List by Last Name(A-Z)");
            Console.WriteLine("3: Show Sorted List by First Name(A-Z)");
            Console.WriteLine("4: Show Sorted List by Grades(High - Low)");
            Console.WriteLine("5: Delete a student");
            Console.WriteLine("6: Add a student");
            Console.WriteLine("7: Student Average for the glass");
            Console.WriteLine("8: Student with Highest Grade");
            Console.WriteLine("9: Student with Lowest Grade");
            Console.WriteLine("10: Median Student(s) Grade");
            Console.WriteLine("Any Other Input: Exit");
            
            strInput = Console.ReadLine();

            while (true)
            {
                if (strInput == "1")
                {
                    OriginalList();
                }
                else if (strInput == "2")
                {
                    SortLast();
                }
                else if (strInput == "3")
                {
                    SortFirst();
                }
                else if (strInput == "4")
                {
                    SortGrade();
                }
                else if (strInput == "5")
                {
                    Delete();
                }
                else if (strInput == "6")
                {
                    Add();
                }
                else if (strInput == "7")
                {
                    Avg();
                }
                else if (strInput == "8")
                {
                    GradeHigh();
                }
                else if (strInput == "9")
                {
                    GradeLow();
                }
                else if (strInput == "10")
                {
                    Median();
                }
                else
                {
                    Environment.Exit(0);
                }

                Console.ReadKey();
            }
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
