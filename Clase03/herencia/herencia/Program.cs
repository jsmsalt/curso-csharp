using System;

namespace herencia
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Padre
    {
        private int edad;
        protected string nombre;

        public Padre()
        {
            this.edad = 40;
        }

        public virtual void MostrarAlgo()
        {
            Console.WriteLine("Algo");
        }
    }

    class Hijo:Padre
    {
        public string escuela;

        public Hijo(string escuela, string nombre):base()
        {
            this.escuela = escuela;
            this.nombre = nombre;
        }

        public override void MostrarAlgo()
        {
            base.MostrarAlgo();
        }
    }
}
