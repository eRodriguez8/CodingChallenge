using System;
using System.Linq;
using System.Collections.Generic;
using CodingChallenge.Data.AbstractClasses;

namespace CodingChallenge.Data.Idiomas
{
    public class Portugues : Idioma
    {
        public override string ListaVacia(List<FormaGeometrica> formas)
        {
            if (!formas.Any())
                return "<h1>Lista vazia de formas!</h1>";
            else
                return String.Empty;
        }

        public override string Header()
        {
            return "<h1>Relatório de Formulário</h1>";
        }

        public override string ObtenerLinea(int cantidad, double area, double perimetro, FormaGeometrica forma)
        {
            if (cantidad > 0)
                return $"{cantidad} {TraducirForma(forma, cantidad)} | Área {area:#.##} | Perímetro {perimetro:#.##} <br/>";
            else
                return string.Empty;
        }

        public override string TraducirForma(FormaGeometrica forma, int cantidad)
        {
            string resp = "";

            switch (forma.NameOf())
            {
                case "Cuadrado":
                    resp = cantidad == 1 ? "Quadrado" : "Quadrados";
                    break;
                case "Circulo":
                    resp = cantidad == 1 ? "Circulo" : "Circulos";
                    break;
                case "TrianguloEquilatero":
                    resp = cantidad == 1 ? "Triângulo" : "Triangulos";
                    break;
                case "PoligonoRegular":
                    resp = cantidad == 1 ? "Poligono" : "Poligonos";
                    break;
                case "Trapecio":
                    resp = cantidad == 1 ? "Trapézio" : "Trapézios";
                    break;
                case "Rectangulo":
                    resp = cantidad == 1 ? "Retângulo" : "Retângulos";
                    break;
                default:
                    throw new ArgumentOutOfRangeException(@"Forma desconhecida");
            }

            return resp;
        }

        public override string GetFormas()
        {
            return "Formas";
        }

        public override string GetPerimetro()
        {
            return "Perímetro";
        }

        public override string GetArea()
        {
            return "Área";
        }
    }
}
