/* Name: Ramin
 * Date: 03/04/25
 * Title: Leap Year Calculator
 * Purpose: See if year is leap year
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3Q3LeapYrRA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            string strUser;
            int intYear;

            //Input
            Console.Write("Enter Year: ");
            strUser = Console.ReadLine();
            intYear = Int32.Parse(strUser);

            //Process/Output
            if (intYear % 4 == 0 && intYear % 100 != 0) //Focuses on none 100 mults first, finds if num div by 4
            {
              Console.WriteLine("Leap Year");
            }
            else if (intYear % 100 == 0 && intYear % 400 == 0) //Then finds if 100 mults div by 400
            {
                Console.WriteLine("Leap Year");
            }
            else //Other years
            {
                Console.WriteLine("Not Leap Year"); 
            }

            Console.ReadKey();
        }
    }
}
