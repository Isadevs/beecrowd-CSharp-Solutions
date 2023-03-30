
internal class Program
{
    private static void Main(string[] args)
    {
        double nota_um, nota_dois, media;
        int op = 1;

        while (op == 1)
        {
            nota_um = Convert.ToDouble(Console.ReadLine());

            while (nota_um < 0 || nota_um > 10)
            {
                Console.WriteLine("nota invalida");
                nota_um = Convert.ToDouble(Console.ReadLine());
            }

            nota_dois = Convert.ToDouble(Console.ReadLine());
            
            while (nota_dois < 0 || nota_dois > 10)
            {
                Console.WriteLine("nota invalida");
                nota_dois = Convert.ToDouble(Console.ReadLine());
            }

            media = (nota_um + nota_dois) / 2;
            Console.WriteLine($"media = {media.ToString("F2")}");

            Console.WriteLine("novo calculo (1-sim 2-nao)");
            op = Convert.ToInt32(Console.ReadLine());

            while (op != 1 && op != 2)
            {
                Console.WriteLine("novo calculo (1-sim 2-nao)");
                op = Convert.ToInt32(Console.ReadLine());
            }
            
        }
    }
}