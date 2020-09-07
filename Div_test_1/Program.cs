using System;

namespace Div_test_1
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Vilken stad kommer du från?");
            string stad = Console.ReadLine();
            Console.WriteLine("Vilket är ditt drömresmål?");
            string resmål = Console.ReadLine();

            Console.WriteLine($"Hej {stad}-bo. Jag hoppas du får resa till {resmål}.");

            Console.ReadKey();
        }
            
    }
}
