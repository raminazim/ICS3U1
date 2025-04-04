/* Name: Ramin Azim
 * Date: 04/01/25
 * Title: Assignment 5
 *  Purpose: Menu driven program for questions given
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A5_RaminAzim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //menu
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("ASSIGNMENT 5");

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Menu(); //Display menu
                string strUsr;

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Choose Option: ");
                strUsr = Console.ReadLine();

                //Execute corresponding function based on user input
                if (strUsr == "1")
                {
                    Q1_NumDis();
                }
                else if (strUsr == "2")
                {
                    Q2_Encrypt();
                }
                else if (strUsr == "3")
                {
                    Q3_NumDis2();
                }
                else if (strUsr == "4")
                {
                    Q4_BackRain();
                }
                else if (strUsr == "5")
                {
                    Q5_Pattern();
                }
                else if (strUsr == "6")
                {
                    Q6_123();
                }
                else
                {
                    Environment.Exit(0); //Exit the program
                }
            }
            Console.ReadKey();
        }

        public static void Menu()
        {
            Console.WriteLine("1 - Number Display");
            Console.WriteLine("2 - Encrypt");
            Console.WriteLine("3 -  Number Display 2");
            Console.WriteLine("4 - Backwards Rainbow");
            Console.WriteLine("5 - Pattern");
            Console.WriteLine("6 - 123 Pattern");
            Console.WriteLine("Any Other Input - Exit");
        }
        public static void Q1_NumDis()
        {
            //Declaration
            string strUsr, strNum;
            int intNum;

            //Input
            Console.Write("Enter number: ");
            intNum = int.Parse(strUsr = Console.ReadLine());


            strNum = intNum.ToString();

            //Process/Output
            for (int i = 0; i < strNum.Length; i++) //Basically checks the digit then writes the text then moves to the next one
            {
                if (strNum[i] == '0')
                {
                    Console.Write("zero ");
                }
                else if (strNum[i] == '1')
                {
                    Console.Write("one ");
                }
                else if (strNum[i] == '2')
                {
                    Console.Write("two ");
                }
                else if (strNum[i] == '3')
                {
                    Console.Write("three ");
                }
                else if (strNum[i] == '4')
                {
                    Console.Write("four ");
                }
                else if (strNum[i] == '5')
                {
                    Console.Write("five ");
                }
                else if (strNum[i] == '6')
                {
                    Console.Write("six ");
                }
                else if (strNum[i] == '7')
                {
                    Console.Write("seven ");
                }
                else if (strNum[i] == '8')
                {
                    Console.Write("eight ");
                }
                else if (strNum[i] == '9')
                {
                    Console.Write("nine ");
                }

            }
            Console.WriteLine();
        }
        public static void Q2_Encrypt()
        {
            //Declaration
            string strUsr, strNum, strDigOne, strMiddle, strDigThree, strDigFour;
            int intNum, intDigOne, intDigTwo, intDigThree, intDigFour;

            //Input
            Console.Write("4 Dig Num: ");
            strNum = Console.ReadLine();


            //Process
            strDigOne = strNum.Substring(3); //Switches digits
            strDigFour = strNum.Substring(0, 1);
            strMiddle = strNum.Substring(1, 2);
            strDigThree = strNum.Substring(2);


            intDigOne = int.Parse(strDigOne);
            intDigTwo = int.Parse(strMiddle);
            intDigThree = int.Parse(strDigThree);
            intDigFour = int.Parse(strDigFour);

            intDigOne = intDigOne * 1000; //Insane Math
            intDigTwo = intDigTwo * 10;
            intDigThree = intDigThree ^ (intDigOne / 1000);
            intNum = intDigOne + intDigTwo + intDigFour + intDigThree;

            intNum = intNum / 5; //Fixes Digits
            intNum = intNum + (intNum * 5);

            if (intNum > 9999)
            {
                intNum = intNum / 10;
            }
            //output
            Console.WriteLine("Encrypted Number: " + intNum);
            Console.WriteLine();
            Console.WriteLine("Encryption Process: ");
            Console.WriteLine("1. Swap 1st 4th Digit");
            Console.WriteLine("2. Add 3rd Digit To Power Of 1st Digit To Total ");
            Console.WriteLine("3. Divide Total By 5");
            Console.WriteLine("4. Add Total From Previous Division To Divided Number");

            Console.WriteLine();
        }
        public static void Q3_NumDis2()
        {
            //Declaration
            string strUsr, strNum, strHun, strTen, strOne;
            int intNum, intHun, intTen, intOne, intTeen;

            //Input
            Console.WriteLine("Enter a Number (>1000): ");
            intNum = Int32.Parse(Console.ReadLine());

            //Process
            intHun = intNum / 100; //Seperates digits
            intTen = (intNum - (intHun * 100)) / 10;
            intOne = intNum - (intHun * 100) - (intTen * 10);
            intTeen = (intTen * 10) + intOne;

            //Process/Output
            while (true)
            {
                if (intNum == 1000) //if number is 1000 then hard codes this
                {
                    Console.Write("One Thousand");
                    break;
                }

                if (intHun == 1) //then checks for each digit for respective thingy, hard coded for teens
                {
                    Console.Write("One Hundred ");
                }
                else if (intHun == 2)
                {
                    Console.Write("Two Hundred ");
                }
                else if (intHun == 3)
                {
                    Console.Write("Three Hundred ");
                }
                else if (intHun == 4)
                {
                    Console.Write("Four Hundred ");
                }
                else if (intHun == 5)
                {
                    Console.Write("Five Hundred ");
                }
                else if (intHun == 6)
                {
                    Console.Write("Six hundred ");
                }
                else if (intHun == 7)
                {
                    Console.Write("Seven Hundred ");
                }
                else if (intHun == 8)
                {
                    Console.Write("Eight Hundred ");
                }
                else if (intHun == 9)
                {
                    Console.Write("Nine Hundred ");
                }

                //Teens
                if (10 < intTeen && intTeen < 20)
                {
                    if (intTeen == 11)
                    {
                        Console.Write("Eleven ");
                    }
                    else if (intTeen == 12)
                    {
                        Console.Write("Twelve ");
                    }
                    else if (intTeen == 13)
                    {
                        Console.Write("Thirteen ");
                    }
                    else if (intTeen == 14)
                    {
                        Console.Write("Fourteen ");
                    }
                    else if (intTeen == 15)
                    {
                        Console.Write("Fifteen ");
                    }
                    else if (intTeen == 16)
                    {
                        Console.Write("Six Teen");
                    }
                    else if (intTeen == 17)
                    {
                        Console.Write("Seven Teen");
                    }
                    else if (intTeen == 18)
                    {
                        Console.Write("Eight Teen ");
                    }
                    else if (intTeen == 19)
                    {
                        Console.Write("Nine Teen ");
                    }
                    break;
                }

                if (intTen == 1)
                {
                    Console.Write("Ten ");
                }
                else if (intTen == 2)
                {
                    Console.Write("Twenty ");
                }
                else if (intTen == 3)
                {
                    Console.Write("Thirty ");
                }
                else if (intTen == 4)
                {
                    Console.Write("Forty ");
                }
                else if (intTen == 5)
                {
                    Console.Write("Fifty ");
                }
                else if (intTen == 6)
                {
                    Console.Write("Sixty ");
                }
                else if (intTen == 7)
                {
                    Console.Write("Seventy ");
                }
                else if (intTen == 8)
                {
                    Console.Write("Eighty ");
                }
                else if (intTen == 9)
                {
                    Console.Write("Ninety ");
                }

                if (intOne == 1)
                {
                    Console.Write("One ");
                }
                else if (intOne == 2)
                {
                    Console.Write("Two ");
                }
                else if (intOne == 3)
                {
                    Console.Write("Three ");
                }
                else if (intOne == 4)
                {
                    Console.Write("Four ");
                }
                else if (intOne == 5)
                {
                    Console.Write("Five ");
                }
                else if (intOne == 6)
                {
                    Console.Write("Six ");
                }
                else if (intOne == 7)
                {
                    Console.Write("Seven ");
                }
                else if (intOne == 8)
                {
                    Console.Write("Eight ");
                }
                else if (intOne == 9)
                {
                    Console.Write("Nine ");
                }
                break;
            }

            Console.WriteLine();
        }
        public static void Q4_BackRain()
        {
            //Declaration
            string strSentence;
            int intCount = 0;

            //Input
            Console.WriteLine("Sentence: ");
            strSentence = Console.ReadLine();

            //Process/Output
            for (int i = strSentence.Length - 1; i >= 0; i--) //writes the sentence backwards and loops around different colours
            {
                if (intCount == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (intCount == 1)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                else if (intCount == 2)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                else if (intCount == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                else if (intCount == 4)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                else if (intCount == 5)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }
                intCount++;
                Console.Write(strSentence.Substring(i, 1));
                if (intCount > 5)
                {
                    intCount = 0;
                }
            }

            Console.WriteLine();
        }
        public static void Q5_Pattern()
        {
            //Declaration
            string strName = "Ramin Azim";
            int intSize = 9;

            //No Input

            //Process/Output
            for (int i = 0; i < intSize; i++)
            {
                for (int x = 0; x < intSize; x++)
                {

                    if (x == i || x == intSize - i - 1)
                    {
                        Console.Write(strName + " ");
                    }
                    else
                    {
                        Console.Write("     ");
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }
        public static void Q6_123()
        {
            //Declaration
            string strSentence;

            //Input
            Console.WriteLine("Enter a sentence: "); //loops for sentence length and basically types in as the number of digits coded in the if statement
            strSentence = Console.ReadLine();

            //Process/Output
            for (int i = 0; i < strSentence.Length;)
            {
                if (i + 1 > strSentence.Length)
                {
                    break;
                }

                Console.WriteLine(strSentence.Substring(i, 1));

                i++;

                if (i + 2 > strSentence.Length)
                {
                    break;
                }

                Console.WriteLine(strSentence.Substring(i, 2));

                i += 2;

                if (i + 3 > strSentence.Length)
                {
                    break;
                }

                Console.WriteLine(strSentence.Substring(i, 3));

                i += 3;

            }
            Console.WriteLine();
        }
    }
}
