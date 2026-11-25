using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> numeros = new List<int>();
        int numero;

        Console.WriteLine("Introduce números (-1 para terminar):");

        while (true)
        {
            Console.Write("Número: ");

            if (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Entrada no válida, introduce un número entero.");
                continue;
            }

            if (numero == -1)
                break;

            numeros.Add(numero);
        }

        if (numeros.Count == 0)
        {
            Console.WriteLine("No se introdujo ningún número.");
            return;
        }

        int minimo = numeros[0];
        for (int i = 1; i < numeros.Count; i++)
        {
            if (numeros[i] < minimo)
                minimo = numeros[i];
        }

        Console.WriteLine($"El número mínimo es: {minimo}");
    }
}