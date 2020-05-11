using CodingChallenge.Data.AbstractClasses;

namespace CodingChallenge.Data.Formas
{
    public class PoligonoRegular : FormaGeometrica
    {
        private readonly double _lado;
        private readonly double _apotema;
        private readonly double _n;

        public PoligonoRegular() { }

        public PoligonoRegular(double n, double apotema, double lado)
        {
            _lado = lado;
            _apotema = apotema;
            _n = n;
        }

        public override double CalcularArea()
        {
            return (CalcularPerimetro() * _apotema) / 2;
        }

        public override double CalcularPerimetro()
        {
            return _lado * _n;
        }
    }
}
