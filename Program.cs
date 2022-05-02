using System;

namespace calculadora_de_impostos_e_desconto_de_um_produto
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal ValorProduto;
            decimal PercentualDeDesconto;
            decimal ValorDoProdutoDescontado;

            Console.WriteLine("insira o valor do produto: ");
            ValorProduto = Convert.ToDecimal(Console.ReadLine());

            Console.WriteLine("insira o percentual de desconto: ");
            PercentualDeDesconto = Convert.ToDecimal(Console.ReadLine());

            ValorDoProdutoDescontado = (ValorProduto * PercentualDeDesconto / 100);
            

            if (ValorProduto <= 100 )
            {
                Console.WriteLine("valor do imposto com 5% de alíquota: " + (ValorProduto * 5 / 100));
            }
            if (ValorProduto <= 300 && ValorProduto > 100)
            {
                Console.WriteLine("Valor do imposto com 15% de alíquata:" + (ValorProduto * 15 / 100));
            }
            else if ( ValorProduto > 300 && ValorProduto <= 1000)
            {
                Console.WriteLine("Valor do imposto com 25% de alíquota: " + (ValorProduto * 15 / 100));
            }




            Console.WriteLine("o valor do seu produto é: " + ValorProduto);
            Console.WriteLine("o percentual de desconto é: " + PercentualDeDesconto);
            Console.WriteLine("o valor do seu produto com desconto é: " + ValorDoProdutoDescontado);
        }
    }
}
