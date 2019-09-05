using System;

// Ingresar un número y mostrar: el cuadrado y el cubo del mismo. Se debe validar
// que el número sea mayor que cero, caso contrario, mostrar el mensaje:
// "ERROR. ¡Reingresar número!".
// Nota: Utilizar el método ‘Pow’ de la clase Math para realizar la operación.

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un número mayor que 0: ");
            int n2 = 0;

            do {
                n2 = int.Parse(Console.ReadLine());
                if ( n2 <= 0 )
                    Console.WriteLine("ERROR: Ingrese el numero muevamente...");
            } while (n2 <= 0);

            Console.WriteLine("El cuadrado de " + n2 + " es: " + Math.Pow((double) n2, 2));
            Console.WriteLine("El cubo de {0} es: {1}",n2, Math.Pow((double) n2, 3));
        }
    }
}
