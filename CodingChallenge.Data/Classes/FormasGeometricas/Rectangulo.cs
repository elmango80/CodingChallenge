using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class Rectangulo : FormaGeometrica
    {
        private readonly decimal _ladoA;
        private readonly decimal _ladoB;

        public Rectangulo(decimal ancho, decimal alto) : base(Formas.Rectangulo)
        {
            _ladoA = ancho;
            _ladoB = alto;
        }

        public override decimal CalcularArea()
        {
            return _ladoA * _ladoB;
        }

        public override decimal CalcularPerimetro()
        {
            return 2 * (_ladoA + _ladoB);
        }
    }
}
