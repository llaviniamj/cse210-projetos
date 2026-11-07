using System;

class Program
{
    static void Main(string[] args)
    {
        string jogarNovamente = "sim";

        while (jogarNovamente.ToLower() == "sim" || jogarNovamente.ToLower() == "s")
        {
            Random random = new Random();
            int numeroMagico = random.Next(1, 101); 

            int palpite = -1;
            int contadorPalpites = 0;

            Console.WriteLine("\n--- Novo Jogo de Adivinhação ---");

            while (palpite != numeroMagico)
            {
                Console.Write("Qual é o seu palpite? ");
                string entrada = Console.ReadLine();
                palpite = int.Parse(entrada);
                
                contadorPalpites++;

                if (palpite < numeroMagico)
                {
                    Console.WriteLine("Mais alto");
                }
                else if (palpite > numeroMagico)
                {
                    Console.WriteLine("Mais baixo");
                }
                else
                {
                    Console.WriteLine("Você adivinhou!");
                }
            }

            Console.WriteLine($"Você precisou de {contadorPalpites} palpites para acertar.");

            Console.Write("Você deseja jogar de novo? (sim/não): ");
            jogarNovamente = Console.ReadLine();
        }

        Console.WriteLine("Obrigado por jogar!");
    }
}