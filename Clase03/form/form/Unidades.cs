using System;
namespace Unidades
{
    public class Metro
    {
        private float _valor;

        public Metro()
        {

        }

        public Metro(float valor)
        {
            this._valor = valor;
        }

        public float getValor()
        {
            return this._valor;
        }

        public static explicit operator Centimetro(Metro m)
        {
            return new Centimetro(m.getValor() * 100);
        }
    }

    public class Centimetro
    {
        private float _valor;

        public Centimetro()
        {

        }

        public Centimetro(float valor)
        {
            this._valor = valor;
        }

        public float getValor()
        {
            return this._valor;
        }

        public static explicit operator Metro(Centimetro c)
        {
            return new Metro(c.getValor() / 100);
        }
    }
}
