using CodingChallenge.Data.AbstractClasses;
using System;

namespace CodingChallenge.Data.Formas
{
    public class Trapecio : FormaGeometrica
    {
        private readonly double _baseMenor;
        private readonly double _baseMayor;
        private readonly double _altura;

        public Trapecio() { }

        public Trapecio(double baseMenor, double baseMayor, double altura)
        {
            _baseMenor = baseMenor;
            _baseMayor = baseMayor;
            _altura = altura;
        }

        public override double CalcularArea()
        {
            return (_baseMayor + _baseMenor) / 2 * _altura;
        }

        public override double CalcularPerimetro()
        {
            double baseTriangulo = (_baseMayor - _baseMenor) / 2;
            double ladoFaltante = Math.Sqrt((baseTriangulo * baseTriangulo) + (_altura * _altura));
            return _baseMenor + _baseMayor + (ladoFaltante * 2);
        }
    }
}
