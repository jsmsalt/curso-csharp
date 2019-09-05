using System;

namespace Basico
{
    class Program
    {
        static void Main(string[] args)
        {
            // DECLARACION DE VARIABLES
            int edad = 5, peso;
            string nombre, apellido;
            float altura;

            // CONDICIONAL IF
            if ( edad == 5 ) {
                // BUCLE FOR
                for (int i = 0; i < 10; i++)
                {
                    Console.WriteLine("Esto se repite 10 veces");
                }
            }

            // BUCLE WHILE
            while ( edad < 10 ) {
                Console.WriteLine("Esto se repite hasta que edad sea IGUAL a 10");
                edad++;
            }
        }
    }
}
