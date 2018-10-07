using System.Collections.Generic;

using NUnit.Framework;

using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Enums;
using CodingChallenge.Data.Classes.FormasGeometricas;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class ReportTests
    {
        [TestCase]
        public void TestResumenListaNula()
        {
            var reporte = new Reporte(Idiomas.Castellano);

            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                reporte.Imprimir(null));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            var reporte = new Reporte(Idiomas.Ingles);

            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                reporte.Imprimir(new List<FormaGeometrica>()));
        }

        [TestCase]
        public void TestResumenListaVaciaEnPortugues()
        {
            var reporte = new Reporte(Idiomas.Portugues);

            Assert.AreEqual("<h1>Lista vazia de formas!</h1>",
                reporte.Imprimir(new List<FormaGeometrica>()));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var reporte = new Reporte(Idiomas.Castellano);
            var cuadrados = new List<FormaGeometrica>
            {
                new Cuadrado(5)
            };

            string resumen = reporte.Imprimir(cuadrados);

            string esperado = "<h1>Reporte de Formas</h1>" +
                "1 Cuadrado | Área 25 | Perímetro 20 <br/>" +
                "TOTAL:<br/>1 Formas Perímetro 20 Área 25";

            Assert.AreEqual(esperado, resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {
            var reporte = new Reporte(Idiomas.Ingles);
            var cuadrados = new List<FormaGeometrica>
            {
                new Trapecio(8, 6, 4, 4)
            };

            string resumen = reporte.Imprimir(cuadrados);

            string esperado = "<h1>Shapes report</h1>" +
                "1 Trapeze | Area 27,11 | Perimeter 22 <br/>" +
                "TOTAL:<br/>1 Shapes Perimeter 22 Area 27,11";

            Assert.AreEqual(esperado, resumen);
        }


        [TestCase]
        public void TestResumenListaConMasRectangulos()
        {
            var reporte = new Reporte(Idiomas.Portugues);
            var cuadrados = new List<FormaGeometrica>
            {
                new Rectangulo(7, 5),
                new Rectangulo(8, 1),
                new Rectangulo(4, 7)
            };

            string resumen = reporte.Imprimir(cuadrados);

            string esperado = "<h1>Relatório de formas</h1>" +
                "3 Rectângulos | Área 71 | Perímetro 64 <br/>" +
                "TOTAL:<br/>3 Formas Perímetro 64 Área 71";

            Assert.AreEqual(esperado, resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var reporte = new Reporte(Idiomas.Castellano);
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Trapecio(6.36m, 2.56m, 5, 4.33m),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new Rectangulo(6, 2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new Rectangulo(4, 12),
                new TrianguloEquilatero(4.2m),
                new Trapecio(4, 8, 3.12m, 3.12m)
            };

            string resumen = reporte.Imprimir(formas);

            string esperado = "<h1>Reporte de Formas</h1>" +
                "2 Cuadrados | Área 29 | Perímetro 28 <br/>" +
                "2 Círculos | Área 13,01 | Perímetro 18,06 <br/>" +
                "3 Triángulos | Área 49,64 | Perímetro 51,6 <br/>" +
                "2 Trapecios | Área 4,34 | Perímetro 36,49 <br/>" +
                "2 Rectángulos | Área 60 | Perímetro 48 <br/>" +
                "TOTAL:<br/>11 Formas Perímetro 182,15 Área 155,99";

            Assert.AreEqual(esperado, resumen);

        }

        [TestCase]
        public void TestResumenListaConMasTiposEnIngles()
        {
            var reporte = new Reporte(Idiomas.Ingles);
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            string resumen = reporte.Imprimir(formas);

            string esperado = "<h1>Shapes report</h1>" +
                "2 Squares | Area 29 | Perimeter 28 <br/>" +
                "2 Circles | Area 13,01 | Perimeter 18,06 <br/>" +
                "3 Triangles | Area 49,64 | Perimeter 51,6 <br/>" +
                "TOTAL:<br/>7 Shapes Perimeter 97,66 Area 91,65";

            Assert.AreEqual(esperado, resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnPortugues()
        {
            var reporte = new Reporte(Idiomas.Portugues);
            var formas = new List<FormaGeometrica>
            {
                new Cuadrado(5),
                new Circulo(3),
                new TrianguloEquilatero(4),
                new Cuadrado(2),
                new TrianguloEquilatero(9),
                new Circulo(2.75m),
                new TrianguloEquilatero(4.2m)
            };

            string resumen = reporte.Imprimir(formas);

            string esperado = "<h1>Relatório de formas</h1>" +
                "2 Quadrados | Área 29 | Perímetro 28 <br/>" +
                "2 Círculos | Área 13,01 | Perímetro 18,06 <br/>" +
                "3 Triângulos | Área 49,64 | Perímetro 51,6 <br/>" +
                "TOTAL:<br/>7 Formas Perímetro 97,66 Área 91,65";

            Assert.AreEqual(esperado, resumen);
        }
    }
}