using System;
using CodingChallenge.Data.AbstractClasses;

namespace CodingChallenge.Data.Formas
{
    public class Circulo : FormaGeometrica
    {
        private readonly double _radio;

        public Circulo() { }

        public Circulo(double radio)
        {
            _radio = radio;
        }

        public override double CalcularArea()
        {
            return Math.PI * _radio * _radio;
        }

        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * _radio;
        }
    }
}
