using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Crear la función para el ejercicio 1 que se llame CalcularIVA,
//la cual debe recibir un parámetro de tipo numérico y devolver el valor Final con IVA.

namespace Ejercicio3
{
    class Program
    {        
        static void Main(string[] args)
        {
            float precio;
            Console.WriteLine("Ingresa el valor de producto: ");
            precio = float.Parse(Console.ReadLine());

            CalcularIVA(precio);

            Console.ReadLine();
        }

        float CalcularIVA(float A)
        {
            float resultado = A + (A * 0.21f);
            Console.WriteLine("El precio con iva es: " + resultado);
            
        }
    }
}
