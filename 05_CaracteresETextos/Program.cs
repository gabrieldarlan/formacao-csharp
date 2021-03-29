using System;

namespace _05_CaracteresETextos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Caracteres e texto");

            char primeiraLetra = 'g';
            Console.WriteLine(primeiraLetra);

            primeiraLetra = (char)61;
            Console.WriteLine($"{primeiraLetra}");

            primeiraLetra = (char)(primeiraLetra + 1);
            Console.WriteLine($"{primeiraLetra}");

            string titulo = "Alura cursos de tec " + 2020;
            Console.WriteLine($"{titulo}");
            

        }
    }
}
