// REQUISITOS DE CRIATIVIDADE:
// 1. Indicador de Humor/Energia: Além da data, pergunta e resposta, cada registro 
//    armazena e exibe como o usuário estava se sentindo no dia (ex: Produtivo, Inspirado).
// 2. Banco Expandido de Perguntas: A lista padrão foi expandida com perguntas reflexivas extras.
// 3. Delimitador Seguro (~|~): O salvamento e carregamento utilizam um token composto 
//    personalizado para evitar que quebras de linha ou pontuações corrompam o arquivo de texto.

using System;

class Program
{
    static void Main(string[] args)
    {
        Diario meuDiario = new Diario();
        int opcao = 0;

        Console.WriteLine("Bem-vindo ao seu Diário Pessoal Inteligente!");

        while (opcao != 5)
        {
            Console.WriteLine("\nMenu Principal:");
            Console.WriteLine("1. Escrever um novo registro");
            Console.WriteLine("2. Exibir o diário");
            Console.WriteLine("3. Salvar o diário em um arquivo");
            Console.WriteLine("4. Carregar o diário de um arquivo");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção (1-5): ");

            string entrada = Console.ReadLine();

            if (!int.TryParse(entrada, out opcao))
            {
                Console.WriteLine("\n[Erro] Por favor, digite um número válido entre 1 e 5.\n");
                continue;
            }

            switch (opcao)
            {
                case 1:
                    meuDiario.AdicionarRegistro();
                    break;
                case 2:
                    meuDiario.ExibirDiario();
                    break;
                case 3:
                    Console.Write("Digite o nome do arquivo para salvar (ex: diario.txt): ");
                    string arquivoSalvar = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(arquivoSalvar))
                    {
                        meuDiario.SalvarEmArquivo(arquivoSalvar);
                    }
                    break;
                case 4:
                    Console.Write("Digite o nome do arquivo para carregar (ex: diario.txt): ");
                    string arquivoCarregar = Console.ReadLine();
                    if (!string.IsNullOrWhiteSpace(arquivoCarregar))
                    {
                        meuDiario.CarregarDeArquivo(arquivoCarregar);
                    }
                    break;
                case 5:
                    Console.WriteLine("\nEncerrando o programa. Até logo!\n");
                    break;
                default:
                    Console.WriteLine("\n[Erro] Opção inválida. Escolha entre 1 e 5.\n");
                    break;
            }
        }
    }
}