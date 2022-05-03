using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");
            int height = 170;
            int age = 20;
            string name = "Ricardo Celis";
            string information = "the requested info is:\n User name" + name + "\n user age "
            + age + " \n user height" + height;
            Console.WriteLine(information);
            Console.ReadKey();
        }
    }
}
