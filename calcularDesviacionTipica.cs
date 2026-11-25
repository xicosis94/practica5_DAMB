using System;
namespace PracticaV.ArrayUtils
{
    public static class ArrayOperations
    {
        /// <summary>
        /// </summary>
        public static double CalcularDesviacionTipica(double[] numeros, bool muestral = false)
        {
            if (numeros == null || numeros.Length == 0)
                throw new ArgumentException("El array no puede estar vacío.", nameof(numeros));

            if (muestral && numeros.Length < 2)
                throw new ArgumentException("Se necesitan al menos 2 elementos para la desviación típica muestral.", nameof(numeros));

            double media = 0;
            foreach (double num in numeros)
            {
                media += num;
            }
            media /= numeros.Length;

            double sumaCuadrados = 0;
            foreach (double num in numeros)
            {
                double diferencia = num - media;
                sumaCuadrados += diferencia * diferencia;
            }

            int divisor = muestral ? numeros.Length - 1 : numeros.Length;
            return Math.Sqrt(sumaCuadrados / divisor);
        }
    }
}
