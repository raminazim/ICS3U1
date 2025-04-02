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
            //variable decloration
            int intSelect;

            //menu
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.White;//in number 4 it would change color so this stops it
                Console.WriteLine("______________________________");
                Console.WriteLine("|------------Menu------------|");
                Console.WriteLine("|Number display =========> 1 |");
                Console.WriteLine("|Encrypt Number =========> 2 |");
                Console.WriteLine("|Number display 2 =======> 3 |");
                Console.WriteLine("|Back word rainbow ======> 4 |");
                Console.WriteLine("|name pattern ===========> 5 |");
                Console.WriteLine("|123 pattern ============> 6 |");
                Console.WriteLine("|Exit ===================> 7 |");
                Console.WriteLine("******************************");
                Console.WriteLine();//spacer
                                    //input
                Console.Write("Which program would you like? Enter:");
                intSelect = int.Parse(Console.ReadLine());
                //process and output
                if (intSelect == 1)
                {
                    Q1NumDis();
                }
                else if (intSelect == 2)
                {
                    Q2Encrypt();
                }
                else if (intSelect == 3)
                {
                    Q3NumDis2();
                }
                else if (intSelect == 4)
                {
                    Q4BackRain();
                }
                else if (intSelect == 5)
                {
                    Q5Pattern();
                }
                else if (intSelect == 6)
                {
                    Q6123();
                }              
                else if (intSelect == 7)
                {
                    Console.WriteLine("Come Again!");
                    break;
                }
                else
                {
                    Console.WriteLine("Invalid Input");
                }
                Console.ReadKey();
                Console.Clear();
            }

            Console.ReadKey();
            //Q1NumDis();
            //Q2Encrypt();
            //Q3NumDis2();
            //Q4BackRain();
            //Q5Pattern();
            //Q6123();

        }
        public static void Q1NumDis()
        {
            //variable decloration
            string strNum, strUI;
            int intNum;

            Console.WriteLine("Enter number: "); //input
            intNum = int.Parse(strUI = Console.ReadLine()); //parse in one line

           
            strNum = intNum.ToString(); //make a string
           
            //do until end of number
            for (int i = 0; i < strNum.Length; i++)
            {


                //process and output
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

        }
        public static void Q2Encrypt()
        {
            //variable decloration
            string strUI, strNum, strFirst, strLast, strMiddle, strMiddle2;
            int intNum, intFirst, intMiddle, intMiddle2, intLast;

            Console.WriteLine("Enter a 4 digit number: ");
            strNum = Console.ReadLine();

 
            //process
            strFirst = strNum.Substring(3);//take last number and make it first


            strLast = strNum.Substring(0, 1); //first to last
 

            strMiddle = strNum.Substring(1, 2); //middle 2 numbers


            strMiddle2 = strNum.Substring(2); //just 3rd digit

            //parse
            intFirst = int.Parse(strFirst);
            intMiddle = int.Parse(strMiddle);
            intMiddle2 = int.Parse(strMiddle2);
            intLast = int.Parse(strLast);
            //make it one number
            intFirst = intFirst * 1000;
            intMiddle = intMiddle * 10;
            intMiddle2 = intMiddle2 ^ (intFirst / 1000);
            intNum = intFirst + intMiddle + intLast + intMiddle2;

            intNum = intNum / 5;//encrpyts
            intNum = intNum + (intNum * 5);

            if (intNum > 9999)//make it 4 digits if its greater than 4 digits
            {
                intNum = intNum / 10;
            }
            //output
            Console.WriteLine("Encrypted number is: " + intNum);
            Console.WriteLine("Encryption Process: ");
            Console.WriteLine("1. Swap first and last numbers ");
            Console.WriteLine("2. Add the third digit to the power of the first digit to the total ");
            Console.WriteLine("3. divide total by 5 ");
            Console.WriteLine("4. add total from before division to divided number ");

        }
        public static void Q3NumDis2()
        {
            //variable decloration
            string strUI, strNum, strHun, strTen, strOne;
            int intNum , intHun, intTen, intOne, intTeen;
            //input
            Console.WriteLine("Enter a Number: ");
            intNum = Int32.Parse(Console.ReadLine());
            //process
            intHun = intNum / 100; //hundred place
            intTen = (intNum - (intHun*100)) / 10; //tens place
            intOne = intNum - (intHun * 100) - (intTen*10); //ones place
            intTeen = (intTen * 10) + intOne; //teens case
            //process and output
            while (true)
            {
                if (intNum == 1000)
                {
                    Console.WriteLine("One Thousand");
                    break;
                }
                //hundreds
                if (intHun == 1)
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
                //teens
                if (10 < intTeen && intTeen < 20)
                {
                    //teens //if teen display break so ten and ones dont display
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
                //tens
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
                //ones
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
        }
        public static void Q4BackRain()
        {
            //variable decloration
            string strSentence;
            int intCount=0;
            //input
            Console.WriteLine("Enter a sentence: ");
            strSentence = Console.ReadLine();
            //process and output
            for (int i = strSentence.Length - 1; i >= 0; i--)
            {
               
                //rainbow colors
                if (intCount == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                else if (intCount == 1)
                {
                    Console.ForegroundColor= ConsoleColor.Yellow;
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
                Console.Write(strSentence.Substring(i, 1)); //backword display
                if (intCount > 5) //rainbow reset
                {
                    intCount = 0;
                }
            }

        }
        public static void Q5Pattern()
        {
            //variable decloration
            string strName = "Zachary Tozman";
           
            int intSize = 9;//number of rows
            //process and output
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
                        Console.Write("     ");//space between name
                    }
                }
                Console.WriteLine();
            }
        }
        public static void Q6123()
        {
            //variable decloration
            string strSentence;
            //input
            Console.WriteLine("Enter a sentence: ");
            strSentence = Console.ReadLine();
            //process and output
            for (int i = 0; i < strSentence.Length;)
            {
                if (i + 1 > strSentence.Length)
                {
                    break;
                }

                Console.WriteLine(strSentence.Substring(i, 1));//first in pattern 1

                i++;

                if (i + 2 > strSentence.Length)
                {
                    break;
                }

                Console.WriteLine(strSentence.Substring(i, 2)); //2 characters

                i+=2;
               
                if (i + 3 > strSentence.Length)
                {
                    break;
                }

                Console.WriteLine(strSentence.Substring(i, 3));//3 characters

                i+=3;

            }
        }
    }
}
