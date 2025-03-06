/* Name: Ramin
 * Date: 03/04/25
 * Title: Day Calculator
 * Purpose: Calculate how many days are in a given range of dates
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3Q7DayCalcRA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            double dblDayOne, dblDayTwo, dblYearOne, dblYearTwo, dblYearOneTotal, dblYearTwoTotal, dblTotal;
            string strUser, strMonthOne, strMonthTwo;

            //Input
            Console.WriteLine("Months should be inputed in written form (e.g. January, August, December, etc.)");

            Console.Write("Year 1:"); //Yr 1
            strUser = Console.ReadLine();
            dblYearOne = Int32.Parse(strUser);

            Console.Write("Month 1:");
            strMonthOne = Console.ReadLine();

            Console.Write("Day 1:");
            strUser = Console.ReadLine();
            dblDayOne = Int32.Parse(strUser);

            Console.Write("Year 2: "); //Yr 2
            strUser = Console.ReadLine();
            dblYearTwo = Int32.Parse(strUser);

            Console.Write("Month 2:");
            strMonthTwo = Console.ReadLine();

            Console.Write("Day 2:");
            strUser = Console.ReadLine();
            dblDayTwo = Int32.Parse(strUser);

            //Process
            dblYearOneTotal = (dblYearOne - 1) * 365.25;  // Year: Calculates how many years relative to 0
            dblYearTwoTotal = (dblYearTwo - 1) * 365.25;

            if (strMonthOne == ("January")) //Month 1
            {
                dblYearOneTotal = dblYearOneTotal + 0;
            }
            else if (strMonthOne == ("February"))
            {
                dblYearOneTotal = dblYearOneTotal + 31;
            }
            else if (strMonthOne == ("March"))
            {
                dblYearOneTotal = dblYearOneTotal + 31 + 28;
            }
            else if (strMonthOne == ("April"))
            {
                dblYearOneTotal = dblYearOneTotal + 31 + 28 + 31;
            }
            else if (strMonthOne == ("May"))
            {
                dblYearOneTotal = dblYearOneTotal + 31 + 28 + 31 + 30;
            }
            else if (strMonthOne == ("June"))
            {
                dblYearOneTotal = dblYearOneTotal + 31 + 28 + 31 + 30 + 31;
            }
            else if (strMonthOne == ("July"))
            {
                dblYearOneTotal = dblYearOneTotal + 31 + 28 + 31 + 30 + 31 + 30;
            }
            else if (strMonthOne == ("August"))
            {
                dblYearOneTotal = dblYearOneTotal + 31 + 28 + 31 + 30 + 31 + 30 + 31;
            }
            else if (strMonthOne == ("September"))
            {
                dblYearOneTotal = dblYearOneTotal + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31;
            }
            else if (strMonthOne == ("October"))
            {
                dblYearOneTotal = dblYearOneTotal + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30;
            }
            else if (strMonthOne == ("November"))
            {
                dblYearOneTotal = dblYearOneTotal + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31;
            }
            else
            {
                dblYearOneTotal = dblYearOneTotal + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30 + 31;
            }

            dblYearOneTotal = dblYearOneTotal + dblDayOne;

            if (strMonthTwo == ("January")) //Month 2
            {
                dblYearTwoTotal = dblYearTwoTotal + 0;
            }
            else if (strMonthTwo == ("February"))
            {
                dblYearTwoTotal = dblYearTwoTotal + 31;
            }
            else if (strMonthTwo == ("March"))
            {
                dblYearTwoTotal = dblYearTwoTotal + 31 + 28;
            }
            else if (strMonthTwo == ("April"))
            {
                dblYearTwoTotal = dblYearTwoTotal + 31 + 28 + 31;
            }
            else if (strMonthTwo == ("May"))
            {
                dblYearTwoTotal = dblYearTwoTotal + 31 + 28 + 31 + 30;
            }
            else if (strMonthTwo == ("June"))
            {
                dblYearTwoTotal = dblYearTwoTotal + 31 + 28 + 31 + 30 + 31;
            }
            else if (strMonthTwo == ("July"))
            {
                dblYearTwoTotal = dblYearTwoTotal + 31 + 28 + 31 + 30 + 31 + 30;
            }
            else if (strMonthTwo == ("August"))
            {
                dblYearTwoTotal = dblYearTwoTotal + 31 + 28 + 31 + 30 + 31 + 30 + 31;
            }
            else if (strMonthTwo == ("September"))
            {
                dblYearTwoTotal = dblYearTwoTotal + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31;
            }
            else if (strMonthTwo == ("October"))
            {
                dblYearTwoTotal = dblYearTwoTotal + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30;
            }
            else if (strMonthTwo == ("November"))
            {
                dblYearTwoTotal = dblYearTwoTotal + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31;
            }
            else
            {
                dblYearTwoTotal = dblYearTwoTotal + 31 + 28 + 31 + 30 + 31 + 30 + 31 + 31 + 30 + 31 + 30 + 31;
            }

            dblYearTwoTotal = dblYearTwoTotal + dblDayTwo;

            // Leap Year Calculations
            if (dblYearOne % 4 == 0 && (dblYearOne % 100 != 0 || dblYearOne % 400 == 0))
            {
                dblYearOneTotal = dblYearOneTotal + 1;
            }

            if (dblYearTwo % 4 == 0 && (dblYearTwo % 100 != 0 || dblYearTwo % 400 == 0))
            {
                dblYearTwoTotal = dblYearTwoTotal + 1;
            }

            dblTotal = Math.Abs(dblYearOneTotal - dblYearTwoTotal); //Calc difference

            //Output
            Console.WriteLine("Difference: " + (int)dblTotal + " Days");

            Console.ReadKey();
        }
    }
}
