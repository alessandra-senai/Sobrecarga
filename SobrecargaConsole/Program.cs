using SobrecargaClasses;
using System;

namespace SobrecargaConsole
{
    class Program
    {
        static void Main(string[] args)
        {

            int resultadoSomar = Calculadora.Somar(5, 6);

            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Somar números inteiros = {resultadoSomar}");

            var resultadoSomar2 = Calculadora.Somar(54, 65.0);

            Console.WriteLine("-----------------------------");
            Console.WriteLine($"Somar números tipo double = {resultadoSomar2}");

            int resultadoMaiorValor = Calculadora.MaiorValor(100, 250);

            Console.WriteLine("-----------------------------");
            Console.WriteLine($"maior valor - tipo inteiro = {resultadoMaiorValor}");

            decimal resultadoMenorValor = Calculadora.MenorValor(45, 48);

            Console.WriteLine("-----------------------------");
            Console.WriteLine($"menor valor - tipo inteiro = {resultadoMenorValor}");


            Produto produto = new Produto(45, "celular Samsung", "informática", 4567.78M, 54);

            Console.WriteLine("--------------------------------------------");
            Console.WriteLine($"produto - código {produto.Codigo}");
            Console.WriteLine($"produto - nome {produto.Nome}");
            Console.WriteLine($"produto - categoria {produto.Categoria}");
            Console.WriteLine($"produto - preço {produto.Preco}");
            Console.WriteLine($"produto - quantidade {produto.Quantidade}");

            Console.WriteLine("---------------------------------------------");

        }
    }
}
