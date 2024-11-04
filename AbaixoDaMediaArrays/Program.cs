//Utilizando Arrays
//Problema "abaixo_da_media"
//Fazer um programa para ler um número inteiro N e depois um vetor de N números reais. Em seguida,
//mostrar na tela a média aritmética de todos elementos com três casas decimais. Depois mostrar todos
//os elementos do vetor que estejam abaixo da média, com uma casa decimal cada. 

using System.ComponentModel;
using System.Globalization;

namespace AbaixoDaMediaArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n;
            double somaVetor = 0, mediaVetor;
            string abaixoMedia = "\n";

            CultureInfo CI = CultureInfo.InvariantCulture;

            Console.Write("Quantos elementos vai ter o vetor? ");
            n = int.Parse(Console.ReadLine());

            double[] vet = new double[n];

            for (int i = 0; i < n; i++)
            {
                Console.Write("Digite um numero: ");
                vet[i] = double.Parse(Console.ReadLine(), CI);
            }

            for (int i = 0; i < n; i++)
            {
                somaVetor += vet[i];
            }

            mediaVetor = somaVetor / n;

            for (int i = 0; i < n; i++)
            {
                if (vet[i] < mediaVetor)
                {
                    abaixoMedia += vet[i].ToString("F1", CI) + "\n";
                }
            }

            Console.WriteLine();
            Console.WriteLine($"MEDIA DO VETOR = {mediaVetor.ToString("F3", CI)}");
            Console.WriteLine($"ELEMENTOS ABAIXO DA MEDIA: {abaixoMedia}");
        }
    }
}
