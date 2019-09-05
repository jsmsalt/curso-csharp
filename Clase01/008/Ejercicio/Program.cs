using System;

// Sobrecarga de Operadores
// Realizar una aplicación de consola. Agregar la clase Sumador.

// _cantidadSumas:int
// Sumador(int)
// Sumador()
// Sumar(long, long):long
// Sumar(string, string):string
// explicit operator int(Sumador)
// operator +(Sumador, Sumador)
// operator |(Sumador, Sumador)

// a. Crear dos constructores:
// • Sumador(int) inicializa cantidadSumas en el valor recibido por parámetros.
// • Sumador() inicializa cantidadSumas en 0. Reutilizará al primer constructor.
// b. El método Sumar incrementará cantidadSumas en 1 y adicionará sus parámetros con la
// siguiente lógica:
// • En el caso de Sumar(long, long) sumará los valores numéricos
// • En el de Sumar(string, string) concatenará las cadenas de texto.
// Antes de continuar, agregar un objeto del tipo Sumador en el Main y probar el código.
// c. Generar una conversión explícita que retorne cantidadSumas.
// d. Sobrecargar el operador + (suma) para que puedan sumar cantidadSumas y retornen un long
// con dicho valor.
// e. Sobrecargar el operador | (pipe) para que retorne True si ambos sumadores tienen igual
// cantidadSumas.
// Agregar un segundo objeto del tipo Sumador en el Main y probar el código.

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador();
            Console.WriteLine("Suma de long (3 + 5): " + s1.Sumar(3,5));
            Console.WriteLine("Suma de string ('Hola ' + 'Mundo!!'): " + s1.Sumar("Hola ","Mundo!!"));
            Console.WriteLine("Conversión explicita de Sumador a (int): " + (int) s1);

            Sumador s2 = new Sumador(2);
            Console.WriteLine("Suma de sumadores: " + (s1+s2));
            Console.WriteLine("¿Los sumadores tienen misma cant de sumas?: " + (s1 | s2));
        }
    }

    class Sumador
    {
        private int _cantidadSumas;

        public Sumador(int valor) {
            this._cantidadSumas = valor;
        }

        public Sumador():this(0) {
        }

        public long Sumar(long a, long b) {
            this._cantidadSumas++;
            return a+b;
        }

        public string Sumar(string a, string b) {
            this._cantidadSumas++;
            return a+b;
        }

        public static long operator +(Sumador a, Sumador b) {
            return a._cantidadSumas + b._cantidadSumas;
        }

        public static bool operator |(Sumador a, Sumador b) {
            return a._cantidadSumas == b._cantidadSumas;
        }

        public static explicit operator int(Sumador a) {
            return a._cantidadSumas;
        }
    }
}
