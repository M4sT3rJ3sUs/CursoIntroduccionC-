﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            float[] pricesArray;

            pricesArray = new float[10];
            pricesArray[0] = 1.5f;
            pricesArray[1] = 2.5f;
            pricesArray[3] = 3f;
            pricesArray[4] = 5f;

            Random rnd = new Random();
            Console.WriteLine("Hello World, of random numbers!");
            Console.WriteLine($"{rnd.Next(1, 10)}");

            Console.ReadKey();
        }
    }
}
