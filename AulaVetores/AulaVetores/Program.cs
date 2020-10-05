using System;
using System.Dynamic;
using System.Globalization;

namespace AulaVetores
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite o número de valores do vetor: ");
            int n = int.Parse(Console.ReadLine());

            double[] vect = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite o valor da posição " + (i +1) + ": ");
                vect[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            }

            Console.WriteLine("Os valores digitados foram: ");
            
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine();

            double sum = 0.0;
            for (int i = 0; i < n; i++)
            {
                sum += vect[i];
            }

            double media = sum / n;
            Console.Write("A média dos valores digitados é: " + media.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
