using System.Collections.Generic;

namespace CodingChallenge.Data.AbstractClasses
{
    public abstract class Idioma
    {
        public abstract string ListaVacia(List<FormaGeometrica> formas);
        public abstract string Header();
        public abstract string ObtenerLinea(int cantidad, double area, double perimetro, FormaGeometrica forma);
        public abstract string TraducirForma(FormaGeometrica forma, int cantidad);
        public abstract string GetFormas();
        public abstract string GetPerimetro();
        public abstract string GetArea();
    }
}
