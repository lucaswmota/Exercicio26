using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio26
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite o saldo inicial da conta: ");
            double saldo = double.Parse(Console.ReadLine());

            Console.Write("Digite o valor do Deposito: ");
            double deposito = double.Parse(Console.ReadLine());

            Console.Write("Digite o Valor do saque: ");
            double saque = double.Parse(Console.ReadLine());

            saldo += deposito - saque;

            Console.Write("Saldo Atual da Conta: " + saldo.ToString("C"));

            Console.ReadKey();

        }
    }
}
