/*
 * Name: Ramin
 * Date: 02/24/25
 * Title: Trigonometry Calculator
 * Purpose: Find area perimeter of triangle
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
                Console.Write("Side A: ");
                strUserInput = Console.ReadLine();
                dblSideA = Double.Parse(strUserInput);

                Console.Write("Side B: ");
                strUserInput = Console.ReadLine();
                dblSideB = Double.Parse(strUserInput);

                Console.Write("Unit of Measurement: ");
                strUserInput = Console.ReadLine();
                strUnit = strUserInput;

            //Process

                //Area
                DblArea = 0.5 * dblSideA * dblSideB;
                DblArea = Math.Round(DblArea,2);

                //Perimeter
                dblSideC = Math.Sqrt(Math.Pow(dblSideA, 2) + Math.Pow(dblSideB, 2));
                dblPerimeter = dblSideA + dblSideB + dblSideC;
                dblPerimeter = Math.Round(dblPerimeter,2);

            //Output
                Console.WriteLine("Area: " +DblArea+strUnit+ "^2");
                Console.WriteLine("Perimeter: " +dblPerimeter+strUnit);

            Console.ReadKey();
        }
    }
}
