using System;

namespace Ejercicio
{
    using Clases;

    class Program
    {
        static void Main(string[] args)
        {
            Boligrafo b1 = new Boligrafo(100, ConsoleColor.Blue);
            b1.SetTinta(-95);
            Console.WriteLine("\n\nDIBUJANDO CON BOLIGRAFO 1");
            Console.WriteLine("Cantidad restante de tinta: " + b1.GetTinta());
            b1.Pintar(10, out string dibujo1);
            Console.WriteLine("Cantidad restante de tinta: " + b1.GetTinta());
            Console.ForegroundColor = b1.GetColor();
            Console.WriteLine(dibujo1);

            Console.ResetColor();

            Boligrafo b2 = new Boligrafo(50, ConsoleColor.Red);
            b2.SetTinta(-10);
            Console.WriteLine("\n\nDIBUJANDO CON BOLIGRAFO 2");
            Console.WriteLine("Cantidad restante de tinta: " + b2.GetTinta());
            b2.Pintar(3, out string dibujo2);
            Console.WriteLine("Cantidad restante de tinta: " + b2.GetTinta());
            Console.ForegroundColor = b2.GetColor();
            Console.WriteLine(dibujo2);

            Console.ResetColor();
        }
    }
}

namespace Clases
{
    class Boligrafo
    {
        public static short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo() {
            this.tinta = cantidadTintaMaxima;
        }

        public Boligrafo(short t):this() {
            this.tinta = t;
        }

        public Boligrafo(short t, ConsoleColor c):this(t) {
            this.color = c;
        }

        public ConsoleColor GetColor() {
            return this.color;
        }

        public short GetTinta() {
            return this.tinta;
        }

        public void Recargar() {
            short relleno = (short) (cantidadTintaMaxima - this.GetTinta());
            this.SetTinta(relleno);
        }

        public bool SetTinta(short t) {
            int nuevoValor = this.tinta + t;
            if (nuevoValor >= 0 && nuevoValor <= cantidadTintaMaxima)
            {
                this.tinta += t;
                return true;
            }

            return false;
        }

        public bool Pintar(short t, out string dibujo) {
            bool r = true;
            string d = "";

            for (int i = 0; i < t; i++)
            {
                if (this.GetTinta() > 0)
                {
                    d += "* ";
                    this.SetTinta(-1);
                } else {
                    Console.WriteLine("Tinta insuficiente!");
                    r = false;
                    break;
                }
            }

            dibujo = d;
            return r;
        }
    }
}
