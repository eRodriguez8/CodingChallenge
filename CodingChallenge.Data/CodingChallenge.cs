using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using CodingChallenge.Data.Formas;
using CodingChallenge.Data.AbstractClasses;

namespace CodingChallenge.Data
{
    public class CodingChallenge
    {
        public static string Imprimir(FormaGeometrica forma, Idioma idioma)
        {
            return CodingChallenge.Imprimir(new List<FormaGeometrica>() { forma }, idioma);
        }

        public static string Imprimir(List<FormaGeometrica> formas, Idioma idioma)
        {

            var sb = new StringBuilder();

            double areaCuadrados = 0;
            double areaCirculos = 0;
            double areaTriangulos = 0;
            double areaPoligonos = 0;
            double areaTrapecios = 0;
            double areaRectangulos = 0;
            double areaTotal = 0;

            double perimetroCuadrados = 0;
            double perimetroCirculos = 0;
            double perimetroTriangulos = 0;
            double perimetroPoligonos = 0;
            double perimetroTrapecios = 0;
            double perimetroRectangulos = 0;
            double perimetroTotal = 0;

            string esVacia = idioma.ListaVacia(formas);

            if (esVacia != String.Empty)
            {
                sb.Append(esVacia);
            }
            else
            {
                // Hay por lo menos una forma
                // HEADER
                sb.Append(idioma.Header());

                var cuadrados = formas.Where(x => x.NameOf() == typeof(Cuadrado).Name.ToString()).ToList();
                var circulos = formas.Where(x => x.NameOf() == typeof(Circulo).Name.ToString()).ToList();
                var triangulos = formas.Where(x => x.NameOf() == typeof(TrianguloEquilatero).Name.ToString()).ToList();
                var poligonos = formas.Where(x => x.NameOf() == typeof(PoligonoRegular).Name.ToString()).ToList();
                var trapecios = formas.Where(x => x.NameOf() == typeof(Trapecio).Name.ToString()).ToList();
                var rectangulos = formas.Where(x => x.NameOf() == typeof(Rectangulo).Name.ToString()).ToList();

                if (cuadrados.Count > 0)
                {
                    foreach (var cuadrado in cuadrados)
                    {
                        areaCuadrados += cuadrado.CalcularArea();
                        perimetroCuadrados += cuadrado.CalcularPerimetro();
                    }

                    sb.Append(idioma.ObtenerLinea(cuadrados.Count, areaCuadrados, perimetroCuadrados, new Cuadrado()));
                }

                if (circulos.Count > 0)
                {
                    foreach (var circulo in circulos)
                    {
                        areaCirculos += circulo.CalcularArea();
                        perimetroCirculos += circulo.CalcularPerimetro();
                    }

                    sb.Append(idioma.ObtenerLinea(circulos.Count, areaCirculos, perimetroCirculos, new Circulo()));
                }

                if (triangulos.Count > 0)
                {
                    foreach (var triangulo in triangulos)
                    {
                        areaTriangulos += triangulo.CalcularArea();
                        perimetroTriangulos += triangulo.CalcularPerimetro();
                    }

                    sb.Append(idioma.ObtenerLinea(triangulos.Count, areaTriangulos, perimetroTriangulos, new TrianguloEquilatero()));
                }

                if (poligonos.Count > 0)
                {
                    foreach (var poligono in poligonos)
                    {
                        areaPoligonos += poligono.CalcularArea();
                        perimetroPoligonos += poligono.CalcularPerimetro();
                    }

                    sb.Append(idioma.ObtenerLinea(poligonos.Count, areaPoligonos, perimetroPoligonos, new PoligonoRegular()));
                }

                if (trapecios.Count > 0)
                {
                    foreach (var trapecio in trapecios)
                    {
                        areaTrapecios += trapecio.CalcularArea();
                        perimetroTrapecios += trapecio.CalcularPerimetro();
                    }

                    sb.Append(idioma.ObtenerLinea(trapecios.Count, areaTrapecios, perimetroTrapecios, new Trapecio()));
                }

                if (rectangulos.Count > 0)
                {
                    foreach (var rectangulo in rectangulos)
                    {
                        areaRectangulos += rectangulo.CalcularArea();
                        perimetroRectangulos += rectangulo.CalcularPerimetro();
                    }

                    sb.Append(idioma.ObtenerLinea(rectangulos.Count, areaRectangulos, perimetroRectangulos, new Rectangulo()));
                }

                // FOOTER
                sb.Append("TOTAL:<br/>");

                if (cuadrados.Count > 0)
                {
                    areaTotal += areaCuadrados;
                    perimetroTotal += perimetroCuadrados;
                }
                if (circulos.Count > 0)
                {
                    areaTotal += areaCirculos;
                    perimetroTotal += perimetroCirculos;
                }
                if (triangulos.Count > 0)
                {
                    areaTotal += areaTriangulos;
                    perimetroTotal += perimetroTriangulos;
                }
                if (poligonos.Count > 0)
                {
                    areaTotal += areaPoligonos;
                    perimetroTotal += perimetroPoligonos;
                }   
                if(trapecios.Count > 0)
                {
                    areaTotal += areaTrapecios;
                    perimetroTotal += perimetroTrapecios;
                }
                if (rectangulos.Count > 0)
                {
                    areaTotal += areaRectangulos;
                    perimetroTotal += perimetroRectangulos;
                }

                sb.Append(formas.Count + " " + idioma.GetFormas() + " ");
                sb.Append(idioma.GetPerimetro() + " " + perimetroTotal.ToString("#.##") + " ");
                sb.Append(idioma.GetArea() + " " + areaTotal.ToString("#.##"));
            }

            return sb.ToString();
        }
    }
}
