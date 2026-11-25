using System;

public static class NumeroArmstrong
{
    public static bool EsNumeroArmstrong(int numero)
    {
        if (numero < 0)
            return false;

        int original = numero;
        int cantidadDigitos = numero == 0 ? 1 : (int)Math.Floor(Math.Log10(numero) + 1);
        long suma = 0;

        while (numero > 0)
        {
            int digito = numero % 10;
            suma += (long)Math.Pow(digito, cantidadDigitos);
            numero /= 10;
        }

        return suma == original;
    }
}