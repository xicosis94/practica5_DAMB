using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<int> listaTemporal = new List<int>();
        string entrada;

        Console.WriteLine("Introduce números enteros uno a uno.");
        Console.WriteLine("Escribe 'fin' y pulsa Enter cuando quieras ordenarlos:");

        while (true)
        {
            Console.Write("> ");
            entrada = Console.ReadLine()?.Trim() ?? "";

            // Condición de salida
            if (entrada.Equals("fin", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }

            // Intentar convertir la entrada a número entero
            if (int.TryParse(entrada, out int numero))
            {
                listaTemporal.Add(numero);
            }
            else
            {
                Console.WriteLine("Entrada no válida. Escribe un número entero o 'fin'.");
            }
        }

        // Comprobar si se introdujo al menos un número
        if (listaTemporal.Count == 0)
        {
            Console.WriteLine("No se introdujeron números para ordenar.");
            return;
        }

        // Convertir la lista a Array y ordenarlo de menor a mayor
        int[] numeros = listaTemporal.ToArray();
        Array.Sort(numeros);

        Console.WriteLine("\nNúmeros ordenados de menor a mayor:");
        Console.WriteLine(string.Join(", ", numeros));
    }
}