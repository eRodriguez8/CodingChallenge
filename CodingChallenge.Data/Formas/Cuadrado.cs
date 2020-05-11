using CodingChallenge.Data.AbstractClasses;
using System.Collections.Generic;
using System.Linq;
using System;

namespace CodingChallenge.Data.Formas
{
    public class Cuadrado : FormaGeometrica
    {
        private readonly double _lado;

        public Cuadrado() { }

        public Cuadrado(double lado)
        {
            _lado = lado;
        }

        public override double CalcularArea()
        {
            return _lado * _lado;
        }

        public override double CalcularPerimetro()
        {
            return _lado * 4;
        }
    }
}
