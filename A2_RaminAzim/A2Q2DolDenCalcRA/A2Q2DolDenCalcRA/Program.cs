/*
 * Name: Ramin
 * Date: 02/24/25
 * Title: Dollar Denotation Calculator
 * Purpose: Find dollar denotation of given number
 */

using System;

namespace A2Q2DolDenCalcRA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaration
                string strUserInput;
                int intHundo, intFifty, intTwenty, intTen, intFive, intToonie, intLoonie, intBal;

            // Input
                Console.Write("Enter the amount of money: ");
                strUserInput = Console.ReadLine();
                intBal = Int32.Parse(strUserInput);

            // Process

                // Hundred
                intHundo = intBal / 100;
                intBal %= 100;

                // Fifty
                 intFifty = intBal / 50;
                 intBal %= 50;

                 // Twenty
                 intTwenty = intBal / 20;
                 intBal %= 20;

                 // Ten
                intTen = intBal / 10;
                intBal %= 10;

                // Five
                intFive = intBal / 5;
                intBal %= 5;

                // Toonie
                intToonie = intBal / 2;
                intBal %= 2;

                // Loonie
                intLoonie = intBal;

            // Output
                Console.WriteLine("Hundred: " + intHundo);
                Console.WriteLine("Fifty: " + intFifty);
                Console.WriteLine("Twenty: " + intTwenty);
                Console.WriteLine("Ten: " + intTen);
                Console.WriteLine("Five: " + intFive);
                Console.WriteLine("Toonie: " + intToonie);
                Console.WriteLine("Loonie: " + intLoonie);

            Console.ReadKey();
        }
    }
}