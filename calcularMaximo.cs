using System;
using System.Collections;
class Maximo
{
    static void calcularMaximo()
    {
        /* Usamos arraylist para que el usuario introduzca numeros hasta que
        * quiera, y luego calculamos el maximo de esos numeros.
        */
        string validacion;
        int temp;
        int numero;
        var numeros = new ArrayList();
        do
        {
            Console.WriteLine("Introduce un numero (introduce -1 para salir): ");
            validacion=Console.ReadLine();
            if(!int.TryParse(validacion, out numero))
            {
                Console.WriteLine("Por favor, introduce un numero valido.");
            }
            else
            {
                if(numero != -1)
                {
                    numeros.Add(numero);
                }
            }
            
        } while (numero != -1);

        if (numeros.Count == 0)
        {
            Console.WriteLine("No has introducido ningun numero.");
            return;
        }
        else
        {
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
        
    }
}