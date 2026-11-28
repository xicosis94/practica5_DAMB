using System;

class RedondearAlza
{
    static void redondearAlza()
    {
        double numero;
        do
        {
            Console.WriteLine("Ingrese un número decimal para redondear al alza: ");
            numero = double.TryParse(Console.ReadLine(), out numero) ? numero : double.NaN;
            if (double.IsNaN(numero))
            {
                Console.WriteLine("Error: Introduzca un carácter numérico.");
            }
            else if (numero == 0)
            {
                Console.WriteLine("Saliendo del programa...");
                break;
            }
            else
            {
                double resultado = Math.Ceiling(numero);
                Console.WriteLine("El número redondeado al alza es: " + resultado);
            }
            
        } while (numero!=0);
    }
}