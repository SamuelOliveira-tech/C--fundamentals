using System;
using System.Globalization;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string produto1 = "Computador";
            string produto2 = "Mesa de escritório";

            byte idade = 30;
            int codigo = 5290;      
            char genero = 'M';

            double preco1 = 2100.0;
            double preco2 = 650.50;
            double medida = 53.234567;

            /*usando Place Holer */
            Console.WriteLine("Produtos:\n{0}, cujo preço é $ {1:F2}\n{2}, cujo preço é $ {3:F2} \n",produto1, preco1, produto2, preco2);

            /*usando Concatenação */
            Console.WriteLine("Registro: " + idade + " anos de idade, código " + codigo + " e gênero: " + genero + "\n");

            /*usando Interpolação */
            Console.WriteLine($"Medida com oito casas decimais: {medida:F8}\nArredondado (três casas decimais): {medida:F3}");
            Console.WriteLine($"Separador decimal invariant culture: { medida.ToString("F3", CultureInfo.InvariantCulture)}");
        }
    }
}

