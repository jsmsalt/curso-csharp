using System;

namespace Objetos
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal perro = new Animal();
            Console.WriteLine("El perro se llama {0} y tiene {1} patas", perro.nombre, perro.patas);
            Animal gato = new Animal("michi", 3, "gato");
            Console.WriteLine("El gato se llama {0} y tiene {1} patas", gato.nombre, gato.patas);
        }
    }

    class Animal
    {
        public string nombre;   
        public int patas;
        private string tipo;

        public Animal() {
            this.nombre = "pepito";
            this.tipo = "perro";
            this.patas = 4;
        }

        public Animal(string nombre):this() {
            this.nombre = nombre;
        }

        public Animal(string nombre, int patas):this(nombre) {
            this.patas = patas;
        }

        public Animal(string nombre, int patas, string tipo):this(nombre, patas) {
            this.tipo = tipo;
        }

        public bool esPerro() {
            return this.tipo == "perro" ? true:false;
        }
    }
}
