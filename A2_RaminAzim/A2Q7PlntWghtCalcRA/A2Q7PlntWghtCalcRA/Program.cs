/*
 * Name: Ramin 
 * Date: 02/24/25
 * Title: Planet Weight Calculator
 * Purpose: Find weight on other planets
 */
using System;

namespace A2Q7PlntWghtCalcRA
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaration
                string strUserName;
                double dblUserWeight,dblMercuryWeight, dblVenusWeight, dblEarthWeight, dblMarsWeight, dblJupiterWeight, dblSaturnWeight, dblUranusWeight, dblNeptuneWeight, dblPlutoWeight;

                // Gravity Constants
                double dblMercuryGravity = 0.38;
                double dblVenusGravity = 0.91;
                double dblEarthGravity = 1.0;
                double dblMarsGravity = 0.38;
                double dblJupiterGravity = 2.6;
                double dblSaturnGravity = 1.1;
                double dblUranusGravity = 0.90;
                double dblNeptuneGravity = 1.1;
                double dblPlutoGravity = 0.07;

            // Input
                Console.Write("Name: ");
                strUserName = Console.ReadLine();

                Console.Write("Weight (Kg): ");
                dblUserWeight = double.Parse(Console.ReadLine());

            // Process
                dblMercuryWeight = dblUserWeight * dblMercuryGravity;
                dblVenusWeight = dblUserWeight * dblVenusGravity;
                dblEarthWeight = dblUserWeight * dblEarthGravity;
                dblMarsWeight = dblUserWeight * dblMarsGravity;
                dblJupiterWeight = dblUserWeight * dblJupiterGravity;
                dblSaturnWeight = dblUserWeight * dblSaturnGravity;
                dblUranusWeight = dblUserWeight * dblUranusGravity;
                dblNeptuneWeight = dblUserWeight * dblNeptuneGravity;
                dblPlutoWeight = dblUserWeight * dblPlutoGravity;

            // Output
                Console.WriteLine("Hello, " +strUserName+ ", your weight on:");
                Console.WriteLine("Mercury: " + dblMercuryWeight + "kg");
                Console.WriteLine("Venus: " + dblVenusWeight + "kg");
                Console.WriteLine("Earth: " + dblEarthWeight + "kg");
                Console.WriteLine("Mars: " + dblMarsWeight + "kg");
                Console.WriteLine("Jupiter: " + dblJupiterWeight + "kg");
                Console.WriteLine("Saturn: " + dblSaturnWeight + "kg");
                Console.WriteLine("Uranus: " + dblUranusWeight + "kg");
                Console.WriteLine("Neptune: " + dblNeptuneWeight + "kg");
                Console.WriteLine("Pluto: " + dblPlutoWeight + "kg");

            Console.ReadKey();
        }
    }
}
