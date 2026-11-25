using System;
using ArrayList;

class Maximo
{
    static void calcularMaximo()
    {
        /* Usamos arraylist para que el usuario introduzca numeros hasta que
        * quiera, y luego calculamos el maximo de esos numeros.
        */
        int temp;
        do
        {
            var numeros = new ArrayList<int>();
            numeros.Add(Console.ReadInt("Introduce un numero: "));

        } while (Console.ReadInt == 0);
        for (int j = 0; j < numeros.Count; j++)
        {
            for (int i = 0; i < numeros.Count-1; i++)
            {
                if (numeros(i)<numeros(i+1))
                {
                    temp=numeros(i);
                    numeros(i)=numeros(i+1);
                    numeros(i+1)=temp;
                }
            }
        }
        Console.WriteLine("El maximo es: " + numeros(0));
    }
}