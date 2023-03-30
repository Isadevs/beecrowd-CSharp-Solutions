internal class Program
{
    private static void Main(string[] args)
    {
        /*double rombus;
        double imposto;
        double m;*/

        double rombus = Convert.ToDouble(Console.ReadLine());
        double imposto;

            if(rombus < 2000.00){
                Console.WriteLine("Isento");
            }
           
            if(rombus > 2000 && rombus <= 3000){
                imposto = (rombus - 2000)* 0.08;
                Console.WriteLine("R$ " + imposto.ToString("F2"));
            }
            
            if(rombus > 3000 && rombus <= 4500){
                imposto = (rombus - 3000) * 0.18 + 80;
                Console.WriteLine("R$ " + imposto.ToString("F2"));
            }

            if(rombus > 4500){
                imposto =  (rombus - 4500) * 0.28 + 270 + 80;
                Console.WriteLine("R$ " + imposto.ToString("F2"));
            }       
    }
} 
