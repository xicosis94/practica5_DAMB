using System;

class Program
{
    static void Main()
    {
        double numero;

        Console.Write("Introduce un número con decimales: ");

        while (!double.TryParse(Console.ReadLine(), out numero))
        {
            Console.Write("Entrada no válida. Introduce un número: ");
        }

        double sinDecimales = Math.Truncate(numero);

        Console.WriteLine($"Sin decimales: {sinDecimales}");
    }
}