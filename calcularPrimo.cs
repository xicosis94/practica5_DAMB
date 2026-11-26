using System;

class Primo
{
    static void calcularPrimo()
    {
        // Entorno
        int numero;

        // Programa

        Console.WriteLine("Para salir introduzca el número 0");
        do
        {
            Console.WriteLine("Introduzca un número: ");
            if (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Error: Introduzca un carácter numérico.");
            }
            else
            {
                if (numero == 0)
                {
                    Console.WriteLine("Saliendo del programa...");
                    break;
                }
                else if (numero<2 || numero<0)
                {
                    Console.WriteLine("El número introducido debe ser mayor o igual a 2.");
                }
                for (int i = 2; i <= numero; i++)
                {
                    if (i==numero)
                    {
                        Console.WriteLine("El número introducido es un número primo.");
                    } 
                    else if (numero % i == 0)
                    {
                        Console.WriteLine("El número introducido no es primo");
                        break;
                    }
                }
            }
        } while(numero!=0);
    }
}