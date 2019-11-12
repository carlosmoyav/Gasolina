using System;
namespace CarlosMoya3B.clases
{
    public class gasolina
    {
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

        private int cantidadgalones;

        public int Cantidadgalones
        {
            get { return cantidadgalones; }
            set { cantidadgalones = value; }
        }

        private double prventa;

        public double Prventa
        {
            get { return prventa; }
            set { prventa = value; }
        }
    }
}
