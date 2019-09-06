using System;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalSuma = 0;
            char respuesta;

            do {
                Console.WriteLine("Ingrese un numero para sumar:");
                totalSuma += int.Parse(Console.ReadLine());
                Console.WriteLine("Total hasta ahora: {0}", totalSuma);

                Console.WriteLine("¿Desea continuar? [s/N]");
                respuesta = Console.ReadLine()[0];
            } while(ValidarRespuesta.ValidarS_N(respuesta));
        }
    }

    static class ValidarRespuesta
    {
        public static bool ValidarS_N(char c) {
            if(c == 's' || c == 'S')
                return true;

            return false;
        }
    }
}
