using CodingChallenge.Data.AbstractClasses;

namespace CodingChallenge.Data.Formas
{
    public class Rectangulo : FormaGeometrica
    {
        private readonly double _ladoCorto;
        private readonly double _ladoLargo;

        public Rectangulo() { }

        public Rectangulo(double ladoCorto, double ladoLargo)
        {
            _ladoCorto = ladoCorto;
            _ladoLargo = ladoLargo;
        }

        public override double CalcularArea()
        {
            return _ladoCorto * _ladoLargo;
        }

        public override double CalcularPerimetro()
        {
            return (_ladoLargo * 2) + (_ladoCorto * 2);
        }
    }
}
