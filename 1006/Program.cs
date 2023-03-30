using System;
using System.Globalization;

namespace URI06
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, MEDIA, pA, pB, pC;

            A = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            pA = 2;
            pB = 3;
            pC = 5;

            MEDIA = ((A * pA) + (B * pB) + (C * pC) ) / (pA + pB + pC);

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F1", CultureInfo.InvariantCulture));

        }
    }
}
