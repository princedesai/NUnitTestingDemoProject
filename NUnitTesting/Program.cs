using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NUnitDemonstration
{
    public class Program
    {
        public static void Main()
        {
            int firstAngle = 0, secondAngle = 0, thirdAngle = 0;
            string customTriangle;


            Console.Write("\n\n");
            Console.Write("Check whether a triangle can be formed by the given angles\n");
            Console.Write("--------------------------------------------------------\n");
            Console.Write("This program only takes in positive integers greater than 0");
            Console.Write("\n\n");

            Console.WriteLine("Please Enter the first angle of the triangle: ");
            while (!int.TryParse(Console.ReadLine(), out firstAngle))
            {
                Console.WriteLine("Please Enter a valid integer value!");

            }

            Console.WriteLine("Please Enter the second angle of the triangle: ");
            while (!int.TryParse(Console.ReadLine(), out secondAngle))
            {
                Console.WriteLine("Please Enter a valid integer value!");

            }

            Console.WriteLine("Please Enter the third angle of the triangle: ");
            while (!int.TryParse(Console.ReadLine(), out thirdAngle))
            {
                Console.WriteLine("Please Enter a valid integer value!");

            }


            customTriangle = Triangle.ValidTriangle(firstAngle, secondAngle, thirdAngle);

            Console.WriteLine(customTriangle);
            Console.ReadLine();

        }
    }
}