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

        static int intStudentCount;
        static void Main(string[] args)
        {
            string strInput;

            //Asking For How Many Students For OG List
            Console.WriteLine("How Many Students Entering");
            intStudentCount = Int32.Parse(Console.ReadLine());

            //Getting Size
            strFirstName = new string[intStudentCount];
            strLastName = new string[intStudentCount];
            intGrade = new int[intStudentCount];

            strFirstNameOG = new string[intStudentCount];
            strLastNameOG = new string[intStudentCount];
            intGradeOG = new int[intStudentCount];

            //Getting OG List
            for (int i = 0; i < intStudentCount; i++)
            {
                Console.WriteLine("Enter First Name " + i + ": ");
                strFirstName[i] = Console.ReadLine();

                Console.WriteLine("Enter Last Name " + i + ": ");
                strLastName[i] = Console.ReadLine();

                Console.WriteLine("Enter Grade " + i + ": ");
                intGrade[i] = Int32.Parse(Console.ReadLine());
            }

            //Copying OG List To Perma Copy
            for (int i = 0; i < intStudentCount; i++)
            {
                strFirstNameOG[i] = strFirstName[i];

                strLastNameOG[i] = strLastName[i];

                intGradeOG[i] = intGrade[i];
            }
            
            //Asking User What To Do To List
            while (true)
            {
                Console.WriteLine("\n1: Show Original Unsorted List");
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
                else if (strInput == "10" || strInput == "0") //muscle memory rules 
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
            Console.WriteLine("\nOriginal List:");
            Console.WriteLine("Last Name\tFirst Name\tGrade");

            for (int i = 0; i < intStudentCount; i++)
            {
                Console.WriteLine(strLastNameOG[i] + "\t\t" + strFirstNameOG[i] + "\t\t" + intGradeOG[i]);
            }

            Console.WriteLine("\n Press Enter To Continue");
        }
        public static void SortLast()
        {
            string tempFirstName;
            string tempLastName;
            int tempGrade;

            for (int i = 0; i < intStudentCount - 1; i++)
            {
                for (int j = 0; j < intStudentCount - i - 1; j++)
                {
                    //Compares
                    if (String.Compare(strLastName[j], strLastName[j + 1]) > 0)
                    {
                        //Swap
                        tempLastName = strLastName[j];
                        strLastName[j] = strLastName[j + 1];
                        strLastName[j + 1] = tempLastName;

                        //Swap others for consistency
                        tempFirstName = strFirstName[j];
                        strFirstName[j] = strFirstName[j + 1];
                        strFirstName[j + 1] = tempFirstName;

                        tempGrade = intGrade[j];
                        intGrade[j] = intGrade[j + 1];
                        intGrade[j + 1] = tempGrade;
                    }
                }
            }

            Console.WriteLine("\nSorted by Last Name):");
            Console.WriteLine("Last Name\tFirst Name\tGrade");
            for (int i = 0; i < intStudentCount; i++)
            {
                Console.WriteLine(strLastName[i] + "\t\t" + strFirstName[i] + "\t\t" + intGrade[i]);
            }
            
            Console.WriteLine("\n Press Enter To Continue");
        }
        public static void SortFirst()
        {
            string tempFirstName;
            string tempLastName;
            int tempGrade;

            for (int i = 0; i < intStudentCount - 1; i++)
            {
                for (int j = 0; j < intStudentCount - i - 1; j++)
                {
                    //Compares
                    if (String.Compare(strFirstName[j], strFirstName[j + 1]) > 0)
                    {
                        //Swap
                        tempFirstName = strFirstName[j];
                        strFirstName[j] = strFirstName[j + 1];
                        strFirstName[j + 1] = tempFirstName;

                        //Swap others for consistency
                        tempLastName = strLastName[j];
                        strLastName[j] = strLastName[j + 1];
                        strLastName[j + 1] = tempLastName;

                        tempGrade = intGrade[j];
                        intGrade[j] = intGrade[j + 1];
                        intGrade[j + 1] = tempGrade;
                    }
                }
            }

            Console.WriteLine("\nSorted by First Name:");
            Console.WriteLine("Last Name\tFirst Name\tGrade");
            for (int i = 0; i < intStudentCount; i++)
            {
                Console.WriteLine(strLastName[i] + "\t\t" + strFirstName[i] + "\t\t" + intGrade[i]);
            }

            Console.WriteLine("\n Press Enter To Continue");
        }
        public static void SortGrade()
        {
            string tempFirstName;
            string tempLastName;
            int tempGrade;

            for (int i = 0; i < intStudentCount - 1; i++)
            {
                for (int j = 0; j < intStudentCount - i - 1; j++)
                {
                    //Compares
                    if (intGrade[j].CompareTo(intGrade[j + 1]) < 0)
                    {
                        //Swap
                        tempGrade = intGrade[j];
                        intGrade[j] = intGrade[j + 1];
                        intGrade[j + 1] = tempGrade;

                        //Swap for consistency
                        tempFirstName = strFirstName[j];
                        strFirstName[j] = strFirstName[j + 1];
                        strFirstName[j + 1] = tempFirstName;

                        tempLastName = strLastName[j];
                        strLastName[j] = strLastName[j + 1];
                        strLastName[j + 1] = tempLastName;
                    }
                }
            }

            Console.WriteLine("\nSorted by Grade: ");
            Console.WriteLine("Last Name\tFirst Name\tGrade");
            for (int i = 0; i < intStudentCount; i++)
            {
                Console.WriteLine(strLastName[i] + "\t\t" + strFirstName[i] + "\t\t" + intGrade[i]);
            }

            Console.WriteLine("\n Press Enter To Continue");
        }
        public static void Delete()
        {
        }
        public static void Add()
        {
        }

        public static void Avg()
        {
            int intTotal = 0;
            int intAvg = 0;

            for (int i = 0;i < intStudentCount;i++)
            {
                intTotal = intTotal + intGrade[i];
            }

            intAvg = intTotal / intStudentCount;

            Console.WriteLine("Average: " + intAvg);
            
            Console.WriteLine("\n Press Enter To Continue");
        }
        public static void GradeHigh()
        {
            string tempFirstName;
            string tempLastName;
            int tempGrade;

            for (int i = 0; i < intStudentCount - 1; i++)
            {
                for (int j = 0; j < intStudentCount - i - 1; j++)
                {
                    if (intGrade[j].CompareTo(intGrade[j + 1]) < 0)
                    {
                        tempGrade = intGrade[j];
                        intGrade[j] = intGrade[j + 1];
                        intGrade[j + 1] = tempGrade;

                        tempFirstName = strFirstName[j];
                        strFirstName[j] = strFirstName[j + 1];
                        strFirstName[j + 1] = tempFirstName;

                        tempLastName = strLastName[j];
                        strLastName[j] = strLastName[j + 1];
                        strLastName[j + 1] = tempLastName;
                    }
                }
            }

            Console.WriteLine("\nHighest Grade:");
            Console.WriteLine("Last Name\tFirst Name\tGrade");
            Console.WriteLine(strLastName[0] + "\t\t" + strFirstName[0] + "\t\t" + intGrade[0]);

            Console.WriteLine("\n Press Enter To Continue");
        }
        public static void GradeLow()
        {
            string tempFirstName;
            string tempLastName;
            int tempGrade;

            for (int i = 0; i < intStudentCount - 1; i++)
            {
                for (int j = 0; j < intStudentCount - i - 1; j++)
                {
                    if (intGrade[j].CompareTo(intGrade[j + 1]) > 0)
                    {
                        tempGrade = intGrade[j];
                        intGrade[j] = intGrade[j + 1];
                        intGrade[j + 1] = tempGrade;

                        tempFirstName = strFirstName[j];
                        strFirstName[j] = strFirstName[j + 1];
                        strFirstName[j + 1] = tempFirstName;

                        tempLastName = strLastName[j];
                        strLastName[j] = strLastName[j + 1];
                        strLastName[j + 1] = tempLastName;
                    }
                }
            }

            Console.WriteLine("\nLowest Grade:");
            Console.WriteLine("Last Name\tFirst Name\tGrade");
            Console.WriteLine(strLastName[0] + "\t\t" + strFirstName[0] + "\t\t" + intGrade[0]);

            Console.WriteLine("\n Press Enter To Continue");
        }
        public static void Median()
        {
            string tempFirstName;
            string tempLastName;
            int tempGrade;
            int intMid = intStudentCount/2;

            for (int i = 0; i < intStudentCount - 1; i++)
            {
                for (int j = 0; j < intStudentCount - i - 1; j++)
                {
                    if (intGrade[j].CompareTo(intGrade[j + 1]) > 0)
                    {
                        tempGrade = intGrade[j];
                        intGrade[j] = intGrade[j + 1];
                        intGrade[j + 1] = tempGrade;

                        tempFirstName = strFirstName[j];
                        strFirstName[j] = strFirstName[j + 1];
                        strFirstName[j + 1] = tempFirstName;

                        tempLastName = strLastName[j];
                        strLastName[j] = strLastName[j + 1];
                        strLastName[j + 1] = tempLastName;
                    }
                }
            }

            Console.WriteLine("\nMedian Grade:");
            Console.WriteLine("Last Name\tFirst Name\tGrade");
            Console.WriteLine(strLastName[intMid] + "\t\t" + strFirstName[intMid] + "\t\t" + intGrade[intMid]);

            Console.WriteLine("\n Press Enter To Continue");
        }
    }
}
