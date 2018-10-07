using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class Cuadrado : FormaGeometrica
    {
        private readonly decimal _lado;

        public Cuadrado(decimal lado) : base(Formas.Cuadrado)
        {
           _lado = lado;
        }

        public override decimal CalcularArea()
        {
            return _lado * _lado;
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 4;
        }
    }
}