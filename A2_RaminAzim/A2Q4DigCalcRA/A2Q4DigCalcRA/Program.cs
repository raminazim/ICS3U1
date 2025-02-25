/*
 * Name: Ramin
 * Date: 02/24/25
 * Title: Digit Calculator
 * Purpose: Separate digits of a 4 digit number
*/

using System;

namespace A2Q4DigCalcRA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaration
            string strUserInput;
            int number, intThousands, intHundreds, intTens, intOnes;

            // Input
            Console.Write("Enter a four-digit number: ");
            strUserInput = Console.ReadLine();
            number = int.Parse(strUserInput);

            // Process
            intThousands = number / 1000;
            intHundreds = (number % 1000) / 100;
            intTens = (number % 100) / 10;
            intOnes = number % 10;

            // Output
            Console.WriteLine("1000s: " + intThousands);
            Console.WriteLine("100s: " + intHundreds);
            Console.WriteLine("10s: " + intTens);
            Console.WriteLine("1s: " + intOnes);

            Console.ReadKey();
        }
    }
}
