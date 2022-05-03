using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListBands
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rock and Metal bands list");

            string[] BandLists = { "mayhem", "iron MaidEN", "AmON AMARTH", "BaTHORY", "Scorpions",
            "JUDAS PRIEST", "PINK FLOYD", "megadeth", "transMetal", "helloween" };
            int Counter;
            char PrevChar = '\0';
            foreach (string Band in BandLists)
            {
                Counter = 0;
                foreach (char BandPart in Band)
                {
                    if (Counter == 0 || PrevChar == ' ')
                        Console.Write(char.ToUpper(BandPart));
                    else
                        Console.Write(char.ToLower(BandPart));
                    Counter++;
                    PrevChar = BandPart;
                }
                Console.Read();
        }   }
    }
}
