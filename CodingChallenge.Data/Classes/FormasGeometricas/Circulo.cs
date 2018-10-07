using System;

using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class Circulo : FormaGeometrica
    {
        private readonly decimal _diametro;

        public Circulo(decimal diametro) : base(Formas.Circulo)
        {
            _diametro = diametro;
        }

        public override decimal CalcularArea()
        {
            return (decimal)(Math.PI * Math.Pow((double)_diametro, 2) / 4);
        }

        public override decimal CalcularPerimetro()
        {
            return (decimal)Math.PI * _diametro;
        }
    }
}