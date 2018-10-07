using System;

using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class TrianguloEquilatero : FormaGeometrica
    {
        private readonly decimal _lado;

        public TrianguloEquilatero(decimal lado) : base(Formas.TrianguloEquilatero)
        {
            _lado = lado;
        }

        public override decimal CalcularArea()
        {
            return (decimal)(Math.Sqrt(3) / 4 * Math.Pow((double)_lado, 2));
        }

        public override decimal CalcularPerimetro()
        {
            return _lado * 3;
        }
    }
}