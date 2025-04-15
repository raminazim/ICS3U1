/*
/ Name: Ramin
/ Date: 04/14/25
/ Ttile: Assignment 6
/ Purpose: Menu driven app displaying work using arrays
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A6_RaminAzim

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("ASSIGNMENT 6");

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Menu(); 
                string strUsr;

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Choose Option: ");
                strUsr = Console.ReadLine();

                if (strUsr == "1")
                {
                    Q1RandStats();
                }
                else if (strUsr == "2")
                {
                    Q2GradeMngr();
                }
                else if (strUsr == "3")
                {
                    Q3DeckMngr();
                }
                else if (strUsr == "4")
                {
                    Q4ClassMngr();
                }
 	            else
                {
                    Environment.Exit(0);
                }
            Console.ReadKey();


            Console.ReadKey();
        }

        public static void Menu()
        {
            Console.WriteLine("1 - Number Generator");
            Console.WriteLine("2 - Grade Manager");
            Console.WriteLine("3 -  Deck Manager");
            Console.WriteLine("4 - Class Manager");
            Console.WriteLine("Any Other Input - Exit");
        }

        public static void Q1RandStats()
        {
            while (true)
            {
                //Declaration
                int intNum, intRnd, intUser = 0;
                Random Rnd = new Random();
                int[] intOccur;
                int[] intCount = new int[9];
                string strUsr;

                //Input
                while(true)
                {
                    Console.WriteLine("Enter Number: ");
                    strUsr = Console.ReadLine();
                    intNum = Int32.Parse(strUsr);

                    //Processing
                    intOccur = new int[intNum];
                    for (int i = 0; i < intNum; i++) //randomly generates numbers for each index of array
                    {
                        intRnd = Rnd.Next(1, 10);
                        intOccur[i] = intRnd;
                        intCount[intRnd - 1]++;
                    } 

                    //Output
                    Console.WriteLine("Number: ----- Times Shown"); //outputs numbers
                    for (int i = 0; i < intCount.Length; i++)
                    {
                        Console.WriteLine((i + 1) + " ---------- " + intCount[i]);
                    }

                    Console.WriteLine("1. New Set");
                    Console.WriteLine("2. Exit");
                    intUser = Int32.Parse(Console.ReadLine());
                    if (intUser == 2)
                    {
                        break;
                    }
                    else if (intUser == 1) //runs again cuz in while loop
                    {
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Invalid Input");
                    }
                }
            }
        }

        // Q2: Grade Manager
        public static void Q2GradeMngr()
        {
            //Declaration
            string strUsr;
            const int intMax = 15;
            const int intMin = 5;
            int[] intGrades = new int[intMax];
            int[] intSizedGrades;
            int intGrade, intChangedGrade = 0, intSelect = 0, intNumOfValues = 0;
            int intTotal = 0, intAvg = 0;
            int intDelete = 0, intChange = 0;

            //Input
            for (int i = 0; i < 15; i++) //asks for number for array
            {
                Console.WriteLine("Grade: ");
                strUsr = Console.ReadLine();
                intGrade = Int32.Parse(strUsr);
                intGrades[i] = intGrade;
                if (i < intMin && intGrade == -99)
                {
                    Console.WriteLine("Min 5 Grades");
                    Console.Clear();
                }
                if (i > 5 && intGrade == -99)
                {
                    break;
                }
                intNumOfValues++;
            }

            //Processing
            intSizedGrades = new int[intNumOfValues]; //copies values of array excluding -99
            int x = 0;
            for (int i = 0; i < intGrades.Length; i++)
            {
                if (intGrades[i] == -99)
                {
                    break;
                }
                intSizedGrades[x] = intGrades[i];
                x++;
            }

            //Processing/Output
            while (true)
            {
                Console.WriteLine("1. Number of Grades");
                Console.WriteLine("2.List Grades");
                Console.WriteLine("3. Avg");
                Console.WriteLine("4. Delete");
                Console.WriteLine("5. Change Grade");
                Console.WriteLine("6. Add Grade");
                Console.WriteLine("7. Exit");
                strUsr = Console.ReadLine();
                intSelect = Int32.Parse(strUsr);

                if (intSelect == 1) //displays how many there are
                {
                    Console.WriteLine("There are " + intSizedGrades.Length + " values");
                }
                else if (intSelect == 2) //lists
                {
                    Console.WriteLine("Grades: ");
                    for (int i = 0; i < intSizedGrades.Length; i++)
                    {
                        Console.WriteLine(intSizedGrades[i]);
                    }
                }
                else if (intSelect == 3) //makes a total and divides by index lengh
                {
                    intTotal = 0;
                    for (int i = 0; i < intSizedGrades.Length; i++)
                    {
                        intTotal += intSizedGrades[i];
                    }
                    intAvg = intTotal / intSizedGrades.Length;
                    Console.WriteLine("Average: " + intAvg);
                }
                else if (intSelect == 4) //puts all grades except chosen grade into new one, reset it and then put it back in
                {
                    Console.WriteLine("Index of Grade: ");
                    for (int i = 0; i < intSizedGrades.Length; i++)
                    {
                        Console.WriteLine(i + " : " + intSizedGrades[i]);
                    }
                    Console.Write("Select grade to delete: ");
                    strUsr = Console.ReadLine("");
                    intDelete = Int32.Parse(strUsr);

                    int[] intTemp = new int[intSizedGrades.Length - 1];
                    for (int i = 0; i < intDelete; i++)
                    {
                        intTemp[i] = intSizedGrades[i];
                    }
                    for (int i = intDelete + 1; i < intSizedGrades.Length; i++)
                    {
                        intTemp[i - 1] = intSizedGrades[i];
                    }
                    intSizedGrades = intTemp;

                    Console.WriteLine("Updated Grades: ");
                    for (int i = 0; i < intSizedGrades.Length; i++)
                    {
                        Console.WriteLine(intSizedGrades[i]);
                    }
                }
                else if (intSelect == 5)
                {
                    for (int i = 0; i < intSizedGrades.Length; i++) //asks user for index  of grade and new grade and changes it
                    {
                        Console.WriteLine(i + " : " + intSizedGrades[i]);
                    }
                    Console.Write("Select Grade [Index]: ");
                    intChange = Int32.Parse(Console.ReadLine());
                    Console.Write("New Grade: ");
                    intChangedGrade = Int32.Parse(Console.ReadLine());
                    intSizedGrades[intChange] = intChangedGrade;
                }
                else if (intSelect == 6) 
                {
                    intTemp = new int[intSizedGrades.Length + 1];
                    for (int i = 0; i < intSizedGrades.Length; i++)
                    {
                        intTemp[i] = intSizedGrades[i];
                    }
                    Console.WriteLine("Enter grade to add: ");
                    strUsr = Console.ReadLine();
                    intTemp[intTemp.Length - 1] = Int32.Parse(strUsr);
                    intSizedGrades = intTemp;
                }
                else if (intSelect == 7)
                {
                    return;
                }
                Console.ReadKey();
                Console.Clear();
            }
        }

        // Q3: Card Deck Manager
        public static void Q3CDeckMngr()
        {
            //Declaration
            string[] strRank = { "A", "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string[] strSymbol = { "Hearts", "Diamonds", "Spades", "Clubs" };
            string[] strDeck = new string[strRank.Length * strSymbol.Length];
            int intIndex = 0;
            int intSelect = 0;

            for (int i = 0; i < strSymbol.Length; i++)
            {
                for (int j = 0; j < strRank.Length; j++)
                {
                    strDeck[intIndex] = strRank[j] + " of " + strSymbol[i];
                    intIndex++;
                }
            }

            while (true)
            {
                //Input
                Console.WriteLine("1. Show current deck");
                Console.WriteLine("2. Shuffle Deck");
                Console.WriteLine("3. Reset Deck");
                Console.WriteLine("4. Exit");
                intSelect = Int32.Parse(Console.ReadLine());

                if (intSelect == 1)
                {
                    // Output
                    for (int i = 0; i < strDeck.Length; i++)
                    {
                        Console.WriteLine(strDeck[i]);
                    }
                }
                else if (intSelect == 2)
                {
                    //Processing
                    Random rnd = new Random();
                    for (int i = strDeck.Length - 1; i > 0; i--)
                    {
                        int j = rnd.Next(i + 1); //random index between 0 and i
                        string temp = strDeck[i];
                        strDeck[i] = strDeck[j];
                        strDeck[j] = temp;
                    }

                    Console.WriteLine("Shuffled");
                }
                else if (intSelect == 3)
                {
                    //Processing
                    intIndex = 0;
                    for (int i = 0; i < strSymbol.Length; i++)
                    {
                        for (int j = 0; j < strRank.Length; j++)
                        {
                            strDeck[intIndex] = strRank[j] + " of " + strSymbol[i];
                            intIndex++;
                        }
                    }

                    Console.WriteLine("Reset");
                }
                else if (intSelect == 4)
                {
                    return; //takes back to main
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        // Q4: Class List Manager
        public static void Q4ClassMngr()
        {
            //Declaration
            string strName;
            int intSelect = 0, intDelete = 0, intChange = 0;
            string[] strClassList = new string[1] { "DEFAULT" };
            string[] strTempClassList;

            while (true)
            {
                // Input
                Console.WriteLine("1. Current Class List");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Delete Student");
                Console.WriteLine("4. Change a Student Name");
                Console.WriteLine("5. Reset List");
                Console.WriteLine("6. Exit");
                intSelect = Int32.Parse(Console.ReadLine());

                //Processing/Output
                if (intSelect == 1)
                {
                    Console.WriteLine("Current class list:");
                    for (int i = 0; i < strClassList.Length; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + strClassList[i]);
                    }
                }
                else if (intSelect == 2)
                {
                    Console.Write("Enter the name of the student to add: ");
                    strName = Console.ReadLine();
                    strTempClassList = new string[strClassList.Length + 1];
                    for (int i = 0; i < strClassList.Length; i++)
                    {
                        strTempClassList[i] = strClassList[i];
                    }
                    strTempClassList[strTempClassList.Length - 1] = strName;
                    strClassList = strTempClassList;
                    Console.WriteLine(strName + " added");
                }
                else if (intSelect == 3)
                {
                    for (int i = 0; i < strClassList.Length; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + strClassList[i]);
                    }
                    Console.Write("Enter Index of Student: ");
                    intDelete = Int32.Parse(Console.ReadLine()) - 1;
                    if (intDelete >= 0 && intDelete < strClassList.Length)
                    {
                        strTempClassList = new string[strClassList.Length - 1];
                        for (int i = 0; i < intDelete; i++)
                        {
                            strTempClassList[i] = strClassList[i];
                        }
                        for (int i = intDelete + 1; i < strClassList.Length; i++)
                        {
                            strTempClassList[i - 1] = strClassList[i];
                        }
                        strClassList = strTempClassList;
                        Console.WriteLine("Student deleted.");
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection.");
                    }
                }
                else if (intSelect == 4)
                {
                    for (int i = 0; i < strClassList.Length; i++)
                    {
                        Console.WriteLine((i + 1) + ". " + strClassList[i]);
                    }
                    Console.Write("Enter Student Index: ");
                    intChange = Int32.Parse(Console.ReadLine()) - 1;
                    if (intChange >= 0 && intChange < strClassList.Length)
                    {
                        Console.Write("Enter New Name: ");
                        strName = Console.ReadLine();
                        strClassList[intChange] = strName;
                        Console.WriteLine("Name Changed");
                    }
                    else
                    {
                        Console.WriteLine("Invalid selection.");
                    }
                }
                else if (intSelect == 5)
                {
                    strClassList = new string[1] { "DEFAULT" };
                    Console.WriteLine("Reset");
                }
                else if (intSelect == 6)
                {
                    return; //return to main
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
