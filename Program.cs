using System.Globalization;
using Practica_V;
Console.WriteLine("Elige un programa:");
Console.WriteLine("1. Calcular Mediana");
Console.WriteLine("2. Devolver Hora");
Console.WriteLine("3. Devolver Ocurrencias de una letra");
Console.WriteLine("4. Resolver Ecuación de Segundo Grado");
Console.Write("Opción: ");

string? opcion = Console.ReadLine();

switch (opcion)
{
    case "1":
        Array_mediana.Ejecutar();
        break;
    case "2":
        Devolver_Hora.Ejecutar();
        break;
    case "3":
        Devolver_ocurrencias.Ejecutar();
        break;
    case "4":
        Ecuacion_segundoGrado.Ejecutar();
        break;
    default:
        Console.WriteLine("Opción no válida.");
        break;
}