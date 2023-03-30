using System;
using System.Globalization;

namespace URI05
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, MEDIA, pesoA, pesoB, somaPeso;
            pesoA = 3.5;
            pesoB = 7.5;
            somaPeso = pesoA + pesoB;
            
            A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            MEDIA = ((pesoA * A) + (pesoB * B))/ somaPeso;

            Console.WriteLine("MEDIA = " + MEDIA.ToString("F5", CultureInfo.InvariantCulture));

        }
    }
}
