using System;
using System.Linq;
using System.Collections.Generic;
using CodingChallenge.Data.AbstractClasses;

namespace CodingChallenge.Data.Idiomas
{
    public class Ingles : Idioma
    {
        public override string ListaVacia(List<FormaGeometrica> formas)
        {
            if (!formas.Any())
                return "<h1>Empty list of shapes!</h1>";
            else
                return String.Empty;
        }

        public override string Header()
        {
            return "<h1>Shapes report</h1>";
        }

        public override string ObtenerLinea(int cantidad, double area, double perimetro, FormaGeometrica forma)
        {
            if (cantidad > 0)
                return $"{cantidad} {TraducirForma(forma, cantidad)} | Area {area:#.##} | Perimeter {perimetro:#.##} <br/>";
            else
                return string.Empty;
        }

        public override string TraducirForma(FormaGeometrica forma, int cantidad)
        {
            string resp = "";

            switch (forma.NameOf())
            {
                case "Cuadrado":
                    resp = cantidad == 1 ? "Square" : "Squares";
                    break;

                case "Circulo":
                    resp = cantidad == 1 ? "Circle" : "Circles";
                    break;

                case "TrianguloEquilatero":
                    resp = cantidad == 1 ? "Triangle" : "Triangles";
                    break;
                case "PoligonoRegular":
                    resp = cantidad == 1 ? "Polygon" : "Polygons";
                    break;
                case "Trapecio":
                    resp = cantidad == 1 ? "Trapeze" : "Trapezoids";
                    break;
                case "Rectangulo":
                    resp = cantidad == 1 ? "Rectangle" : "Rectangles";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(@"Unknown form");
            }

            return resp;
        }

        public override string GetFormas()
        {
            return "Shapes";
        }

        public override string GetPerimetro()
        {
            return "Perimeter";
        }

        public override string GetArea()
        {
            return "Area";
        }
    }
}
