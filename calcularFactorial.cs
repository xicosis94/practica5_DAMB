using System;

class Program
{
    static void Main()
    {
        int n;

        Console.Write("Introduce un número entero no negativo: ");

        while (!int.TryParse(Console.ReadLine(), out n) || n < 0)
        {
            Console.Write("Entrada no válida. Introduce un entero mayor o igual que 0: ");
        }

        if (n > 20)
        {
            Console.WriteLine("El resultado no cabe en un long (máximo 20!). Prueba con un número menor.");
            return;
        }

        long factorial = 1;
        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"{n}! = {factorial}");
    }
}