/* Name: Ramin
 * Date: 03/04/25
 * Title: Number Multiplier Checker
 * Purpose: Check if given numbers are multiples
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3Q5NumMultRA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            string strUser;
            int intNumOne, intNumTwo;

            //Input
            Console.Write("Number 1: ");
            strUser = Console.ReadLine();
            intNumOne = Int32.Parse(strUser);

            Console.Write("Number 2: ");
            strUser = Console.ReadLine();
            intNumTwo = Int32.Parse(strUser);

            //Process/Output
            if (intNumOne % intNumTwo == 0 ||  intNumTwo % intNumOne ==0) //If given numbers divided have no remainder in any of the two arguments, then they are multiples
            {
                Console.WriteLine("Multiples");
            }
            else
            {
                Console.WriteLine("Not Multiples");
            }

            Console.ReadKey();
        }
    }
}
