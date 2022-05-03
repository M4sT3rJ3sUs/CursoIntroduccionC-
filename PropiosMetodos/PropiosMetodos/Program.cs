using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropiosMetodos
{
    class Program
    {
        public float division(float a, float b)
        {
            float operacion = a / b;
            return operacion;
        }
        static void Main(string[] args)
        {
            Program metodo = new Program();
            float imprimir = metodo.division(10, 2);
            Console.WriteLine(imprimir);

            Console.ReadKey();
        }
    }
}
