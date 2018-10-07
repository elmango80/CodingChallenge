using NUnit.Framework;

using CodingChallenge.Data.Classes.FormasGeometricas;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class FormaGeometricaTests
    {
        private readonly Cuadrado _cuadrado = new Cuadrado(7.61m);
        private readonly Circulo _circulo = new Circulo(4.43m);
        private readonly TrianguloEquilatero _triangulo = new TrianguloEquilatero(11.72m);
        private readonly Trapecio _trapecio = new Trapecio(7, 4, 4.47m, 4.12m);
        private readonly Rectangulo _rectangulo = new Rectangulo(7, 13);

        [TestCase]
        public void TestAreaCuadrado()
        {
            decimal resultado = _cuadrado.CalcularArea();

            Assert.AreEqual(57.9121m, resultado);
        }

        [TestCase]
        public void TestPerimetroCuadrado()
        {
            decimal resultado = _cuadrado.CalcularPerimetro();

            Assert.AreEqual(30.44m, resultado);
        }

        [TestCase]
        public void TestAreaCirculo()
        {
            decimal resultado = _circulo.CalcularArea();

            Assert.AreEqual(15.4133604168586m, resultado);
        }

        [TestCase]
        public void TestPerimetroCirculo()
        {
            decimal resultado = _circulo.CalcularPerimetro();

            Assert.AreEqual(13.9172554554027697m, resultado);
        }

        [TestCase]
        public void TestAreaTriangulo()
        {
            decimal resultado = _triangulo.CalcularArea();

            Assert.AreEqual(59.4779319115922m, resultado);
        }

        [TestCase]
        public void TestPerimetroTriangulo()
        {
            decimal resultado = _triangulo.CalcularPerimetro();

            Assert.AreEqual(35.16m, resultado);
        }

        [TestCase]
        public void TestAreaTrapecio()
        {
            decimal resultado = _trapecio.CalcularArea();

            Assert.AreEqual(21.98388287279866m, resultado);
        }

        [TestCase]
        public void TestPerimetroTrapecio()
        {
            decimal resultado = _trapecio.CalcularPerimetro();

            Assert.AreEqual(19.59m, resultado);
        }

        [TestCase]
        public void TestAreaRectangulo()
        {
            decimal resultado = _rectangulo.CalcularArea();

            Assert.AreEqual(91m, resultado);
        }

        [TestCase]
        public void TestPerimetroRectangulo()
        {
            decimal resultado = _rectangulo.CalcularPerimetro();

            Assert.AreEqual(40m, resultado);
        }
    }
}