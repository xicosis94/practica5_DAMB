using System;
using System.Text;

class Program
{
    static string RepetirCaracteres(string texto)
    {
        if (string.IsNullOrEmpty(texto))
            return texto;

        // Reservamos el doble de capacidad desde el inicio para mayor rendimiento
        StringBuilder resultado = new StringBuilder(texto.Length * 2);

        foreach (char c in texto)
        {
            resultado.Append(c);
            resultado.Append(c);
        }

        return resultado.ToString();
    }

    static void Main()
    {
        Console.Write("Introduce una palabra o frase: ");
        string entrada = Console.ReadLine() ?? "";

        string salida = RepetirCaracteres(entrada);
        Console.WriteLine($"Resultado: {salida}");
        // Ejemplo: "Madrid" -> "MMaaddrriidd"
    }
}