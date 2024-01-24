using System;
namespace StartsWithEndsWith
{
    class Program
    {
        static void Main(string[] args)
        {
            var texto = "Texto de teste";

            Console.WriteLine(texto.StartsWith("texto"));
            Console.WriteLine(texto.EndsWith("teste"));
            Console.WriteLine(texto.StartsWith("t"));
            Console.WriteLine(texto.EndsWith("o"));
        }
    }
}
