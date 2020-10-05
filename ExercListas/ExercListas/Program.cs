using System;
using System.Collections.Generic;

namespace ExercListas {
    class Program {
        static void Main(string[] args) {
            List<Funcionario> list = new List<Funcionario>();

            Console.Write("Deseja fazer o cadastro de um novo funcionário? (s/n) ");
            string conf = Console.ReadLine();
            while (conf == "s" || conf == "S") {
                Console.Write("digite o ID do funcionário: ");
                int _id = int.Parse(Console.ReadLine());
                Console.Write("digite Nome do funcionário: ");
                string _nome = Console.ReadLine();
                Console.Write("digite o salário do funcionário: ");
                double _salario = double.Parse(Console.ReadLine());

                list.Add(new Funcionario(_id, _nome, _salario));

                Console.Write("Deseja fazer o cadastro de um novo funcionário? (s/n) ");
                conf = Console.ReadLine();
            }
            Console.WriteLine("--------------------------------");
            Console.WriteLine();
            Console.WriteLine("Esta é a lista de funcionários: ");
            foreach (Funcionario obj in list) {
                Console.WriteLine(obj);
            }
            Console.Write("Algum funcionário terá alteração de salário? (s/n)");
            string altSalario = Console.ReadLine();
            if (altSalario == "s" || altSalario == "S") {
                Console.Write("Digite o ID do funcionário: ");
                int num = int.Parse(Console.ReadLine());
                Console.Write("Digite a porcentagem de aumento do salário: ");
                double porc = double.Parse(Console.ReadLine());
                Funcionario emp = list.Find(Funcionario => Funcionario.Id == num);
                emp.AlteracaoSalario(porc);

            }

            Console.WriteLine("-------------");
            Console.Write("Deseja ver a lista atualizada? (s/n)");
            string atual = Console.ReadLine();
            if (atual == "S" || atual == "s") {
                foreach (Funcionario obj in list) {
                    Console.WriteLine(obj);
                }
            }


        }
    }
}

