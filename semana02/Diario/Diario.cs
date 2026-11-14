using System;
using System.Collections.Generic;
using System.IO;

public class Diario
{
    public List<Registro> _listaRegistros = new List<Registro>();
    public List<string> _listaPerguntas = new List<string>()
    {
        "Quem foi a pessoa mais interessante com quem interagi hoje?",
        "Qual foi a melhor parte do meu dia?",
        "Como vi a mão do Senhor em minha vida hoje?",
        "Qual foi a emoção mais forte que senti hoje?",
        "Se eu pudesse fazer uma coisa hoje, o que seria?",
        "Qual foi o maior aprendizado ou desafio superado hoje?",
        "O que eu poderia ter feito diferente para melhorar meu dia?"
    };

    public void AdicionarRegistro()
    {
        Random random = new Random();
        int indiceAleatorio = random.Next(_listaPerguntas.Count);
        string perguntaSelecionada = _listaPerguntas[indiceAleatorio];

        Console.WriteLine($"\nPergunta do Dia:\n{perguntaSelecionada}");
        Console.Write("> ");
        string respostaUsuario = Console.ReadLine();

        Console.Write("Como você classifica seu humor hoje? (ex: Feliz, Produtivo, Cansado, Inspirado): ");
        string humorUsuario = Console.ReadLine();

        Registro novoRegistro = new Registro();
        novoRegistro._data = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
        novoRegistro._pergunta = perguntaSelecionada;
        novoRegistro._resposta = respostaUsuario;
        novoRegistro._humor = string.IsNullOrWhiteSpace(humorUsuario) ? "Normal" : humorUsuario;

        _listaRegistros.Add(novoRegistro);
        Console.WriteLine("\n[Sucesso] Registro adicionado com sucesso!\n");
    }

    public void ExibirDiario()
    {
        if (_listaRegistros.Count == 0)
        {
            Console.WriteLine("\n[Aviso] O diário está vazio.\n");
            return;
        }

        Console.WriteLine("\n================== SEU DIÁRIO ==================");
        foreach (Registro reg in _listaRegistros)
        {
            reg.ExibirRegistro();
        }
    }

    public void SalvarEmArquivo(string nomeArquivo)
    {
        using (StreamWriter outputFile = new StreamWriter(nomeArquivo))
        {
            foreach (Registro reg in _listaRegistros)
            {
                outputFile.WriteLine($"{reg._data}~|~{reg._pergunta}~|~{reg._resposta}~|~{reg._humor}");
            }
        }
        Console.WriteLine("\n[Sucesso] Diário salvo com sucesso!\n");
    }

    public void CarregarDeArquivo(string nomeArquivo)
    {
        if (!File.Exists(nomeArquivo))
        {
            Console.WriteLine("\n[Erro] Arquivo não encontrado.\n");
            return;
        }

        _listaRegistros.Clear();
        string[] linhas = File.ReadAllLines(nomeArquivo);

        foreach (string linha in linhas)
        {
            string[] partes = linha.Split("~|~");
            if (partes.Length >= 4)
            {
                Registro reg = new Registro();
                reg._data = partes[0];
                reg._pergunta = partes[1];
                reg._resposta = partes[2];
                reg._humor = partes[3];
                _listaRegistros.Add(reg);
            }
        }
        Console.WriteLine("\n[Sucesso] Diário carregado com sucesso!\n");
    }
}