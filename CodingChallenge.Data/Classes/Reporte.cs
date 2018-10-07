using System.Collections.Generic;
using System.Linq;
using System.Text;

using CodingChallenge.Data.Classes.FormasGeometricas;
using CodingChallenge.Data.Classes.Lenguajes;
using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Classes
{
    public class Reporte
    {

        private readonly Idioma _texto;

        private readonly int[] _cantidades = new int[5];
        private readonly decimal[] _areas = new decimal[5];
        private readonly decimal[] _perimetros = new decimal[5];

        public Reporte(Idiomas idioma)
        {
            switch (idioma)
            {
                case Idiomas.Ingles:
                    _texto = new Ingles();

                    break;
                case Idiomas.Portugues:
                    _texto = new Portugues();

                    break;
                default:
                    _texto = new Castellano();

                    break;
            }
        }

        public string Imprimir(IEnumerable<FormaGeometrica> formas)
        {
            var sb = new StringBuilder();

            if (formas == null || !formas.Any())
            {
                return _texto.ListaVacia;
            }

            sb.Append(_texto.Encabezado);

            foreach (var forma in formas)
            {
                _cantidades[(int)forma.Tipo]++;
                _areas[(int)forma.Tipo] += forma.CalcularArea();
                _perimetros[(int)forma.Tipo] += forma.CalcularPerimetro();
            }

            sb.Append(ObtenerLinea(Formas.Cuadrado));
            sb.Append(ObtenerLinea(Formas.Circulo));
            sb.Append(ObtenerLinea(Formas.TrianguloEquilatero));
            sb.Append(ObtenerLinea(Formas.Trapecio));
            sb.Append(ObtenerLinea(Formas.Rectangulo));

            sb.Append(
                $"{_texto.Total}:<br/>" +
                $"{_cantidades.Sum()} {_texto.Formas} " +
                $"{_texto.Perimetro} {_perimetros.Sum().ToString("#.##")} " +
                $"{_texto.Area} {_areas.Sum().ToString("#.##")}");

            return sb.ToString();
        }

        private string ObtenerLinea(Formas tipo)
        {
            int i = (int)tipo;
            int cantidad = _cantidades[i];

            if (cantidad == 0)
            {
                return string.Empty;
            }

            return $"{cantidad} {TraducirForma(tipo, cantidad)} | " +
                $"{_texto.Area} {_areas[i]:#.##} | " +
                $"{_texto.Perimetro} {_perimetros[i]:#.##} <br/>";
        }

        private string TraducirForma(Enums.Formas tipo, int cantidad)
        {
            switch (tipo)
            {
                case Formas.Circulo:
                    return cantidad == 1 ? _texto.Circulo : _texto.Circulos;
                case Formas.TrianguloEquilatero:
                    return cantidad == 1 ? _texto.Triangulo : _texto.Triangulos;
                case Formas.Trapecio:
                    return cantidad == 1 ? _texto.Trapecio : _texto.Trapecios;
                case Formas.Rectangulo:
                    return cantidad == 1 ? _texto.Rectangulo : _texto.Rectangulos;
                default:
                    return cantidad == 1 ? _texto.Cuadrado : _texto.Cuadrados;
            }
        }
    }
}