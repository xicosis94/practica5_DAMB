using System.Globalization;
using Practica_V;
Console.WriteLine("Elige un programa:");
Console.WriteLine("1. Calcular Máximo");
Console.WriteLine("2. Calcular Minimo");
Console.WriteLine("3. Calcular Mediana");
Console.WriteLine("4. Calcular Media");
Console.WriteLine("5. Ordenar un Array de menor a mayor");
Console.WriteLine("6. Calcular la desviación típica de un array");
Console.WriteLine("7. Binarizar un array en base a un número n.");
Console.Write("Opción: ");

string? opcion = Console.ReadLine();

switch (opcion)
{
    case "1":
        calcularMaximo.Ejecutar();
        break;
    case "2":
        calcularMinimo.Ejecutar();
        break;
    case "3":
        calcularMediana.Ejecutar();
        break;
    case "4":
        calcularMedia.Ejecutar();
        break;
    case "5":
        ordenarMenorMayor.Ejecutar();
        break;
    case "6":
       calcularDesviacionTipica.Ejecutar();
        break;
    case "7":
       cambioBinarizacion.Ejecutar();
        break;
    default:
        Console.WriteLine("Opción no válida.");
        break;
}