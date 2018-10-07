using System.Linq;

using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Classes.Lenguajes
{
    public class Ingles : Idioma
    {
        public override string Area => "Area";

        public override string Circulo => "Circle";

        public override string Circulos => "Circles";

        public override string Cuadrado => "Square";

        public override string Cuadrados => "Squares";

        public override string Encabezado => "<h1>Shapes report</h1>";

        public override string Formas => "Shapes";

        public override string ListaVacia => "<h1>Empty list of shapes!</h1>";

        public override string Perimetro => "Perimeter";

        public override string Rectangulo => "Rectangle";

        public override string Rectangulos => "Rectangles";

        public override string Total => "TOTAL";

        public override string Trapecio => "Trapeze";

        public override string Trapecios => "Trapezoids";

        public override string Triangulo => "Triangle";

        public override string Triangulos => "Triangles";
    }
}