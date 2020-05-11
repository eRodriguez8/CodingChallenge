using System.Collections.Generic;
using CodingChallenge.Data.Formas;
using NUnit.Framework;
using CodingChallenge.Data.AbstractClasses;
using CodingChallenge.Data.Idiomas;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                CodingChallenge.Imprimir(new List<FormaGeometrica>(), new Castellano()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                CodingChallenge.Imprimir(new List<FormaGeometrica>(), new Ingles()));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnPortugues()
        {
            Assert.AreEqual("<h1>Lista vazia de formas!</h1>",
                CodingChallenge.Imprimir(new List<FormaGeometrica>(), new Portugues()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var resumen = CodingChallenge.Imprimir(new Cuadrado(5), new Castellano());
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 Formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoEnIngles()
        {
            var resumen = CodingChallenge.Imprimir(new Cuadrado(5), new Ingles());
            Assert.AreEqual("<h1>Shapes report</h1>1 Square | Area 25 | Perimeter 20 <br/>TOTAL:<br/>1 Shapes Perimeter 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnCuadradoEnPortugues()
        {
            var resumen = CodingChallenge.Imprimir(new Cuadrado(5), new Portugues());
            Assert.AreEqual("<h1>Relatório de Formulário</h1>1 Quadrado | Área 25 | Perímetro 20 <br/>TOTAL:<br/>1 Formas Perímetro 20 Área 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnCirculo()
        {
            var resumen = CodingChallenge.Imprimir(new Circulo(5), new Castellano());
            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Círculo | Area 78,54 | Perimetro 31,42 <br/>TOTAL:<br/>1 Formas Perimetro 31,42 Area 78,54", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnCirculoEnIngles()
        {
            var resumen = CodingChallenge.Imprimir(new Circulo(5), new Ingles());
            Assert.AreEqual("<h1>Shapes report</h1>1 Circle | Area 78,54 | Perimeter 31,42 <br/>TOTAL:<br/>1 Shapes Perimeter 31,42 Area 78,54", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnCirculoEnPortugues()
        {
            var resumen = CodingChallenge.Imprimir(new Circulo(5), new Portugues());
            Assert.AreEqual("<h1>Relatório de Formulário</h1>1 Circulo | Área 78,54 | Perímetro 31,42 <br/>TOTAL:<br/>1 Formas Perímetro 31,42 Área 78,54", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = CodingChallenge.Imprimir(cuadrados, new Castellano());

            Assert.AreEqual("<h1>Reporte de Formas</h1>3 Cuadrados | Area 35 | Perimetro 36 <br/>TOTAL:<br/>3 Formas Perimetro 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadradosEnIngles()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = CodingChallenge.Imprimir(cuadrados, new Ingles());

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 Shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadradosEnPortugues()
        {
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Cuadrado(1),
                new Cuadrado(3)
            };

            var resumen = CodingChallenge.Imprimir(cuadrados, new Portugues());

            Assert.AreEqual("<h1>Relatório de Formulário</h1>3 Quadrados | Área 35 | Perímetro 36 <br/>TOTAL:<br/>3 Formas Perímetro 36 Área 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Rectangulo(5, 6),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new Trapecio(8, 16, 8),
                new TrianguloEquilatero(9),
                new Circulo (2.75),
                new TrianguloEquilatero(4.2),
                new Rectangulo(6, 7),
                new Trapecio(4, 8, 5),
                new PoligonoRegular(6, 5, 3),
                new Rectangulo(4, 5)
            };

            var resumen = CodingChallenge.Imprimir(formas, new Castellano());

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Círculos | Area 52,03 | Perimetro 36,13 <br/>3 Triángulos | Area 49,64 | Perimetro 51,6 <br/>1 Poligono | Area 45 | Perimetro 18 <br/>2 Trapecios | Area 126 | Perimetro 64,66 <br/>3 Rectangulos | Area 92 | Perimetro 66 <br/>TOTAL:<br/>13 Formas Perimetro 264,39 Area 393,67",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnIngles()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Rectangulo(5, 6),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new Trapecio(8, 16, 8),
                new TrianguloEquilatero(9),
                new Circulo (2.75),
                new TrianguloEquilatero(4.2),
                new Rectangulo(6, 7),
                new Trapecio(4, 8, 5),
                new PoligonoRegular(6, 5, 3),
                new Rectangulo(4, 5)
            };

            var resumen = CodingChallenge.Imprimir(formas, new Ingles());

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 52,03 | Perimeter 36,13 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>1 Polygon | Area 45 | Perimeter 18 <br/>2 Trapezoids | Area 126 | Perimeter 64,66 <br/>3 Rectangles | Area 92 | Perimeter 66 <br/>TOTAL:<br/>13 Shapes Perimeter 264,39 Area 393,67",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnPortugues()
        {
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Rectangulo(5, 6),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new Trapecio(8, 16, 8),
                new TrianguloEquilatero(9),
                new Circulo (2.75),
                new TrianguloEquilatero(4.2),
                new Rectangulo(6, 7),
                new Trapecio(4, 8, 5),
                new PoligonoRegular(6, 5, 3),
                new Rectangulo(4, 5)
            };

            var resumen = CodingChallenge.Imprimir(formas, new Portugues());

            Assert.AreEqual(
                "<h1>Relatório de Formulário</h1>2 Quadrados | Área 29 | Perímetro 28 <br/>2 Circulos | Área 52,03 | Perímetro 36,13 <br/>3 Triangulos | Área 49,64 | Perímetro 51,6 <br/>1 Poligono | Área 45 | Perímetro 18 <br/>2 Trapézios | Área 126 | Perímetro 64,66 <br/>3 Retângulos | Área 92 | Perímetro 66 <br/>TOTAL:<br/>13 Formas Perímetro 264,39 Área 393,67",
                resumen);
        }

        [TestCase]
        public void TestGetNameClass()
        {
            var forma = new Cuadrado() { };
            Assert.AreEqual(typeof(Cuadrado).Name.ToString(), forma.NameOf());
        }
    }
}
