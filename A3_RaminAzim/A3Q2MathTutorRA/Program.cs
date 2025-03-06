/* Name: Ramin
 * Date: 03/04/25
 * Title: Math Tutor
 * Purpose: Give question for user to answer
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3Q2MathTutorRA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            Random rnd = new Random();
            int intAns, intUserAns;
            string strUser;
            int intNumOne = rnd.Next(0,11);
            int intNumTwo = rnd.Next(0, 11);
            int intOp = rnd.Next(0, 5);

            if (intOp == 1) //Basing on number generated, we give the user the operation
            {
                intAns = intNumOne + intNumTwo; //Calc answer
                Console.Write("What is " + intNumOne + " + " + intNumTwo + " = "); //Writes out
            }
            else if (intOp == 2)
            {
                intAns = intNumOne - intNumTwo;
                Console.Write("What is " + intNumOne + " - " + intNumTwo + " = ");
            }
            else if (intOp == 3)
            {
                intAns = intNumOne * intNumTwo;
                Console.Write("What is " + intNumOne + " * " + intNumTwo + " = ");
            }
            else
            {
                intAns = intNumOne / intNumTwo;
                Console.Write("What is " + intNumOne + " / " + intNumTwo + " = ");
            }

            //Input/Output
            strUser = Console.ReadLine();
            intUserAns = Int32.Parse(strUser);

            //Process
            if (intUserAns == intAns) //Checks if answer matches with real answer
            {
                Console.WriteLine("Correct");
            }
            else
            {
                Console.WriteLine("Incorrect");
            }

            Console.ReadKey();
        }
    }
}
