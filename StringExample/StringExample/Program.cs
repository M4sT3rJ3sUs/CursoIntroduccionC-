using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What's your name? Please write your full name!");
            var fullUserName = Console.ReadLine();
            Console.WriteLine("Hello " + fullUserName + ", Welcome to Platzi");

            Console.ReadKey();
        }
    }
}
