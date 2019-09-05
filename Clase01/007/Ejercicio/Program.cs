using System;

// Crear la clase Alumno de acuerdo al siguiente diagrama:

// _nota1:byte
// _nota2:byte
// _notaFinal:float
// apellido:string
// nombre:string
// legajo:int
// Estudiar(byte, byte):void
// CalcularFinal():void
// Mostrar():void

// a. Se pide crear 3 instancias de la clase Alumno (3 objetos) en la función Main.
// Colocarle nombre, apellido y legajo a cada uno de ellos.
// b. Sólo se podrá ingresar las notas (nota1 y nota2) a través del método Estudiar.
// c. El método CalcularFinal deberá colocar la nota del final sólo si las notas 1 y 2
// son mayores o iguales a 4, caso contrario la inicializará con -1.
// Para darle un valor a la nota final utilice el método de instancia Next de la clase Random.
// d. El método Mostrar, expondrá en la consola todos los datos de los alumnos.
// La nota final se mostrará sólo si es distinto de -1, caso contrario se mostrará
// la leyenda "Alumno desaprobado".

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a1 = new Alumno("juan", "perez", 99);
            a1.Estudiar(5, 8);
            a1.CalcularFinal();
            a1.Mostrar();

            Alumno a2 = new Alumno("jose", "lopez", 99);
            a2.Estudiar(4, 6);
            a2.CalcularFinal();
            a2.Mostrar();

            Alumno a3 = new Alumno("raul", "ramirez", 34);
            a3.Estudiar(2, 10);
            a3.CalcularFinal();
            a3.Mostrar();

            // Comparación de objetos
            Console.WriteLine(a1 == a2);
        }
    }

    class Alumno
    {
        private byte _nota1, _nota2;
        private float _notaFinal;
        public string nombre, apellido;
        public int legajo;

        public Alumno(string nombre, string apellido, int legajo) {
            this.nombre = nombre;
            this.apellido = apellido;
            this.legajo = legajo;
        }

        public void Estudiar(byte n1, byte n2) {
            this._nota1 = n1;
            this._nota2 = n2;
        }

        public void CalcularFinal() {
            Random r = new Random();

            if (this._nota1 >= 4 && this._nota2 >= 4)
                this._notaFinal = r.Next(1, 10);
            else
                this._notaFinal = -1;
        }

        public void Mostrar() {
            if (this._notaFinal == -1)
                Console.WriteLine("- {0} {1} (legajo {2}) tiene notas {3}, {4}. Alumno desaprobado.", this.nombre, this.apellido, this.legajo, this._nota1, this._nota2);
            else
                Console.WriteLine("- {0} {1} (legajo {2}) tiene notas {3}, {4}, y nota final {5}", this.nombre, this.apellido, this.legajo, this._nota1, this._nota2, this._notaFinal);
        }

        public override string ToString() {
            return this.nombre + " " + this.apellido;
        }

        public static bool operator ==(Alumno a1, Alumno a2) {
            if ( a1.legajo == a2.legajo )
                return true;

            return false;
        }

        public static bool operator !=(Alumno a1, Alumno a2) {
            if ( a1.legajo == a2.legajo )
                return false;

            return true;
        }
    }
}
