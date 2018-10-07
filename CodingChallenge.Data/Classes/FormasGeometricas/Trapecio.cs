using System;

using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public class Trapecio : FormaGeometrica
    {
        private readonly decimal _baseA;
        private readonly decimal _baseB;
        private readonly decimal _ladoC;
        private readonly decimal _ladoD;

        public Trapecio(
            decimal baseA, decimal baseB, decimal ladoC, decimal ladoD) :
            base(Formas.Trapecio)
        {
            _baseA = baseA;
            _baseB = baseB;
            _ladoC = ladoC;
            _ladoD = ladoD;
        }

        public override decimal CalcularArea()
        {
            decimal mediana = _baseA - _baseB;
            decimal semiPerimetro = (mediana + _ladoC + _ladoD) / 2;

            decimal areaTriangulo = (decimal)Math.Sqrt((double)(semiPerimetro *
                (semiPerimetro - mediana) * (semiPerimetro - _ladoC) *
                (semiPerimetro - _ladoD)));

            decimal altura = 2 * areaTriangulo / mediana;

            return altura * (_baseA + _baseB) / 2;
        }

        public override decimal CalcularPerimetro()
        {
            return _baseA + _baseB + _ladoC + _ladoD;
        }
    }
}
