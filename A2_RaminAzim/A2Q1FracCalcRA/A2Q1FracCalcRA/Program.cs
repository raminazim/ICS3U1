/*
 * Name: Ramin
 * Date: 02/24/25
 * Title: Fraction Calculator
 * Purpose: Convert imporoper fraction into mixed number
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Q1FracCalcRA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
                string strUserInput;
                int intNumerator, intDenominator, intWholeNumber;

            //Input
                Console.Write("Enter the numerator: ");
                strUserInput = Console.ReadLine();
                intNumerator = Int32.Parse(strUserInput);

                Console.Write("Enter the denominator: ");
                strUserInput = Console.ReadLine();
                intDenominator = Int32.Parse(strUserInput);

            //Process
                intWholeNumber = intNumerator / intDenominator;
                intNumerator = intNumerator % intDenominator;


            //Output
                Console.WriteLine("   " + intNumerator);
                Console.WriteLine(intWholeNumber + " ---");
                Console.WriteLine("   " + intDenominator);

            Console.ReadKey();
        }
    }
}
