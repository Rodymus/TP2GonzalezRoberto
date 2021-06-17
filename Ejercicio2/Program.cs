using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// Crea un programa muestre los números entre el 0 y el 100, que no sean divisibles por 2. Usa un ciclo While.

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            while (num <= 100)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine(num);
                }
                
                num++;
            }
            Console.ReadKey();
        }
    }
}
