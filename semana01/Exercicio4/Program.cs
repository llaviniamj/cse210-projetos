using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();
        int entrada = -1;

        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");

        while (entrada != 0)
        {
            Console.Write("Insira o número: ");
            entrada = int.Parse(Console.ReadLine());

            if (entrada != 0)
            {
                numeros.Add(entrada);
            }
        }

        if (numeros.Count > 0)
        {
            int soma = numeros.Sum();

            double media = numeros.Average();

            int maior = numeros.Max();

            Console.WriteLine($"A soma é: {soma}");
            Console.WriteLine($"A média é: {media}");
            Console.WriteLine($"O maior número é: {maior}");

            int? menorPositivo = null;
            foreach (int num in numeros)
            {
                if (num > 0)
                {
                    if (menorPositivo == null || num < menorPositivo)
                    {
                        menorPositivo = num;
                    }
                }
            }

            if (menorPositivo != null)
            {
                Console.WriteLine($"O menor número positivo é: {menorPositivo}");
            }

            numeros.Sort();
            Console.WriteLine("A lista reordenada é:");
            foreach (int num in numeros)
            {
                Console.WriteLine(num);
            }
        }
        else
        {
            Console.WriteLine("Nenhum número foi inserido.");
        }
    }
}