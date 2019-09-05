using System;

// Ingresar 5 números por consola, guardándolos en una variable escalar.
// Luego calcular y mostrar: el valor máximo, el valor mínimo y el promedio.

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant = 5, n, max = 0, min = 0, total = 0;
            float prom;

            for (int i = 0; i < cant; i++)
            {
                Console.WriteLine("Ingrese numero: ");
                n = int.Parse(Console.ReadLine());

                if (i ==0) {
                    max = n;
                    min = n;
                }

                total += n;

                if ( n > max ) {
                    max = n;
                }

                if ( n < min ) {
                    min = n;
                }
            }

            prom = (float) total / (float) cant;

            Console.WriteLine("Minimo: " + min);
            Console.WriteLine("Máximo: " + max);
            Console.WriteLine("Promedio: " + prom);
        }
    }
}
