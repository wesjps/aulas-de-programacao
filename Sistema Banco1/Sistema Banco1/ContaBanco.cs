using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;

namespace Sistema_Banco1
{
    class ContaBanco
    {
        public string Nome;
        public int Conta;
        public double Saldo;

        public ContaBanco(string nome, int conta)
        {
            Nome = nome;
            Conta = conta;
        }

        public ContaBanco(double saldo, string nome, int conta) : this(nome,conta)
        {
            Saldo = saldo;
        }

        public void Deposito (double valorDepositado)
        {
            Saldo += valorDepositado;
        }

        public void Saque (double valorSacado)
        {
            Saldo -= valorSacado;
        }

        public override string ToString()
        {
            return "O titular da conta se chama: " + Nome + ", O número da conta é: " + Conta + ", e o saldo da conta é: " + Saldo;
        }
    }
}
