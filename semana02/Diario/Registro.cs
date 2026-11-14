using System;

public class Registro
{
    public string _data;
    public string _pergunta;
    public string _resposta;
    public string _humor; 

    public void ExibirRegistro()
    {
        Console.WriteLine($"Data: {_data} - Humor: {_humor}");
        Console.WriteLine($"Pergunta: {_pergunta}");
        Console.WriteLine($"Resposta: {_resposta}");
        Console.WriteLine("--------------------------------------------------");
    }
}