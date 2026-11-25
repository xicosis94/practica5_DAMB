using System;
using System.Text;

namespace UtilidadesTexto
{
    public class TransformadorTexto
    {
        public static string RepetirCadaLetra(string texto)
        {
            if (string.IsNullOrEmpty(texto))
                return texto;

            StringBuilder resultado = new StringBuilder(texto.Length * 2);

            foreach (char c in texto)
            {
                resultado.Append(c, 2);
            }

            return resultado.ToString();
        }
    }
}