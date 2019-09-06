using System;

//Crear tres clases: Fahrenheit, Celsius y Kelvin.Teniendo en cuenta que:

//F = C* (9/5) + 32
//C = (F-32) * 5/9
//F = K* 9/5 – 459.67
//K = (F + 459.67) * 5/9

//a.Se debe lograr que los objetos de estas clases se puedan sumar, restar y comparar entre sí.
//b.Sobrecargar los operadores explicit y/o implicit para lograr compatibilidad entre los distintos
//tipos de datos.
//c.Colocar dentro del Main el código necesario para probar todos los métodos.
//d.Los comparadores == compararan cantidades.
//e.Reutilizar el código.Sólo realizar las conversiones dentro de los operadores para dicho uso.
//f.El método GetCantidad es estático.

namespace Ejercicio
{
    class Program
    {
        static void Main(string[] args)
        {
            Celcius c = new Celcius(100);
            Kelvin k = new Kelvin(100);
            Fahrenheit f = new Fahrenheit(100);

            Console.WriteLine("\nCELCIUS");
            Console.WriteLine("{0}°C = {1:#.##}°K", c.getCantidad(), ((Kelvin)c).getCantidad());
            Console.WriteLine("{0}°C = {1:#.##}°F", c.getCantidad(), ((Fahrenheit)c).getCantidad());

            Console.WriteLine("\nKELVIN");
            Console.WriteLine("{0}°K = {1:#.##}°C", k.getCantidad(), ((Celcius)k).getCantidad());
            Console.WriteLine("{0}°K = {1:#.##}°F", k.getCantidad(), ((Fahrenheit)k).getCantidad());

            Console.WriteLine("\nFAHRENHEIT");
            Console.WriteLine("{0}°F = {1:#.##}°K", f.getCantidad(), ((Kelvin)f).getCantidad());
            Console.WriteLine("{0}°F = {1:#.##}°C", f.getCantidad(), ((Celcius)f).getCantidad());

            Console.WriteLine("\nCOMPARACIONES");
            f = new Fahrenheit(212);
            Console.WriteLine("¿{0}°C == {1}°F? = {2}", c.getCantidad(),f.getCantidad(), c==f);
            f = new Fahrenheit(211);
            Console.WriteLine("¿{0}°C == {1}°F? = {2}", c.getCantidad(), f.getCantidad(), c == f);
            f = new Fahrenheit(-279.67);
            Console.WriteLine("¿{1}°K == {0}°F? = {2}", f.getCantidad(), k.getCantidad(), f == k);
            f = new Fahrenheit(-279.66);
            Console.WriteLine("¿{1}°K == {0}°F? = {2}", f.getCantidad(), k.getCantidad(), f == k);
        }
    }

    class Kelvin
    {
        private double _cantidad;
        public Kelvin()
        {
            this._cantidad = 100;
        }

        public Kelvin(double cantidad)
        {
            this._cantidad = cantidad;
        }

        public double getCantidad()
        {
            return this._cantidad;
        }

        public static explicit operator Fahrenheit(Kelvin k)
        {
            return new Fahrenheit(k.getCantidad() * ((float)9 / 5) - 459.67);
        }

        public static explicit operator Celcius(Kelvin k)
        {
            Fahrenheit f = (Fahrenheit)k;
            return new Celcius((f.getCantidad() - 32) * ((float)5 / 9));
        }

        public static bool operator ==(Kelvin k, Fahrenheit f)
        {
            Kelvin k2 = (Kelvin)f;
            return (Math.Abs(k.getCantidad() - k2.getCantidad()) < 0.001);
        }

        public static bool operator !=(Kelvin k, Fahrenheit f)
        {
            Kelvin k2 = (Kelvin)f;
            return (Math.Abs(k.getCantidad() - k2.getCantidad()) > 0.001);
        }

        public static bool operator ==(Kelvin k, Celcius c)
        {
            Kelvin k2 = (Kelvin)c;
            return (Math.Abs(k.getCantidad() - k2.getCantidad()) < 0.001);
        }

        public static bool operator !=(Kelvin k, Celcius c)
        {
            Kelvin k2 = (Kelvin)c;
            return (Math.Abs(k.getCantidad() - k2.getCantidad()) > 0.001);
        }

        public static bool operator ==(Kelvin k, Kelvin k2)
        {
            return (Math.Abs(k.getCantidad() - k2.getCantidad()) < 0.001);
        }

        public static bool operator !=(Kelvin k, Kelvin k2)
        {
            return (Math.Abs(k.getCantidad() - k2.getCantidad()) > 0.001);
        }

        public static Kelvin operator +(Kelvin k, Fahrenheit f)
        {
            Kelvin k2 = (Kelvin)f;
            double cantidad = k.getCantidad() + k2.getCantidad();
            return new Kelvin(cantidad);
        }

        public static Kelvin operator -(Kelvin k, Fahrenheit f)
        {
            Kelvin k2 = (Kelvin)f;
            double cantidad = k.getCantidad() - k2.getCantidad();
            return new Kelvin(cantidad);
        }

        public static Kelvin operator +(Kelvin k, Celcius c)
        {
            Kelvin k2 = (Kelvin)c;
            double cantidad = k.getCantidad() + k2.getCantidad();
            return new Kelvin(cantidad);
        }

        public static Kelvin operator -(Kelvin k, Celcius c)
        {
            Kelvin k2 = (Kelvin)c;
            double cantidad = k.getCantidad() - k2.getCantidad();
            return new Kelvin(cantidad);
        }

        public static Kelvin operator +(Kelvin k, Kelvin k2)
        {
            double cantidad = k.getCantidad() + k2.getCantidad();
            return new Kelvin(cantidad);
        }

        public static Kelvin operator -(Kelvin k, Kelvin k2)
        {
            double cantidad = k.getCantidad() - k2.getCantidad();
            return new Kelvin(cantidad);
        }

        public override bool Equals(object obj)
        {
            Kelvin o = (Kelvin)obj;
            if (ReferenceEquals(null, o)) return false;
            if (ReferenceEquals(this, o)) return true;
            return (Math.Abs(this.getCantidad() - o.getCantidad()) < 0.001);
        }

        public override int GetHashCode()
        {
            return this.getCantidad().GetHashCode();
        }
    }

    class Fahrenheit
    {
        private double _cantidad;
        public Fahrenheit()
        {
            this._cantidad = 100;
        }

        public Fahrenheit(double cantidad)
        {
            this._cantidad = cantidad;
        }

        public double getCantidad()
        {
            return this._cantidad;
        }

        public static explicit operator Celcius(Fahrenheit f)
        {
            return new Celcius((f.getCantidad() - 32) * ((float)5 / 9));
        }

        public static explicit operator Kelvin(Fahrenheit f)
        {
            return new Kelvin((f.getCantidad() + 459.67) * ((float)5 / 9));
        }

        public static bool operator ==(Fahrenheit f, Celcius c)
        {
            Fahrenheit f2 = (Fahrenheit)c;
            return (Math.Abs(f.getCantidad() - f2.getCantidad()) < 0.001);
        }

        public static bool operator !=(Fahrenheit f, Celcius c)
        {
            Fahrenheit f2 = (Fahrenheit)c;
            return (Math.Abs(f.getCantidad() - f2.getCantidad()) > 0.001);
        }

        public static bool operator ==(Fahrenheit f, Kelvin k)
        {
            Fahrenheit f2 = (Fahrenheit)k;
            return (Math.Abs(f.getCantidad() - f2.getCantidad()) < 0.001);
        }

        public static bool operator !=(Fahrenheit f, Kelvin k)
        {
            Fahrenheit f2 = (Fahrenheit)k;
            return (Math.Abs(f.getCantidad() - f2.getCantidad()) > 0.001);
        }

        public static bool operator ==(Fahrenheit f, Fahrenheit f2)
        {
            return (Math.Abs(f.getCantidad() - f2.getCantidad()) < 0.001);
        }

        public static bool operator !=(Fahrenheit f, Fahrenheit f2)
        {
            return (Math.Abs(f.getCantidad() - f2.getCantidad()) > 0.001);
        }

        public static Fahrenheit operator +(Fahrenheit f, Celcius c)
        {
            Fahrenheit f2 = (Fahrenheit)c;
            double cantidad = f.getCantidad() + f2.getCantidad();
            return new Fahrenheit(cantidad);
        }

        public static Fahrenheit operator -(Fahrenheit f, Celcius c)
        {
            Fahrenheit f2 = (Fahrenheit)c;
            double cantidad = f.getCantidad() - f2.getCantidad();
            return new Fahrenheit(cantidad);
        }

        public static Fahrenheit operator +(Fahrenheit f, Kelvin k)
        {
            Fahrenheit f2 = (Fahrenheit)k;
            double cantidad = f.getCantidad() + f2.getCantidad();
            return new Fahrenheit(cantidad);
        }

        public static Fahrenheit operator -(Fahrenheit f, Kelvin k)
        {
            Fahrenheit f2 = (Fahrenheit)k;
            double cantidad = f.getCantidad() - f2.getCantidad();
            return new Fahrenheit(cantidad);
        }

        public static Fahrenheit operator +(Fahrenheit f, Fahrenheit f2)
        {
            double cantidad = f.getCantidad() + f2.getCantidad();
            return new Fahrenheit(cantidad);
        }

        public static Fahrenheit operator -(Fahrenheit f, Fahrenheit f2)
        {
            double cantidad = f.getCantidad() - f2.getCantidad();
            return new Fahrenheit(cantidad);
        }

        public override bool Equals(object obj)
        {
            Fahrenheit o = (Fahrenheit)obj;
            if (ReferenceEquals(null, o)) return false;
            if (ReferenceEquals(this, o)) return true;
            return (Math.Abs(this.getCantidad() - o.getCantidad()) < 0.001);
        }

        public override int GetHashCode()
        {
            return this.getCantidad().GetHashCode();
        }
    }

    class Celcius
    {
        private double _cantidad;
        public Celcius()
        {
            this._cantidad = 100;
        }

        public Celcius(double cantidad)
        {
            this._cantidad = cantidad;
        }

        public double getCantidad()
        {
            return this._cantidad;
        }

        public static explicit operator Fahrenheit(Celcius c)
        {
            return new Fahrenheit((c.getCantidad() * ((float)9 / 5)) + 32);
        }

        public static explicit operator Kelvin(Celcius c)
        {
            Fahrenheit f = (Fahrenheit)c;
            return new Kelvin((f.getCantidad() + 459.67) * ((float)5 / 9));
        }

        public static bool operator ==(Celcius c, Fahrenheit f)
        {
            Celcius c2 = (Celcius)f;
            return (Math.Abs(c.getCantidad() - c2.getCantidad()) < 0.001);
        }

        public static bool operator !=(Celcius c, Fahrenheit f)
        {
            Celcius c2 = (Celcius)f;
            return (Math.Abs(c.getCantidad() - c2.getCantidad()) > 0.001);
        }

        public static bool operator ==(Celcius c, Kelvin k)
        {
            Celcius c2 = (Celcius)k;
            return (Math.Abs(c.getCantidad() - c2.getCantidad()) < 0.001);
        }

        public static bool operator !=(Celcius c, Kelvin k)
        {
            Celcius c2 = (Celcius)k;
            return (Math.Abs(c.getCantidad() - c2.getCantidad()) > 0.001);
        }

        public static Celcius operator +(Celcius c, Fahrenheit f)
        {
            Celcius c2 = (Celcius)f;
            double cantidad = c.getCantidad() + c2.getCantidad();
            return new Celcius(cantidad);
        }

        public static Celcius operator -(Celcius c, Fahrenheit f)
        {
            Celcius c2 = (Celcius)f;
            double cantidad = c.getCantidad() - c2.getCantidad();
            return new Celcius(cantidad);
        }

        public static Celcius operator +(Celcius c, Kelvin k)
        {
            Celcius c2 = (Celcius)k;
            double cantidad = c.getCantidad() + c2.getCantidad();
            return new Celcius(cantidad);
        }

        public static Celcius operator -(Celcius c, Kelvin k)
        {
            Celcius c2 = (Celcius)k;
            double cantidad = c.getCantidad() - c2.getCantidad();
            return new Celcius(cantidad);
        }

        public static Celcius operator +(Celcius c, Celcius c2)
        {
            double cantidad = c.getCantidad() + c2.getCantidad();
            return new Celcius(cantidad);
        }

        public static Celcius operator -(Celcius c, Celcius c2)
        {
            double cantidad = c.getCantidad() - c2.getCantidad();
            return new Celcius(cantidad);
        }

        public override bool Equals(object obj)
        {
            Celcius o = (Celcius)obj;
            if (ReferenceEquals(null, o)) return false;
            if (ReferenceEquals(this, o)) return true;
            return (Math.Abs(this.getCantidad() - o.getCantidad()) < 0.001);
        }

        public override int GetHashCode()
        {
            return this.getCantidad().GetHashCode();
        }
    }
}
