using System;

namespace ConversorDeMoeda
{
    internal class ConversorDeMoeda
    {
        public static double IOF = 0.06;

        public static double DolarParaReal(double quantia, double cotacao)
        {
            double total = quantia * cotacao;
            return total + total * IOF;
        }
    }
}