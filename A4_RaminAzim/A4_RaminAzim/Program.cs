/* Name: Ramin Azim
 * Date: 03/26/25
 * Title: Assignment 4
 *  Purpose: Menu driven program for questions given
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A4_RaminAzim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Infinite loop to keep menu running until user exits
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("ASSIGNMENT 4");

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Menu(); //Display menu
                string strUsr;

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Choose Option: ");
                strUsr = Console.ReadLine();

                //Execute corresponding function based on user input
                if (strUsr == "1")
                {
                    Q1_GenSeq();
                }
                else if (strUsr == "2")
                {
                    Q2_DescSeq();
                }
                else if (strUsr == "3")
                {
                    Q3_CmltvSub();
                }
                else if (strUsr == "4")
                {
                    Q4_ChkComp();
                }
                else if (strUsr == "5")
                {
                    Q5_SumPrm();
                }
                else if (strUsr == "6")
                {
                    Q6_MultTbl();
                }
                else if (strUsr == "7")
                {
                    Q7_CharPtrn();
                }
                else
                {
                    Environment.Exit(0); //Exit the program
                }
            }
        }

        //Method to display menu options to the user
        public static void Menu()
        {
            Console.WriteLine("1 - Generated Sequence");
            Console.WriteLine("2 - Descending Order");
            Console.WriteLine("3 -  Subtraction Loop");
            Console.WriteLine("4 - Check Composite");
            Console.WriteLine("5 - Sum Primes");
            Console.WriteLine("6 - Multiplication Table");
            Console.WriteLine("7 - Character Pattern");
            Console.WriteLine("Any Other Input - Exit");
        }

        //Q1_GenSeq: Generate sequence from -12000 to 1000 incrementing by 5
        public static void Q1_GenSeq()
        {
            //Declaration
            int intCounter = -12000;
            //No Inputs

            //Processing/Output: Loop to increment by 5 until reaching 1000
            do
            {
                if (intCounter == 1000)
                {
                    Console.WriteLine(intCounter);
                    break; //Exit loop once 1000 is reached
                }
                Console.Write(intCounter + ", ");
                intCounter += 5; //Increment by 5
            } while (intCounter <= 1000);

            Console.WriteLine();
        }

        //Q2_DescSeq: Generate a sequence of numbers in descending order
        public static void Q2_DescSeq()
        {
            //Declaration
            string strUser;
            int intNumOne, intNumTwo, intDec;
            //Input
            while (true)
            {
                Console.WriteLine("First Number:");
                strUser = Console.ReadLine();
                intNumOne = Int32.Parse(strUser);

                Console.WriteLine("Second Number:");
                strUser = Console.ReadLine();
                intNumTwo = Int32.Parse(strUser);

                Console.WriteLine("Decrement:");
                strUser = Console.ReadLine();
                intDec = Int32.Parse(strUser);

                //Check if conditions are valid
                if (intDec > 0 && Math.Abs(intNumOne - intNumTwo) % intDec == 0)
                {
                    break; //Exit loop if conditions met
                }
                Console.WriteLine("Invalid Input");
            }

            //Process/Output: Print sequence in descending order
            if (intNumOne > intNumTwo) //If Num1 is larger
            {
                while (true)
                {
                    if (intNumOne == intNumTwo)
                    {
                        Console.WriteLine(intNumTwo);
                        break; //Exit loop once both numbers are equal
                    }
                    Console.WriteLine(intNumOne + ", ");
                    intNumOne = intNumOne - intDec; //Decrement by intDec
                }
            }
            else if (intNumOne < intNumTwo) //If Num2 is larger
            {
                while (true)
                {
                    if (intNumOne == intNumTwo)
                    {
                        Console.WriteLine(intNumOne);
                        break; //Exit loop once both numbers are equal
                    }
                    Console.WriteLine(intNumTwo + ", ");
                    intNumTwo = intNumTwo - intDec; //Decrement by intDec
                }
            }

            Console.WriteLine();
        }

        //Q3_CmltvSub: Perform cumulative subtraction
        public static void Q3_CmltvSub()
        {
            //Declaration
            string strUser;
            int intNum = 0;
            int intCount = 0;

            //Input: Get starting number
            Console.Write("Starting Number:");
            strUser = Console.ReadLine();
            intCount = int.Parse(strUser);

            //Input/Process: Subtract numbers until user types "EXIT"
            while (true)
            {
                Console.Write("Number:");
                strUser = Console.ReadLine();
                if (strUser == "EXIT" || strUser == "exit")
                {
                    break; //Exit loop if user types EXIT
                }
                else
                {
                    intNum = Int32.Parse(strUser); //Parse input number
                }
                intCount = intCount - intNum; //Cumulatively subtract numbers
            }

            //Output: Show final result
            Console.WriteLine("Result: " + intCount);

            Console.WriteLine();
        }

        //Q4_ChkComp: Check if the given number is Prime or Composite
        public static void Q4_ChkComp()
        {
            //Declaration
            string strUser;
            int intNum = 0, intFctr = 0;

            //Input: Get the number from user
            Console.Write("Number: ");
            strUser = Console.ReadLine();
            intNum = int.Parse(strUser);

            //Process: Count the number of factors
            for (int i = 1; i <= intNum; i++)
            {
                if (intNum % i == 0)
                {
                    intFctr++; //Increase factor count
                }
            }

            //Output: Check if the number is Prime or Composite
            if (intFctr == 2)
            {
                Console.WriteLine("Prime");
            }
            else
            {
                Console.WriteLine("Composite");
            }

            Console.WriteLine();
        }

        //Q5_SumPrm: Sum all prime numbers in a specific range
        public static void Q5_SumPrm()
        {
            //Declaration
            string strUser;
            int intNum = 211;
            int intCount = 0, intFctr = 0;

            //No Input
            //Process/Output: Check for primes and sum them
            while (intNum <= 11504)
            {
                intFctr = 0; //Reset factor count

                //Check if number is prime
                for (int i = 1; i <= Math.Sqrt(intNum); i++) //Only check up to sqrt(num) for efficiency
                {
                    if (intNum % i == 0)
                    {
                        if (i != intNum)
                        {
                            intFctr++; //Count factor if not equal to num
                        }
                        else
                        {
                            intFctr++; //Count the number itself as a factor
                        }
                    }
                }

                //If number is prime, add it to the sum
                if (intFctr == 1)
                {
                    intCount += intNum;
                }
                intNum += 1;
            }

            Console.WriteLine(intCount); //Output the sum of primes

            Console.WriteLine();
        }

        //Q6_MultTbl: Print multiplication table based on user input for rows and columns
        public static void Q6_MultTbl()
        {
            //Declaration
            string strUser;
            int intRow, intColumn;

            //Input: Get number of rows and columns for table
            Console.Write("Rows: ");
            strUser = Console.ReadLine();
            intRow = int.Parse(strUser);

            Console.Write("Columns: ");
            strUser = Console.ReadLine();
            intColumn = int.Parse(strUser);

            //Process: Print the table headers
            Console.WriteLine();
            Console.Write("     ");
            for (int col = 1; col <= intColumn; col++)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write(string.Format("{0,5}", col)); //Column header
                Console.BackgroundColor = ConsoleColor.Black;
            }
            Console.WriteLine();

            //Output: Print multiplication table
            for (int row = 1; row <= intRow; row++)
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.Write(string.Format("{0,3} ", row)); //Row header
                Console.BackgroundColor = ConsoleColor.Black;

                for (int col = 1; col <= intColumn; col++)
                {
                    Console.Write(string.Format("{0,5}", row * col)); //Table data
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        //Q7_CharPtrn: Print a character pattern based on user input for characters and rows
        public static void Q7_CharPtrn()
        {
            //Declaration
            string strUser, strChar;
            int intRows;

            //Input: Get character(s) and number of rows from user
            Console.Write("Character(s): ");
            strUser = Console.ReadLine();
            strChar = strUser;

            Console.Write("Rows: ");
            strUser = Console.ReadLine();
            intRows = int.Parse(strUser);

            //Process/Output: Print the pattern based on input
            for (int i = 1; i <= intRows; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write(strChar); //Print the character
                }
                Console.WriteLine(); //Move to next line after printing row
            }

            Console.WriteLine();
        }
    }
}
