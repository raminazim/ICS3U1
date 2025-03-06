/* Name: Ramin
 * Date: 03/04/25
 * Title: GPA Calculator
 * Purpose: Calculate GPA from given %
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3Q6GPACalcRA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            string strUser;
            int intGrade;

            //Input
            Console.Write("Enter Grade (%): ");
            strUser = Console.ReadLine();
            intGrade = Int32.Parse(strUser);

            //Process/Output

            if (intGrade >= 90) //If grade if above thresehold, give user deserved output based on given, else, goes below
            {
                Console.WriteLine("Letter Grade: A+");
                Console.WriteLine("GPA: 4.0");
                Console.WriteLine("Excellent");
            }
            else if (intGrade >= 85)
            {
                Console.WriteLine("Letter Grade: A");
                Console.WriteLine("GPA: 4.0");
                Console.WriteLine("Excellent");
            }
            else if (intGrade >= 80)
            {
                Console.WriteLine("Letter Grade: A-");
                Console.WriteLine("GPA: 3.7");
                Console.WriteLine("Excellent");
            }
            else if (intGrade >= 77)
            {
                Console.WriteLine("Letter Grade: B+");
                Console.WriteLine("GPA: 3.3");
                Console.WriteLine("Good");
            }
            else if (intGrade >= 73)
            {
                Console.WriteLine("Letter Grade: B");
                Console.WriteLine("GPA: 3.0");
                Console.WriteLine("Good");
            }
            else if (intGrade >= 70)
            {
                Console.WriteLine("Letter Grade: B-");
                Console.WriteLine("GPA: 2.7");
                Console.WriteLine("Good");
            }
            else if (intGrade >= 67)
            {
                Console.WriteLine("Letter Grade: C+");
                Console.WriteLine("GPA: 2.3");
                Console.WriteLine("Adequate");
            }
            else if (intGrade >= 63)
            {
                Console.WriteLine("Letter Grade: C");
                Console.WriteLine("GPA: 2.0");
                Console.WriteLine("Adequate");
            }
            else if (intGrade >= 60)
            {
                Console.WriteLine("Letter Grade: C-");
                Console.WriteLine("GPA: 1.7");
                Console.WriteLine("Adequate");
            }
            else if (intGrade >= 57)
            {
                Console.WriteLine("Letter Grade: D+");
                Console.WriteLine("GPA: 1.3");
                Console.WriteLine("Marginal");
            }
            else if (intGrade >= 53)
            {
                Console.WriteLine("Letter Grade: D");
                Console.WriteLine("GPA: 1.0");
                Console.WriteLine("Marginal");
            }
            else if (intGrade >= 50)
            {
                Console.WriteLine("Letter Grade: D-");
                Console.WriteLine("GPA: 0.7");
                Console.WriteLine("Marginal");
            }
            else
            {
                Console.WriteLine("Letter Grade: F");
                Console.WriteLine("GPA: 0.0");
                Console.WriteLine("Inadequate");
            }

            Console.ReadKey();
        }
    }
}
