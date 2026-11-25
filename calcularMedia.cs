using System;

class Media
{
    static void calcularMedia()
    {
        int[] numeros = new int[5];
        int suma = 0;
        double media;

        // Pedimos los números
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine("Introduce un número:");
            numeros[i] = Convert.ToInt32(Console.ReadLine());

            suma += numeros[i];
        }

        // Calculamos la media
        media = (double)suma / numeros.Length;

        // Mostramos el resultado
        Console.WriteLine("La media es: " + media);
    }
}