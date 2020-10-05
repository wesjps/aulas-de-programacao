using System;

namespace Sistema_Banco1
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaBanco conta;

            Console.Write("Digite o nome do titular da conta: ");
            string nome = Console.ReadLine();
            Console.Write("Digite o número da conta: ");
            int numero = int.Parse (Console.ReadLine());
            Console.Write( "Será feito depósito inicial? s/n: " );
            char confDep = char.Parse(Console.ReadLine());
            if(confDep == 's' || confDep == 'S')
            {
                Console.Write("Digite o valor do depósito inicial: ");
                double depInicial = double.Parse(Console.ReadLine());
                conta = new ContaBanco(depInicial, nome, numero);
            }
            else
            {
                conta = new ContaBanco(nome, numero);
            }
            Console.WriteLine();
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Qual valor deseja depositar? ");
            double valorDeposito = double.Parse(Console.ReadLine());
            conta.Deposito(valorDeposito);
            Console.WriteLine();
            Console.WriteLine(conta);
            Console.WriteLine();

            Console.Write("Qual valor deseja sacar? ");
            double valorSaque = double.Parse(Console.ReadLine());
            conta.Saque(valorSaque);
            Console.WriteLine();
            Console.WriteLine(conta);

        }
    }
}
