using System;
using System.Globalization;

namespace AulaVetores2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Product[] vect = new Product[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o Produto: ");
                string name = Console.ReadLine();
                Console.Write("Digite o valor do produto: ");
                double price = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                vect[i] = new Product { Name = name, Price = price };

            }

            double sum = 0;
            for (int i = 0; i < n; i++){
                sum += vect[i].Price;
            }

            double media = sum / n;
            Console.WriteLine("A média dos valores é: " + media.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}
