﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalOperatorExample
{
    class Program
    {
        static void Main(string[] args)
        {
            int value1 = 3;
            int value2 = 18;
            int value3 = -18;

            bool result0 = value1 == value2;
            Console.WriteLine("The result of value1 == value2 is: " + result0);

            bool result1 = value1 != value2;
            Console.WriteLine("The result of value1 != value2 is: " + result1);

            bool result2 = value1 > value2;
            Console.WriteLine("The result of value1 > value2 is: " + result2);

            bool result3 = value1 < value2;
            Console.WriteLine("The result of value1 < value2 is: " + result3);

            bool result4 = value1 >= value2;
            Console.WriteLine("The result of value1 >= value2 is: " + result4);

            bool result5 = value1 <= value2;
            Console.WriteLine("The result of value1 <= value2 is: " + result5);

            Console.ReadKey();
        }
    }
}
