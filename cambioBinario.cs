using System;
using System.Collections;

class CambioBinario
{
    static void cambioBinario()
    {
        string validacion;
        int numero;
        var listaNumeros = new ArrayList();
        var listaBinario = new ArrayList();

        do
        {
            Console.WriteLine("Introduce un numero para la lista de numeros (introduce -1 para salir): ");
            validacion=Console.ReadLine();
            if(!int.TryParse(validacion,out numero))
            {
                Console.WriteLine("Por favor, introduce un numero valido.");
            }
            else if (numero != -1)
            {
                listaNumeros.Add(numero);
            }
            
        } while (numero != -1);

        Console.WriteLine("Ahora introduzca un numero para comparar y transformar la lista a binario: ");
        numero = int.Parse(Console.ReadLine());
        for (int i =0;i<listaNumeros.Count;i++)
        {
            if ((int)listaNumeros[i] < numero)
            {
                listaBinario.Add(0);
            }
            else
            {
                listaBinario.Add(1);
            }
        }
        Console.WriteLine("La lista de numeros es: ");
        for (int i = 0; i < listaNumeros.Count; i++)
        {
            Console.Write(listaNumeros[i] + " ");
        }
        Console.WriteLine("\nBasandonos en el numero introducido "+numero+", la lista binaria es: ");
        for (int j = 0; j < listaBinario.Count; j++)
        {
            Console.Write(listaBinario[j] + " ");
        }
    }
}