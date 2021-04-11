using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace CadastroBanco
{
    class Program
    {
        static void Main(string[] args)
        {
            Conta c = new Conta();

            Console.Write("Entre o numero da conta: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Entre com o titular da conta: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Havera um deposito inicial? (s/n)");
            char op = char.Parse(Console.ReadLine());

            if (op == 's' || op == 'S')
            {
                Console.WriteLine("Digite o deposito inicial: ");
                double depositoInicial = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                c = new Conta(numero, nome, depositoInicial);
            }
            else
            {
                c = new Conta(numero, nome);
            }
            Console.WriteLine();

            Console.WriteLine("Dados da conta: ");
            Console.WriteLine(c);

            Console.WriteLine();

            Console.Write("Entre com um valor para deposito: ");
            double deposito = double.Parse(Console.ReadLine());
            c.Deposito(deposito);

            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);

            Console.WriteLine();

            Console.Write("Entre com um valor para saque: ");
            double saque = double.Parse(Console.ReadLine());
            c.Saque(saque);
            Console.WriteLine();

            Console.WriteLine("Dados da conta atualizados: ");
            Console.WriteLine(c);


            Console.ReadKey();
        }
    }
}
