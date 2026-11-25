using System;
using System.Collections.Generic;

namespace PracticaV.NumeroUtils
{
    public static class NumeroOperations
    {
        /// <summary>
        /// Devuelve true si todos los dígitos del número son diferentes; en caso contrario, false.
        /// </summary>
        public static bool TieneDigitosDiferentes(long numero)
        {
            string digitos = Math.Abs(numero).ToString();
            HashSet<char> vistos = new HashSet<char>();

            foreach (char c in digitos)
            {
                if (!vistos.Add(c))
                {
                    return false; // Dígito repetido encontrado
                }
            }

            return true;
        }
    }
}

