using System;

// Crear la clase Moto, Automovil y Camion
// - Crear un enumerado Colores {Rojo, Blanco, Azul, Gris, Negro}
// - Camion tendrá los atributos: cantRuedas:short, cantPuertas:short, color:Colores, cantMarchas:short, pesoCarga:int
// - Automovil tendrá los atributos: cantRuedas:short, cantPuertas:short, color:Colores, cantMarchas:short, cantPasajeros:int
// - Moto tendrá los atributos: cantRuedas:short, cantPuertas:short, color:Colores, cilindrada:short
// - Crearle a cada clase un constructor que reciba todos sus atributos
// - Crear la clase VehiculoTerrestre y abstraer la informacion necesaria de las clases anteriores.
//   Luego generar una relacion de herencia entre ellas segun corresponda.
// - VehiculoTerrestre tendrá un constructor que recibira todos sus atributos.
//   Modificar las clases que heredan de esta para que lo reutilicen.
// - Generar codigo en el main y probar las clases

namespace ejercicio
{
    enum colores {Rojo, Blanco, Azul, Gris, Negro};

    class Program
    {
        static void Main(string[] args)
        {
            Automovil a = new Automovil(4,4,colores.Azul,6,4);
            Moto m = new Moto(2, 0, colores.Rojo, 150);
            Camion c = new Camion(6,2,colores.Gris,6,2000);

            Console.WriteLine("\n\nAUTOMOVIL");
            a.Mostrar();
            Console.WriteLine("\n\nMOTO");
            m.Mostrar();
            Console.WriteLine("\n\nCAMION");
            c.Mostrar();
        }
    }

    abstract class VehiculoTerrestre
    {
        public short cantidadRuedas;
        public short cantidadPuertas;
        public colores color;

        public VehiculoTerrestre()
        {
            this.cantidadRuedas = 4;
            this.cantidadPuertas = 2;
            this.color = colores.Negro;
        }

        public VehiculoTerrestre(short ruedas, short puertas, colores color)
        {
            this.cantidadRuedas = ruedas;
            this.cantidadPuertas = puertas;
            this.color = color;
        }

        public virtual void Mostrar()
        {
            Console.WriteLine("Ruedas: {0}", this.cantidadRuedas);
            Console.WriteLine("Puertas: {0}", this.cantidadPuertas);
            Console.WriteLine("Color: {0}", this.color);
        }
    }

    class Automovil: VehiculoTerrestre
    {
        public short cantidadMarchas;
        public int cantidadPasajeros;

        public Automovil()
        {
            this.cantidadMarchas = 6;
            this.cantidadPasajeros = 2;
        }

        public Automovil(short ruedas, short puertas, colores color, short marchas, int pasajeros):base(ruedas, puertas, color)
        {
            this.cantidadMarchas = marchas;
            this.cantidadPasajeros = pasajeros;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Marchas: {0}", this.cantidadMarchas);
            Console.WriteLine("Pasajeros: {0}", this.cantidadPasajeros);
        }
    }

    class Moto: VehiculoTerrestre
    {
        public short cilindrada;

        public Moto()
        {
            this.cilindrada = 150;
        }

        public Moto(short ruedas, short puertas, colores color, short cilindrada) :base(ruedas,puertas,color)
        {
            this.cilindrada = cilindrada;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Cilindrada: {0}", this.cilindrada);
        }
    }

    class Camion: VehiculoTerrestre
    {
        public short cantidadMarchas;
        public int pesoCarga;

        public Camion()
        {
            this.cantidadMarchas = 6;
            this.pesoCarga = 1000;
        }

        public Camion(short ruedas, short puertas, colores color, short marchas, int peso) :base(ruedas, puertas, color)
        {
            this.cantidadMarchas = marchas;
            this.pesoCarga = peso;
        }

        public override void Mostrar()
        {
            base.Mostrar();
            Console.WriteLine("Marchas: {0}", this.cantidadMarchas);
            Console.WriteLine("Peso de Carga: {0} kg", this.pesoCarga);
        }
    }
}
