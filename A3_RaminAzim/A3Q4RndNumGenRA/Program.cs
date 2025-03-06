/* Name: Ramin
 * Date: 03/04/25
 * Title: Random Number Generator
 * Purpose: Generate random numbers from given range
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3Q4RndNumGenRA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            Random rnd = new Random();
            string strUser;
            int intNumOne, intNumTwo, intLow, intHigh;
            int intRndOne, intRndTwo, intRndThree, intRndLow, intRndHigh;

            //Input
            Console.Write("Enter Number 1: ");
            strUser = Console.ReadLine();
            intNumOne = Int32.Parse(strUser);

            Console.Write("Enter Number 2: ");
            strUser = Console.ReadLine();
            intNumTwo = Int32.Parse(strUser);

            //Process/Output
            if (intNumOne > intNumTwo) { //Finds whhich number is bigger
                intLow = intNumTwo;
                intHigh = intNumOne;
            }
            else
            {
                intLow = intNumOne;
                intHigh = intNumTwo;
            }
            
            if(intHigh - intLow > 2) //Checks difference
            {
                intRndOne = rnd.Next(intLow, intHigh); //Generates num
                intRndTwo = rnd.Next(intLow, intHigh);
                intRndThree = rnd.Next(intLow, intHigh);

                Console.WriteLine("Numbers: " + intRndOne + ", " + intRndTwo + ", " + intRndThree); //Outputs num

                if (intRndOne < intRndTwo && intRndOne < intRndThree) //If tested number falls true, then lowest number given, or else goes to next number
                {
                    intRndLow = intRndOne;
                }
                else if (intRndTwo < intRndOne && intRndTwo < intRndThree)
                {
                    intRndLow = intRndTwo;
                }
                else
                {
                    intRndLow = intRndThree;
                }

                if (intRndOne > intRndTwo && intRndOne > intRndThree) //If tested number falls true, then highest number given, or else goes to next number
                {
                    intRndHigh = intRndOne;
                }
                else if (intRndTwo > intRndOne && intRndTwo > intRndThree)
                {
                    intRndHigh = intRndTwo;
                }
                else
                {
                    intRndHigh = intRndThree;
                }

                Console.WriteLine("Min Num: " + intRndLow); //Outputs
                Console.WriteLine("Max Num: " + intRndHigh);

            }
            else
            {
                Console.WriteLine("Difference is < 2");
            }

            Console.ReadKey();
        }
    }
}
