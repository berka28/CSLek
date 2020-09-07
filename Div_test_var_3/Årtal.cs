using System;
using System.Collections.Generic;
using System.Text;

namespace Div_test_var_3
{
    class Årtal
    {
        public int Årtalet { get; set; }

        public void FrågaOmÅr()
        {
            Console.Write("Vilket årtal är det nu? \n\n");

            try
            {
                Årtalet = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Ledsen, men du måste skriva årtalet i siffror!\n ");
                Console.Write("Vilket årtal är det nu? \n");
                Console.WriteLine();

                try
                {
                    Årtalet = Convert.ToInt32(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine();
                    Console.WriteLine("Allvarligt, lägg ner!");
                }
                    if (Årtalet == 2020)
                    {
                        Console.WriteLine();
                        Console.WriteLine("Helt rätt, årtalet är 2020.");
                    }
                    else
                    {
                        Console.WriteLine();
                        Console.WriteLine("Nja, årtalet är ju 2020.");
                    }
                }
        }
    }
}
