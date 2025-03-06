/* Name: Ramin
 * Date: 03/04/25
 * Title: Number Classification
 * Purpose: Classify numbers by even/odd, +/0/-
 */ 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3Q1NumClassRA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            string strUserInput;
            int intNum;

            //Input
            Console.Write("Enter Number: ");
            strUserInput = Console.ReadLine();
            intNum = Int32.Parse(strUserInput);

            //Process/32
            //Output
            if (intNum%2 == 0) //If div 2 no remain, then even
            {
                Console.WriteLine("Even");
            }
            else
            {
                Console.WriteLine("Odd");
            }

            if (intNum > 0) //Checks value relative to 0
            {
                Console.WriteLine("Positive");
            }
            else if (intNum < 0)
            {
                Console.WriteLine("Negative");
            }
            else
            {
                Console.WriteLine("Zero");
            }

            Console.ReadKey();
        }
    }
}
