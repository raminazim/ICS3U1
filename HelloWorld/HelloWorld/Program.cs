/*
* Name: Ramin 
* Date: 02/20/25
* Title: Hello World
* Purpose: 🤷‍
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaration
            string strUserInput;
            string strName;
            int intFishOne;
            int intFishTwo;
            int intFishTotal;

            // Input
            Console.WriteLine("How many fish on tree 1: ");
            strUserInput = Console.ReadLine();
            intFishOne = Int32.Parse(strUserInput);
            Console.WriteLine("How many fish on tree 2: ");
            strUserInput = Console.ReadLine();
            intFishTwo = Int32.Parse(strUserInput);
            Console.WriteLine("Name: ");
            strUserInput = Console.ReadLine();
            strName = strUserInput;
            // Process
            intFishTotal = intFishOne + intFishTwo;
            // Output
            Console.WriteLine("Hello " +strName);
            Console.WriteLine("There are " +intFishTotal+ " in the two trees.");

            Console.ReadKey();
        }
    }
}
