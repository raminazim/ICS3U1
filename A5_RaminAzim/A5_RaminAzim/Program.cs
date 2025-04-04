/* Name: Ramin Azim
 * Date: 04/01/25
 * Title: Assignment 5
 * Purpose: To create a program that uses a menu and does different questions
 */

using System;

namespace A5_RaminAzim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ask user which option they want to pick (keep looping)
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("ASSIGNMENT 5");

                Console.ForegroundColor = ConsoleColor.DarkBlue;
                Menu(); //Display menu

                Console.ForegroundColor = ConsoleColor.White;
                Console.Write("Choose Option: ");
                string strUsr = Console.ReadLine();

                // Call the corresponding method depending on the user's input
                if (strUsr == "1") Q1_NumDis();
                else if (strUsr == "2") Q2_Encrypt();
                else if (strUsr == "3") Q3_NumDis2();
                else if (strUsr == "4") Q4_BackRain();
                else if (strUsr == "5") Q5_Pattern();
                else if (strUsr == "6") Q6_123();
                else Environment.Exit(0); // Exit if input is anything else
            }
        }

        public static void Menu()
        {
            // Display the menu
            Console.WriteLine("1 - Number Display");
            Console.WriteLine("2 - Encrypt");
            Console.WriteLine("3 - Number Display 2");
            Console.WriteLine("4 - Backwards Rainbow");
            Console.WriteLine("5 - Pattern");
            Console.WriteLine("6 - 123 Pattern");
            Console.WriteLine("Any Other Input - Exit");
        }

        public static void Q1_NumDis()
        {
            //Declaration
            string strNum;

            //Input
            Console.Write("Enter number: ");
            int intNum = int.Parse(Console.ReadLine());

            //Process/Output
            strNum = intNum.ToString(); // Convert number to string so we can loop through digits

            for (int i = 0; i < strNum.Length; i++)
            {
                // Check each digit and print its word version
                if (strNum[i] == '0') Console.Write("zero ");
                else if (strNum[i] == '1') Console.Write("one ");
                else if (strNum[i] == '2') Console.Write("two ");
                else if (strNum[i] == '3') Console.Write("three ");
                else if (strNum[i] == '4') Console.Write("four ");
                else if (strNum[i] == '5') Console.Write("five ");
                else if (strNum[i] == '6') Console.Write("six ");
                else if (strNum[i] == '7') Console.Write("seven ");
                else if (strNum[i] == '8') Console.Write("eight ");
                else if (strNum[i] == '9') Console.Write("nine ");
            }

            Console.WriteLine();
        }

        public static void Q2_Encrypt()
        {
            //Declaration
            string strNum, d1, d4, mid, d3;
            int i1, i2, i3, i4, intNum;

            //Input
            Console.Write("4 Dig Num: ");
            strNum = Console.ReadLine();

            //Process
            d1 = strNum.Substring(3); // 4th digit
            d4 = strNum.Substring(0, 1); // 1st digit
            mid = strNum.Substring(1, 2); // 2nd and 3rd
            d3 = strNum.Substring(2); // 3rd digit

            // Convert all to integers
            i1 = int.Parse(d1);
            i2 = int.Parse(mid);
            i3 = int.Parse(d3);
            i4 = int.Parse(d4);

            i1 *= 1000; // Shift 4th digit to 1000s place
            i2 *= 10; // Move 2nd+3rd to tens place
            i3 ^= (i1 / 1000); // XOR 3rd digit with original 4th
            intNum = i1 + i2 + i3 + i4; // Add all parts
            intNum /= 5; // Divide by 5
            intNum += intNum * 5; // Multiply result and add

            if (intNum > 9999) intNum /= 10; // If too long, fix length

            //Output
            Console.WriteLine("Encrypted Number: " + intNum);
            Console.WriteLine();
            Console.WriteLine("Encryption Process:");
            Console.WriteLine("1. Swap 1st 4th Digit");
            Console.WriteLine("2. 3rd Digit ^ 1st Digit");
            Console.WriteLine("3. ÷5");
            Console.WriteLine("4. Add previous result");
            Console.WriteLine();
        }

        public static void Q3_NumDis2()
        {
            //Declaration
            int intNum, h, t, o, teen;
            string[] hundreds = { "", "One Hundred", "Two Hundred", "Three Hundred", "Four Hundred", "Five Hundred", "Six Hundred", "Seven Hundred", "Eight Hundred", "Nine Hundred" };
            string[] tens = { "", "Ten", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
            string[] ones = { "", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine" };
            string[] teens = { "", "", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Six Teen", "Seven Teen", "Eight Teen", "Nine Teen" };

            //Input
            Console.WriteLine("Enter a Number (>1000): ");
            intNum = int.Parse(Console.ReadLine());

            //Process/Output
            if (intNum == 1000)
            {
                Console.WriteLine("One Thousand");
                return;
            }

            h = intNum / 100; // Get hundreds digit
            t = (intNum % 100) / 10; // Get tens digit
            o = intNum % 10; // Get ones digit
            teen = t * 10 + o; // Combine to check for teen

            Console.Write(hundreds[h] + " ");

            if (teen > 10 && teen < 20)
            {
                Console.WriteLine(teens[teen - 10]); // Handle teens separately
                return;
            }

            Console.Write(tens[t] + " ");
            Console.Write(ones[o]);
            Console.WriteLine();
        }

        public static void Q4_BackRain()
        {
            //Declaration
            string s;
            int c = 0;

            //Input
            Console.WriteLine("Sentence: ");
            s = Console.ReadLine();

            //Process/Output
            for (int i = s.Length - 1; i >= 0; i--) // Loop backwards
            {
                Console.ForegroundColor = (ConsoleColor)(c + 12); // Change color
                Console.Write(s[i]);
                c = (c + 1) % 6; // Cycle through 6 color offsets
            }

            Console.WriteLine();
        }

        public static void Q5_Pattern()
        {
            //Declaration
            string name = "Ramin Azim";
            int size = 9;

            //Process/Output
            for (int i = 0; i < size; i++)
            {
                for (int x = 0; x < size; x++)
                {
                    // Print name diagonally from both corners
                    if (x == i || x == size - i - 1) Console.Write(name + " ");
                    else Console.Write("     ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        public static void Q6_123()
        {
            //Declaration
            string s;

            //Input
            Console.WriteLine("Enter a sentence: ");
            s = Console.ReadLine();

            //Process/Output
            for (int i = 0; i < s.Length;)
            {
                // Print 1 char
                if (i + 1 <= s.Length) Console.WriteLine(s.Substring(i++, 1));
                // Print next 2 chars
                if (i + 2 <= s.Length) Console.WriteLine(s.Substring(i, 2));
                i += 2;
                // Print next 3 chars
                if (i + 3 <= s.Length) Console.WriteLine(s.Substring(i, 3));
                i += 3;
            }

            Console.WriteLine();
        }
    }
}
