using System.Globalization;
using Practica_V;
Console.WriteLine("Elige un programa:");
Console.WriteLine("1. Calcular Mediana");

Console.Write("Opción: ");

string? opcion = Console.ReadLine();

switch (opcion)
{
    case "1":
        Array_mediana.Ejecutar();
        break;
    
    default:
        Console.WriteLine("Opción no válida.");
        break;
}