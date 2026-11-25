using System;

namespace Practica_V;

public class Devolver_Hora
{
    public static void Ejecutar()
    {
        Console.Write("Introduce los segundos: ");
        int totalSegundos = int.Parse(Console.ReadLine()!);

        int horas = totalSegundos / 3600;
        int minutos = (totalSegundos % 3600) / 60;
        int segundos = totalSegundos % 60;

        Console.WriteLine($"{totalSegundos} segundos son {horas} hora(s), {minutos} min, y {segundos} segundos.");

    }
}
