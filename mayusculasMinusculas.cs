using System;

class Program
{
    static void Main()
    {
        Console.Write("Introduce una frase: ");
        string frase = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(frase))
        {
            Console.WriteLine("No has introducido ninguna frase.");
            return;
        }

        Console.WriteLine($"En minúsculas: {frase.ToLower()}");
        Console.WriteLine($"En mayúsculas: {frase.ToUpper()}");
    }
}