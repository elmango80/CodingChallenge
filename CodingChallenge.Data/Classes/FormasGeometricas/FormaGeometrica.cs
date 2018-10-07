////Refactorear la clase para respetar principios de programación orientada a objetos. Qué pasa si debemos soportar un nuevo idioma para los reportes, o
////agregar más formas geométricas?

////Se puede hacer cualquier cambio que se crea necesario tanto en el código como en los tests. La única condición es que los tests pasen OK.

////TOD0: Implementar Trapecio/Rectangulo, agregar otro idioma a reporting.
 
 using CodingChallenge.Data.Enums;

namespace CodingChallenge.Data.Classes.FormasGeometricas
{
    public abstract class FormaGeometrica
    {
        public readonly Formas Tipo;

        protected FormaGeometrica(Formas tipo)
        {
            Tipo = tipo;
        }

        public abstract decimal CalcularArea();

        public abstract decimal CalcularPerimetro();
    }
}