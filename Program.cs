using System;

namespace leticia
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> escreva = Console.WriteLine;

            var paragrafo = "\n";
            
            var agora = DateTime.Now;

            Func<int,int,int,DateTime> nascimento = (dia, mes, ano) => new DateTime(ano,mes,dia);

            var idadeDaLeticia = agora - nascimento(10,06,2014);
            var idadeDoGabriel = agora - nascimento(20,10,1993);

            var quantosDiasTemUmAno = 365;
            var quantosDiasEuVivi = idadeDaLeticia.Days;

            var quantosDiasGabrielViveu = idadeDoGabriel.Days;


            var quantosAnosTenho = quantosDiasEuVivi / quantosDiasTemUmAno;
            
            var quantosAnosGabrielTem = quantosDiasGabrielViveu / quantosDiasTemUmAno;

            var quantoCubosTem = 5 + 14;
            var trabalhoDoGabriel = 2020 - 2018;


            escreva(paragrafo);
            escreva("Oi, meu nome é Letícia!");
            escreva("Minha idade é " + quantosAnosTenho + " anos");
            escreva("O Gabriel é velho e tem "+ quantosAnosGabrielTem + " anos");
            escreva("Eu tenho " + quantoCubosTem + " cubos!");
            escreva("O trabalho do Gabriel tem " + trabalhoDoGabriel + " anos já!");
            escreva(paragrafo);
        }
    }
}
