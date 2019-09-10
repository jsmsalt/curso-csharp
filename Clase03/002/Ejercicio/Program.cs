using System;
using System.Collections.Generic;

// cargar 20 numeros enteros positivos y negativos distintos de cero de forma aleatoria con Random
//  - mostrar el vector en orden de ingreso
//  - mostrar los positivos de forma decreciente
//  - mostrar los negativos de forma creciente

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[20];
            List<int> positivos = new List<int>();
            List<int> negativos = new List<int>();

            Random rnd = new Random();

            Console.WriteLine("\n\nLISTA GENERADA");
            for (int i = 0; i < numeros.Length; i++)
            {
                do {
                    numeros[i] = rnd.Next(-100, 100);
                } while (numeros[i] == 0);

                if (numeros[i] > 0)
                    positivos.Add(numeros[i]);
                else
                    negativos.Add(numeros[i]);

                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("\n\nLISTA DECRECIENTE DE POSITIVOS");
            positivos.Sort((a, b) => b.CompareTo(a));
            for (int i = 0; i < positivos.Count; i++)
                Console.WriteLine(positivos[i]);

            Console.WriteLine("\n\nLISTA CRECIENTE DE NEGATIVOS");
            negativos.Sort();
            for (int i = 0; i < negativos.Count; i++)
                Console.WriteLine(negativos[i]);

        }
    }
}
