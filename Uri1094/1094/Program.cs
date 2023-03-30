using System;

namespace _1094
{
    class Program
    {
        static void Main(string[] args)
        {
            using System;
            using System.Globalization;

namespace _1094
    {
        class Program
        {
            static void Main(string[] args)
            {
                int entrada, i, rato, sapo, coelho, total, quantiaRatos = 0, quantiaSapos = 0, quantiaCoelhos = 0;
                double percentualR, percentualS, percentualC;
                char cobaia;


                entrada = int.Parse(Console.ReadLine());

                for (i = 0; i < entrada; i++)
                {
                    string[] cobaias = Console.ReadLine().Split(' ');
                    cobaia = char.Parse(cobaias[1]);

                    if (cobaia == 'R')
                    {
                        rato = int.Parse(cobaias[0]);
                        quantiaRatos = quantiaRatos + rato;
                    }
                    if (cobaia == 'S')
                    {
                        sapo = int.Parse(cobaias[0]);
                        quantiaSapos = quantiaSapos + sapo;
                    }
                    if (cobaia == 'C')
                    {
                        coelho = int.Parse(cobaias[0]);
                        quantiaCoelhos = quantiaCoelhos + coelho;
                    }

                }

                total = quantiaRatos + quantiaCoelhos + quantiaSapos;

                percentualC = quantiaCoelhos * 100.0 / total;
                percentualR = quantiaRatos * 100.0 / total;
                percentualS = quantiaSapos * 100.0 / total;

                Console.WriteLine($"Total: {total} cobaias");

                Console.WriteLine($"Total de coelhos: {quantiaCoelhos}");
                Console.WriteLine($"Total de ratos: {quantiaRatos}");
                Console.WriteLine($"Total de sapos: {quantiaSapos}");

                Console.WriteLine($"Percentual de coelhos: {percentualC.ToString("F2", CultureInfo.InvariantCulture)} %");
                Console.WriteLine($"Percentual de ratos: {percentualR.ToString("F2", CultureInfo.InvariantCulture)} %");
                Console.WriteLine($"Percentual de sapos: {percentualS.ToString("F2", CultureInfo.InvariantCulture)} %");

            }
        }
    }

}
    }
}
