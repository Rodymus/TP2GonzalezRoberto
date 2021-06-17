using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2GonzalezRoberto
{
    class Program
    {
        static void Main(string[] args)
        {
            float iva, precio, resultado;
            
            Console.WriteLine("Ingresa el valor de producto: ");
            precio = float.Parse(Console.ReadLine());
            iva = precio * 0.21f;
            resultado = precio + iva;
            
            Console.WriteLine("El precio con iva es: " + resultado);
            Console.ReadLine();

        }
    }
}
