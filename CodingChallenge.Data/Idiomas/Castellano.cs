using System;
using System.Linq;
using System.Collections.Generic;
using CodingChallenge.Data.AbstractClasses;

namespace CodingChallenge.Data.Idiomas
{
    public class Castellano : Idioma
    {
        public override string ListaVacia(List<FormaGeometrica> formas)
        {
            if (!formas.Any())
                return "<h1>Lista vacía de formas!</h1>";
            else
                return String.Empty;
        }

        public override string Header()
        {
            return "<h1>Reporte de Formas</h1>";
        }

        public override string ObtenerLinea(int cantidad, double area, double perimetro, FormaGeometrica forma)
        {
            if (cantidad > 0)
                return $"{cantidad} {TraducirForma(forma, cantidad)} | Area {area:#.##} | Perimetro {perimetro:#.##} <br/>";
            else
                return string.Empty;
        }

        public override string TraducirForma(FormaGeometrica forma, int cantidad)
        {
            string resp = "";

            switch (forma.NameOf())
            {
                case "Cuadrado":
                    resp = cantidad == 1 ? "Cuadrado" : "Cuadrados";
                    break;
                case "Circulo":
                    resp = cantidad == 1 ? "Círculo" : "Círculos";
                    break;
                case "TrianguloEquilatero":
                    resp = cantidad == 1 ? "Triángulo" : "Triángulos";
                    break;
                case "PoligonoRegular":
                    resp = cantidad == 1 ? "Poligono" : "Poligonos";
                    break;
                case "Trapecio":
                    resp = cantidad == 1 ? "Trapecio" : "Trapecios";
                    break;
                case "Rectangulo":
                    resp = cantidad == 1 ? "Rectangulo" : "Rectangulos";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(@"Forma desconocida");
            }

            return resp;
        }

        public override string GetFormas()
        {
            return "Formas";
        }

        public override string GetPerimetro()
        {
            return "Perimetro";
        }

        public override string GetArea()
        {
            return "Area";
        }
    }
}
