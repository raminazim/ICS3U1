/*
 * Name: Ramin
 * Date: 02/24/25
 * Title: Trigonometry Calculator
 * Purpose: Find area primeter of triangle
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2Q3TrigCalcRA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            string strUserInput, strUnit;
            double dblSideA, dblSideB, dblSideC, DblArea, dblPerimeter;

            //Input
            Console.Write("Enter the length of side A: ");
            strUserInput = Console.ReadLine();
            dblSideA = Convert.ToDouble(strUserInput);

            Console.Write("Enter the length of side B: ");
            strUserInput = Console.ReadLine();
            dblSideB = Convert.ToDouble(strUserInput);

            Console.Write("Enter the unit of measurement: ");
            strUserInput = Console.ReadLine();
            strUnit = strUserInput;

            //Process

            //Area
            DblArea = 0.5 * dblSideA * dblSideB;

                //Perimeter
                 dblSideC = Math.Sqrt(Math.Pow(dblSideA, 2) + Math.Pow(dblSideB, 2));
                dblPerimeter = dblSideA + dblSideB + dblSideC;

            //Output
            Console.WriteLine("Area: " +DblArea+strUnit+ "^2");
            Console.WriteLine("Perimeter:P " +dblPerimeter+strUnit);

            Console.ReadKey();
        }
    }
}
