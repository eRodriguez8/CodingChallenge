using CodingChallenge.Data.AbstractClasses;
using System;

namespace CodingChallenge.Data.Formas
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        private readonly double _lado;

        public TrianguloEquilatero() { }

        public TrianguloEquilatero(double lado)
        {
            _lado = lado;
        }

        public override double CalcularArea()
        {
            return (Math.Sqrt(3) * _lado * _lado) / 4;
        }

        public override double CalcularPerimetro()
        {
            return _lado * 3;
        }
    }
}
