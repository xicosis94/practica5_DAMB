using System;
using System.Collections;
class Maximo
{
    static void calcularMaximo()
    {
        /* Usamos arraylist para que el usuario introduzca numeros hasta que
        * quiera, y luego calculamos el maximo de esos numeros.
        */
        int temp;
        int numero;
        var numeros = new ArrayList();
        do
        {
            
            Console.WriteLine("Introduce un numero: ");
            numero=int.Parse(Console.ReadLine());
            if (numero == 0)
            {
                break;
            } 
            else if( numero.GetType() != typeof(int))
            {
                Console.WriteLine("Por favor, introduce un numero valido.");
                continue;
            }
            else
            {
                numeros.Add(numero);
            }
        } while (numero != 0);

        for (int j = 0; j < numeros.Count; j++)
        {
            for (int i = 0; i < numeros.Count-1; i++)
            {
                if ((int)numeros[i] < (int)numeros[i + 1])
                {
                    temp = (int)numeros[i];
                    numeros[i] = numeros[i + 1];
                    numeros[i + 1] = temp;
                }
            }
        }
        Console.WriteLine("El maximo es: " + numeros[0]);
    }
    static void Main(string[] args)
    {
        calcularMaximo();
    }
}