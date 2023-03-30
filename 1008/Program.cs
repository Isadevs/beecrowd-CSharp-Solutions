using System;
using System.Globalization;

namespace URI08
{
    class Program
    {
        static void Main(string[] args)
        {
            double  salario, valorHoraTrabalhada;
            int horas, funcionario;

            funcionario = int.Parse(Console.ReadLine());
            horas = int.Parse(Console.ReadLine());
            valorHoraTrabalhada = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            
            salario = horas * valorHoraTrabalhada;

            Console.WriteLine("NUMBER = " + funcionario);
            Console.WriteLine("SALARY = U$ " + salario.ToString("F2", CultureInfo.InvariantCulture));




        }
    }
}
