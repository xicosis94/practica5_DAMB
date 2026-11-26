using System;

class Palindromo
{
    static void palindromo()
    {
        string frase;
        do
        {
            Console.WriteLine("Ingrese una frase o palabra para verificar si es palíndromo o no (ingrese el número 0 para salir): ");
            frase = Console.ReadLine();
            if (frase != "0")
            {
                frase = frase.Trim().Replace(" ","").ToLower();
                if (frase.Length == 1)
                {
                    Console.WriteLine("La palabra es un palíndromo.");
                } else
                {
                    for (int i = 0; i < frase.Length / 2; i++)
                    {
                        if (frase[i] != frase[frase.Length - 1 - i])
                        {
                            Console.WriteLine("La palabra no es un palíndromo.");
                            break;
                        }
                        else 
                        {
                            Console.WriteLine("La palabra es un palíndromo.");
                            break;
                        }
                    }
                }
                
                
            }
        } while(frase!="0");
    }
}