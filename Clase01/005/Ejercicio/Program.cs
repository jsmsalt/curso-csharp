using System;

// Ingresar 10 números enteros que pueden estar dentro de un rango de entre -100 y 100.
// Para ello realizar una clase llamada Validacion que posea un método estático llamado Validar,
// que posea la siguiente firma: bool Validar(int valor, int min, int max):
// a. valor: dato a validar
// b. min y max: rango en el cual deberá estar la variable valor.
// Terminado el ingreso mostrar el valor mínimo, el valor máximo y el promedio.
// Nota: Utilizar variables escalares, NO utilizar vectores

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int cant = 10, n = 0, min = 0, max = 0, total = 0;
            float prom;

            for (int i = 0; i < cant; i++)
            {
                do {
                    Console.WriteLine("{0}. Ingrese un numero entre -100 y 100: ", i+1);
                    n = int.Parse(Console.ReadLine());
                } while( !Validacion.Validar(n, -100, 100) );

                total += n;

                if (i == 0) {
                    max = n;
                    min = n;
                }

                if (n > max) {
                    max = n;
                }

                if (n < min) {
                    min = n;
                }
            }

            prom = (float) total / (float) cant;

            Console.WriteLine("Minimo: " + min);
            Console.WriteLine("Máximo: " + max);
            Console.WriteLine("Promedio: " + prom);
        }

        class Validacion
        {
            public static bool Validar(int valor, int min, int max)
            {
                if ( valor >= min && valor <= max )
                    return true;

                return false;
            }
        }
    }
}
