using System;

namespace Practica_V;

public class Ecuacion_segundoGrado
{
    public static void Ejecutar()
    {
        Console.Write("Introduce el coeficiente a: ");
        double a = double.Parse(Console.ReadLine()!);

        Console.Write("Introduce el coeficiente b: ");
        double b = double.Parse(Console.ReadLine()!);

        Console.Write("Introduce el coeficiente c: ");
        double c = double.Parse(Console.ReadLine()!);

        if (a == 0)
        {
            Console.WriteLine("No es una ecuación de segundo grado (a no puede ser 0).");
            return;
        }

        double discriminante = (b * b) - (4 * a * c);

        if (discriminante > 0)
        {
            double x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
            double x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
            Console.WriteLine($"Dos soluciones reales: x1 = {x1}, x2 = {x2}");
        }
        else if (discriminante == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"Una solución real doble: x = {x}");
        }
        else
        {
            Console.WriteLine("No tiene soluciones reales (el discriminante es negativo).");
        }

    }
}
