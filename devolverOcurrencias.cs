using System;

namespace Practica_V;

public class Devolver_ocurrencias
{
    public static void Ejecutar()
    {
        Console.Write("Introduce un texto: ");
        string texto = Console.ReadLine()!;

        Console.Write("Introduce la letra a buscar: ");
        char letra = char.Parse(Console.ReadLine()!);

        int contador = 0;

        foreach (char c in texto)
        {
            if (c == letra)
                contador++;
        }

        Console.WriteLine($"La letra '{letra}' aparece {contador} veces.");

    }
}
