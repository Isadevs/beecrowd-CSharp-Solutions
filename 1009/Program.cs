using System;
using System.Globalization;

namespace URI09
{
    class Program
    {
        static void Main(string[] args)
        {
            double A, B, C, triangulo, circulo, trapezio, quadrado, retangulo, pi;
            
            pi = 3.14159;
            
            string[] vetor = Console.ReadLine().Split(" ");
            A = double.Parse(vetor[0], CultureInfo.InvariantCulture);
            B = double.Parse(vetor[1], CultureInfo.InvariantCulture);
            C = double.Parse(vetor[2], CultureInfo.InvariantCulture);

            triangulo = A * C / 2;
            circulo = pi * Math.Pow(C, 2);
            trapezio = (double) ((A + B) * C) / 2.0;
            quadrado = B * B;
            retangulo = A * B;

            Console.WriteLine("TRIANGULO: " + triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: " + circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: " + trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: " + quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: " + retangulo.ToString("F3", CultureInfo.InvariantCulture));

        }
    }
}
