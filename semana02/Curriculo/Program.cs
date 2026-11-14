using System;

class Program
{
    static void Main(string[] args)
    {
        Emprego emprego1 = new Emprego();
        emprego1._cargo = "Desenvolvedora Web";
        emprego1._empresa = "InovaTech Brasil";
        emprego1._anoInicio = 2022;
        emprego1._anoFim = 2024;

        Emprego emprego2 = new Emprego();
        emprego2._cargo = "Analista de Sistemas";
        emprego2._empresa = "Nubank";
        emprego2._anoInicio = 2024;
        emprego2._anoFim = 2026;

        Curriculo meuCurriculo = new Curriculo();
        meuCurriculo._nome = "Lavinia Morais";

        meuCurriculo._empregos.Add(emprego1);
        meuCurriculo._empregos.Add(emprego2);

        meuCurriculo.Exibir();
    }
}