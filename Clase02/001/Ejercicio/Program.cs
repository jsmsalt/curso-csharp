using System;

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            string respuesta, nombre;
            int antiguedad, horas, valor;
            float total, descuento;
            double totalFinal = 0;

            do {
                Console.WriteLine("\n\nNombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine("\nAmtiguedad: ");
                antiguedad = int.Parse(Console.ReadLine());
                Console.WriteLine("\nCantidad de horas trabajadas: ");
                horas = int.Parse(Console.ReadLine());
                Console.WriteLine("\nValor hora: ");
                valor = int.Parse(Console.ReadLine());

                total = (valor * horas) + (antiguedad * 150);
                descuento = (13 * total)/100;

                Console.WriteLine("\n\nEmpleado: {0}", nombre);
                Console.WriteLine("Antiguedad: {0}", antiguedad);
                Console.WriteLine("Horas trabajadas: {0}", horas);
                Console.WriteLine("Valor hora: $ {0}", valor);
                Console.WriteLine("Total bruto a cobrar: $ {0}", total);
                Console.WriteLine("Descuentos: $ {0}", descuento);
                Console.WriteLine("Total neto a cobrar: $ {0}\n", (total-descuento));

                totalFinal += (total-descuento);

                Console.WriteLine("¿Quiere ingresar más empleados? [N/s]");
                respuesta = Console.ReadLine();
            } while(respuesta == "s");

            Console.WriteLine("Total a pagar a todos los empleados: $ {0:0.00}", totalFinal);
        }
    }
}
