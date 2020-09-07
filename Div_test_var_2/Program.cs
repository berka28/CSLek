using System;

namespace Div_test_var_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Vilket årtal är det nu?");
            string årtaltext = Console.ReadLine();
            int årtal = Convert.ToInt32(årtaltext);
            int årtal20 = årtal + 20;
            Console.WriteLine($"Om 20 år är det \"{årtal20}\".");

            Console.WriteLine();


            Console.WriteLine("Hur högt kan du hoppa höjdhopp mätt i meter (avgränsa med komma [,] ?");
            string höjden = Console.ReadLine();
            double höjd = Convert.ToDouble(höjden);
            double skillnad = 2.45 - höjd;
            Console.WriteLine($"Världsrekordet i höjdhopp är för närvarande 2,45 meter, vilket är en skillnad på {skillnad} meter.");

            Console.WriteLine();

            Console.WriteLine("Skriv in två tal");
            double tal1 = Convert.ToDouble(Console.ReadLine());
            double tal2 = Convert.ToDouble(Console.ReadLine());

            double summa = tal1 + tal2;
            double produkt = tal1 * tal2;

            Console.WriteLine($"Summan av de två talen är: {summa}");
            Console.WriteLine($"Produkten av de två talen är: {produkt}");

            Console.ReadKey();
        }
    }
}
