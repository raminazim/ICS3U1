/*
 * Name: Ramin 
 * Date: 02/24/25
 * Title: Mortgage Calculator
 * Purpose: Calculate Mortgage Payment
 */
using System;

namespace A2Q5MortCalcRA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaration
                string strUserInput;
                double dblPrincipal, dblRate, dblMonthlyPayment, dblNumerator, dblDenominator;
                int intPaymentPerYear, intYear, intTotalPayments;

            // Input
                //Principal
                Console.Write("Principal: ");
                strUserInput = Console.ReadLine();
                dblPrincipal = Double.Parse(strUserInput);
            
                //Rate
                Console.Write("Interest Rate (%): ");
                strUserInput = Console.ReadLine();
                dblRate = Double.Parse(strUserInput) / 100;

                //lPayments/Yr
                Console.Write("Payments per year: ");
                strUserInput = Console.ReadLine();
                intPaymentPerYear = Int32.Parse(strUserInput);

                //# of Years
                Console.Write("Number of years: ");
                strUserInput = Console.ReadLine();
                intYear = Int32.Parse(strUserInput);

            // Process
                intTotalPayments = intPaymentPerYear * intYear;
                dblNumerator = dblPrincipal * (dblRate / intPaymentPerYear);
                dblDenominator = 1 - Math.Pow((1 + (dblRate / intPaymentPerYear)), -intTotalPayments);
                dblMonthlyPayment = dblNumerator / dblDenominator;

            // Output (formatted to 2 decimal places)
                Console.WriteLine("Monthly Payment: $" + dblMonthlyPayment);

            Console.ReadKey();
        }
    }
}
