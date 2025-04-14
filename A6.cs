using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Call any of the required methods here
            //Q1RandStats();
            //Q2GradeMngr();
            //Q3CDeckMngr();
            Q4ClassMngr();

            Console.ReadKey();
        }

        //Q1: Random Number Occurrence Stats
        public static void Q1RandStats()
        {
            while (true)
            {
                //Declaration
                int intNum, intRnd, intInput = 0;
                Random Rnd = new Random();
                int[] intOccur;
                int[] counts = new int[9];

                //Input
                Console.WriteLine("Enter a number: ");
                intNum = Int32.Parse(Console.ReadLine());

                //Process
                intOccur = new int[intNum];

                for (int i = 0; i < intNum; i++)
                {
                    intRnd = Rnd.Next(1, 10);
                    intOccur[i] = intRnd;
                    counts[intRnd - 1]++;
                }

                //Output
                Console.WriteLine("Number: ----- Times Shown");
                for (int i = 0; i < counts.Length; i++)
                {
                    Console.WriteLine((i + 1) + " ---------- " + counts[i]);
                }

                //User choice input/output
                Console.WriteLine("\nWhat would you like to do? \n 1. New set of integers \n 2. Exit");
                intInput = Int32.Parse(Console.ReadLine());
                if (intInput == 2) break;
                else if (intInput == 1) Console.Clear();
            }
        }

        //Q2: Grade Manager
        public static void Q2GradeMngr()
        {
            string strUI;
            int[] intGrades = new int[15];
            int[] intSizedGrades;
            int intGrade, intChangedGrade = 0, intSelect = 0, intNumOfValues = 0;
            int intTotal = 0, intAvg = 0;
            int intDelete = 0, intChange = 0;

            //Input
            for (int i = 0; i < 15; i++)
            {
                Console.WriteLine("What is the grade? ");
                intGrade = Int32.Parse(Console.ReadLine());
                intGrades[i] = intGrade;
                if (i < 5 && intGrade == -99)
                {
                    Console.WriteLine("Must enter at least 5 grades.");
                    Console.Clear();
                }
                if (i > 5 && intGrade == -99) break;
                intNumOfValues++;
            }

            //Process
            intSizedGrades = new int[intNumOfValues];

            int x = 0;
            for (int i = 0; i < intGrades.Length; i++)
            {
                if (intGrades[i] == -99) break;
                intSizedGrades[x] = intGrades[i];
                x++;
            }

            //Output
            while (true)
            {
                Console.WriteLine("1. Number of values in the array\r\n2. List the values in the array\r\n3. Average\r\n4. Delete a specific value\r\n5. Change a specific value\r\n6. Add a value\r\n7. Exit");
                intSelect = Int32.Parse(Console.ReadLine());

                switch (intSelect)
                {
                    case 1:
                        //Output
                        Console.WriteLine("There are " + intSizedGrades.Length + " values");
                        break;
                    case 2:
                        //Output
                        Console.WriteLine("Grades: ");
                        foreach (var grade in intSizedGrades)
                        {
                            Console.WriteLine(grade);
                        }
                        break;
                    case 3:
                        //Process
                        intTotal = 0;
                        foreach (var grade in intSizedGrades)
                        {
                            intTotal += grade;
                        }
                        intAvg = intTotal / intSizedGrades.Length;
                        //Output
                        Console.WriteLine("Average: " + intAvg);
                        break;
                    case 4:
                        //Input and Process
                        Console.WriteLine("Which grade would you like to delete: ");
                        for (int i = 0; i < intSizedGrades.Length; i++)
                        {
                            Console.WriteLine(i + " : " + intSizedGrades[i]);
                        }
                        Console.Write("Select grade to delete: ");
                        intDelete = Int32.Parse(Console.ReadLine());

                        intTemp = new int[intSizedGrades.Length - 1];
                        Array.Copy(intSizedGrades, 0, intTemp, 0, intDelete);
                        Array.Copy(intSizedGrades, intDelete + 1, intTemp, intDelete, intTemp.Length - intDelete);
                        intSizedGrades = intTemp;

                        //Output
                        Console.WriteLine("Updated Grades: ");
                        foreach (var grade in intSizedGrades)
                        {
                            Console.WriteLine(grade);
                        }
                        break;
                    case 5:
                        //Input and Process
                        Console.WriteLine("Which grade would you like to change? ");
                        for (int i = 0; i < intSizedGrades.Length; i++)
                        {
                            Console.WriteLine(i + " : " + intSizedGrades[i]);
                        }
                        Console.Write("Select grade to change: ");
                        intChange = Int32.Parse(Console.ReadLine());
                        Console.Write("What is the new grade: ");
                        intChangedGrade = Int32.Parse(Console.ReadLine());
                        intSizedGrades[intChange] = intChangedGrade;
                        break;
                    case 6:
                        //Process
                        intTemp = new int[intSizedGrades.Length + 1];
                        Array.Copy(intSizedGrades, intTemp, intSizedGrades.Length);
                        Console.WriteLine("Enter grade to add: ");
                        strUI = Console.ReadLine();
                        intTemp[intTemp.Length - 1] = Int32.Parse(strUI);
                        intSizedGrades = intTemp;
                        break;
                    case 7:
                        return;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        //Q3: Card Deck Manager
        public static void Q3CDeckMngr()
        {
            //Declaration
            string[] strRank = { "A", "1", "2", "3", "3", "5", "6", "7", "8", "9", "10", "J", "Q", "K" };
            string[] strSuit = { "Hearts", "Diamonds", "Spades", "Clubs" };
            string[] strDeck = new string[strRank.Length * strSuit.Length];
            int intIndex = 0;

            //Process
            for (int i = 0; i < strSuit.Length; i++)
            {
                for (int j = 0; j < strRank.Length; j++)
                {
                    strDeck[intIndex] = strRank[j] + " of " + strSuit[i];
                    intIndex++;
                }
            }

            intSelect = 0;
            while (true)
            {
                //Input
                Console.WriteLine("1. Show current deck\r\n2. Shuffle Deck\r\n3. Reset Deck to a Brand New Deck\r\n4. Exit");
                intSelect = Int32.Parse(Console.ReadLine());

                switch (intSelect)
                {
                    case 1:
                        //Output
                        foreach (var card in strDeck)
                        {
                            Console.WriteLine(card);
                        }
                        break;
                    case 2:
                        //Process
                        ShuffleDeck(ref strDeck);
                        Console.WriteLine("Deck shuffled!");
                        break;
                    case 3:
                        //Process
                        intIndex = 0;
                        for (int i = 0; i < strSuit.Length; i++)
                        {
                            for (int j = 0; j < strRank.Length; j++)
                            {
                                strDeck[intIndex] = strRank[j] + " of " + strSuit[i];
                                intIndex++;
                            }
                        }
                        intIndex = 0;
                        break;
                    case 4:
                        return;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }

        //Shuffle the deck using Fisher-Yates shuffle
        public static void ShuffleDeck(ref string[] strDeck)
        {
            Random rng = new Random();
            for (int i = strDeck.Length - 1; i > 0; i--)
            {
                int j = rng.Next(i + 1); // Random index between 0 and i
                string temp = strDeck[i];
                strDeck[i] = strDeck[j];
                strDeck[j] = temp;
            }
        }

        //Q4: Class List Manager
        public static void Q4ClassMngr()
        {
            string strName;
            int intSelect = 0, intDelete = 0, intChange = 0;
            string[] strClassList = new string[1] { "DEFAULT" };
            string[] strTempClassList;

            while (true)
            {
                //Input
                Console.WriteLine("1. Show current class list\r\n2. Add a student\r\n3. Delete a student\r\n4. Change a student's name\r\n5. Reset class list to default\r\n6. Exit");
                intSelect = Int32.Parse(Console.ReadLine());

                switch (intSelect)
                {
                    case 1:
                        //Output
                        Console.WriteLine("Current class list:");
                        for (int i = 0; i < strClassList.Length; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + strClassList[i]);
                        }
                        break;
                    case 2:
                        //Input and Process
                        Console.Write("Enter the name of the student to add: ");
                        strName = Console.ReadLine();
                        strTempClassList = new string[strClassList.Length + 1];
                        Array.Copy(strClassList, strTempClassList, strClassList.Length);
                        strTempClassList[strTempClassList.Length - 1] = strName;
                        strClassList = strTempClassList;
                        //Output
                        Console.WriteLine(strName + " has been added to the class list.");
                        break;
                    case 3:
                        //Input and Process
                        Console.WriteLine("Select the student to delete:");
                        for (int i = 0; i < strClassList.Length; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + strClassList[i]);
                        }
                        Console.Write("Enter the number of the student to delete: ");
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
                            //Output
                            Console.WriteLine("Student has been deleted.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection.");
                        }
                        break;
                    case 4:
                        //Input and Process
                        Console.WriteLine("Select the student to change the name:");
                        for (int i = 0; i < strClassList.Length; i++)
                        {
                            Console.WriteLine((i + 1) + ". " + strClassList[i]);
                        }
                        Console.Write("Enter the number of the student to change: ");
                        intChange = Int32.Parse(Console.ReadLine()) - 1;
                        if (intChange >= 0 && intChange < strClassList.Length)
                        {
                            Console.Write("Enter the new name for the student: ");
                            strName = Console.ReadLine();
                            strClassList[intChange] = strName;
                            //Output
                            Console.WriteLine("Student name has been changed.");
                        }
                        else
                        {
                            Console.WriteLine("Invalid selection.");
                        }
                        break;
                    case 5:
                        //Process
                        strClassList = new string[1] { "DEFAULT" };
                        //Output
                        Console.WriteLine("Class list has been reset to default.");
                        break;
                    case 6:
                        return;
                }

                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
