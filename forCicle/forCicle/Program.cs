using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forCicle
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0 /*condicion inicial*/; i <= 50 /* limite de repeticiones*/; i = i + 10 /*Incremento*/)
            {
                Console.WriteLine("Hello World! #{0}", i);
            }
            Console.ReadKey();
        }
    }
}
