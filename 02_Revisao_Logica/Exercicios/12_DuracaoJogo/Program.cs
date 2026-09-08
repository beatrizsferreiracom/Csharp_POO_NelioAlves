using System;

namespace DuracaoJogo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] valores = Console.ReadLine().Split();
            int horaI = int.Parse(valores[0]);
            int horaF = int.Parse(valores[1]);

            int duracao;
            if (horaI < horaF)
                duracao = horaF - horaI;
            else
                duracao = 24 - horaI + horaF;

            Console.WriteLine($"O JOGO DUROU {duracao} HORA(S)");
        }
    }
}