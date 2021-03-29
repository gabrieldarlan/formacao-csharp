using System;

namespace _04_ConversoesEOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando Projeto 04");

            double salario = 1200.50;

            int salarioEmInteiro = (int)salario;

            Console.WriteLine($"{salarioEmInteiro}");

            // O long é uma variavel de 64 bits
            long idade;  
            idade = 1300000000000;

            short quantidadeProdutos;
            quantidadeProdutos = 150;

            float altura = 1.80f;
            Console.WriteLine($"{altura}");
            








        }
    }
}
