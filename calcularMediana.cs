using System;

namespace Practica_V;

public class Array_mediana
{
    public static void Ejecutar()
    {
        Console.Write("¿Cuántos números vas a introducir?: ");
        int n = int.Parse(Console.ReadLine()!);

        double[] numeros = new double[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Número {i + 1}: ");
            numeros[i] = double.Parse(Console.ReadLine()!);
        }

        Array.Sort<double>(numeros);

        double mediana = (n % 2 == 0)
            ? (numeros[n / 2 - 1] + numeros[n / 2]) / 2.0
            : numeros[n / 2];

        Console.WriteLine($"La mediana es: {mediana}");
    }

}
