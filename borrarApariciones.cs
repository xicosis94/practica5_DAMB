using System;
using System.Text;

namespace PracticaV.StringUtils
{
    public static class StringOperations
    {
        /// <summary>
        /// </summary>
        public static string BorrarApariciones(string texto, string subcadena, StringComparison comparacion = StringComparison.Ordinal)
        {
            if (string.IsNullOrEmpty(texto) || string.IsNullOrEmpty(subcadena))
                return texto ?? string.Empty;

            StringBuilder resultado = new StringBuilder(texto.Length);
            int i = 0;
            int paso = subcadena.Length;

            while (i <= texto.Length - paso)
            {
                if (string.Compare(texto, i, subcadena, 0, paso, comparacion) == 0)
                {
                    i += paso;

                    if (resultado.Length == 0 && i < texto.Length && texto[i] == ' ')
                    {
                        i++;
                    }
                }
                else
                {
                    resultado.Append(texto[i]);
                    i++;
                }
            }
            while (i < texto.Length)
            {
                resultado.Append(texto[i]);
                i++;
            }

            return resultado.ToString();
        }
    }
}
