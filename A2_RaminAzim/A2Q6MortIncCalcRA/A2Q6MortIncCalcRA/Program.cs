/*
 * Name: Ramin 
 * Date: 02/24/25
 * Title: Mortgage Income Calculator
 * Purpose: Find needed income for mortgage
 */
using System;

namespace A2Q6MortIncCalcRA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaration
                string strUserInput;
                double dblHousePrice, dblDownPayment, dblLoanAmount, dblRate, dblMonthlyPayment, dblNumerator, dblDenominator, dblNetMonthly, dblGrossMonthly, dblGrossAnnual;
                int intPaymentPerYear, intYear, intTotalPayments;
                double dblIncomeTaxRate = 0.30; // 30% tax rate
                double dblHousingRatio = 1.0 / 3.0; // Housing = 1/3 of take-home income

            // Input

                // House Input
                Console.Write("House Price: ");
                strUserInput = Console.ReadLine();
                dblHousePrice = double.Parse(strUserInput);

                Console.Write("Down Payment: ");
                strUserInput = Console.ReadLine();
                dblDownPayment = double.Parse(strUserInput);

                dblLoanAmount = dblHousePrice - dblDownPayment; //Loan amount

                //Mortage Input
                Console.Write("Interest Rate (Decimal): 0.");
                strUserInput = Console.ReadLine();
                dblRate = double.Parse(strUserInput) / 100;

                Console.Write("Payments per year: ");
                strUserInput = Console.ReadLine();
                intPaymentPerYear = int.Parse(strUserInput);
    
                Console.Write("Number of years: ");
                strUserInput = Console.ReadLine();
                intYear = int.Parse(strUserInput);

            // Process
                //Mortgage
                intTotalPayments = intPaymentPerYear * intYear;
                dblNumerator = dblLoanAmount * (dblRate / intPaymentPerYear);
                dblDenominator = 1 - Math.Pow((1 + (dblRate / intPaymentPerYear)), -intTotalPayments);
                dblMonthlyPayment = dblNumerator / dblDenominator;

                // Monthly Net Income
                dblNetMonthly = dblMonthlyPayment / dblHousingRatio;

                // Monthly Gross Income
                dblGrossMonthly = dblNetMonthly / (1 - dblIncomeTaxRate);

                // Annual Gross Income
                dblGrossAnnual = dblGrossMonthly * 12;
            dblGrossAnnual = Math.Round(dblGrossAnnual, 2);

            // Output
                Console.WriteLine("Gross Annual Income Needed: $" +dblGrossAnnual);

            Console.ReadKey();
        }
    }
}
