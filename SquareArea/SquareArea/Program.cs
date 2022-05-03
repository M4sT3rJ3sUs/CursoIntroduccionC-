using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace SquareArea
{
    class Program
    {
        static void Main(string[] args)
        {
            //rectangle area calc.

            //rectangle values
            Console.Write("Please enter the side A of the rectangle, you can use decimals: ");
            double sideA = double.Parse(Console.ReadLine());

            Console.Write("Please enter the side B of the rectangle, you can use decimals: ");
            double sideB = double.Parse(Console.ReadLine());

            //rectangle area formula is a*b
            double area = sideA * sideB;

            Console.WriteLine("The rectangle area is: " + area);

            Console.ReadKey();
        }
    }
}
