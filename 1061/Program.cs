using System;

namespace URI61
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Dia ");
            int diaInicial = int.Parse(Console.ReadLine());
            string[] horaInicio = Console.ReadLine().Split('');
            
            Console.Write("Dia ");
            int diaFinal = int.Parse(Console.ReadLine());
            string[] horaFim = Console.ReadLine().Split(':');

            int horaInicial = int.Parse(horaInicio[0]);
            int minutoInicial = int.Parse(horaInicio[1]);
            int segundoInicial = int.Parse(horaInicio[2]);

            int horaFinal = int.Parse(horaFim[0]);
            int minutoFinal = int.Parse(horaFim[1]);
            int segundoFinal = int.Parse(horaFim[2]);

            int inicio = (diaInicial - 1) * 24 * 60 * 60 + horaInicial * 60 * 60 + minutoInicial * 60 + segundoInicial;
            int fim = (diaFinal - 1) * 24 * 60 * 60 + horaFinal * 60 * 60 + minutoFinal * 60 + segundoFinal;

            int duracao = fim - inicio;

            int dia = duracao / (24 * 60 * 60);
            int resto = duracao % (24 * 60 * 60);
            int hora = resto / (60 * 60);
            resto = resto % (60 * 60);
            int minuto = resto / 60;
            int segundo = resto % 60;
            
            Console.WriteLine(dia + " dia(s)");
            Console.WriteLine(hora + " hora(s)");
            Console.WriteLine(minuto + " minuto(s)");
            Console.WriteLine(segundo + " segundo(s)");

        }
    }
}
