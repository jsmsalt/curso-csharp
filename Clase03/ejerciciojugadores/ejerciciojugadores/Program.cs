using System;
using System.Collections.Generic;

namespace ejerciciojugadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    class Equipo
    {
        private int cantidadDeJugadores;
        private List<Jugador> jugadores;
        private string nombre;

        public Equipo()
        {

        }

        public Equipo(short cantJugadores, string nombre)
        {
            this.cantidadDeJugadores = cantJugadores;
            this.nombre = nombre;
        }

        public void agregarJugador(Jugador j)
        {
            this.jugadores.Add(j);
        }

        public static Equipo operator +(Equipo e, Jugador j)
        {
            e.agregarJugador(j);
            return e;
        }

        public override string ToString()
        {
            return "EQUIPO\nNombre: " + this.nombre + "\nCant Jugadores: " + this.cantidadDeJugadores;
        }
    }

    class Jugador
    {

    }
}
