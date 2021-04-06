using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();

            Console.WriteLine("Entre com os dados do produto:");

            Console.WriteLine("Nome:");
            p.Nome = Console.ReadLine();

            Console.WriteLine("Preço:");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Quantidade:");
            p.Quantidade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do produto: "+ p);

            Console.Write("Digite o numero de produtos a ser adicionado ao estoque:");
            int qte = int.Parse(Console.ReadLine());

            p.AdicionarProduto(qte);
            Console.WriteLine("Dados atualizados: "+ p);

            Console.Write("Digite o numero de produtos a ser removidos do estoque:");
            int qtemenos = int.Parse(Console.ReadLine());

            p.RemoverProduto(qtemenos);
            Console.WriteLine("Dados atualizados: " + p);

            Console.ReadLine();
        }
    } 
}
