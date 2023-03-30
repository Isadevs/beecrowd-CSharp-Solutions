using System;
using System.Globalization;

namespace URI10
{
    class Program
    {
        static void Main(string[] args)
        {
            int codigo, quantidade, codigo2, quantidade2; ;
            double valorUnitario, valorUnitario2, total;

            string[] produtos = Console.ReadLine().Split(' ');
            string[] produtos2 = Console.ReadLine().Split(' ');

            codigo = int.Parse(produtos[0]);
            quantidade = int.Parse(produtos[1]);
            valorUnitario = double.Parse(produtos[2], CultureInfo.InvariantCulture);

            codigo2 = int.Parse(produtos2[0]);
            quantidade2 = int.Parse(produtos2[1]);
            valorUnitario2 = double.Parse(produtos2[2], CultureInfo.InvariantCulture);

            total = (quantidade * valorUnitario) + (quantidade2 * valorUnitario2);

            Console.WriteLine("VALOR A PAGAR: R$ " + total.ToString("F2", CultureInfo.InvariantCulture));


        }
    }
}
