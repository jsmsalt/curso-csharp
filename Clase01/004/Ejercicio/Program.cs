using System;

// Escribir un programa que imprima por pantalla una pirámide como la siguiente:

// *
// ***
// *****
// *******
// *********

// El usuario indicará cuál será la altura de la pirámide ingresando un número entero positivo.
// Para el ejemplo anterior la altura ingresada fue de 5.
// Nota: Utilizar estructuras repetitivas y selectivas.

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 0;

            do {
                Console.WriteLine("Ingrese un numero mayor a 0: ");
                n = int.Parse(Console.ReadLine());
            } while( n <= 0 );

            int estrellas = 1;

            for (int i = 0; i < n; i++) {
                for (int j = 0; j < estrellas; j++)
                    Console.Write("*");

                estrellas += 2; 
                Console.WriteLine("");
            }
        }
    }
}
