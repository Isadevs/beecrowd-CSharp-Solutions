using System;
using System.Globalization;

namespace URI14
{
    class Program
    {
        static void Main(string[] args)
        {
            double y, media;

            int x = int.Parse(Console.ReadLine());
            y = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            media = x / y;

            Console.WriteLine(media.ToString("F3", CultureInfo.InvariantCulture) + " km/l");

        }
    }
}
