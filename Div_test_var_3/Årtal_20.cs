using System;
using System.Collections.Generic;
using System.Text;

namespace Div_test_var_3
{
    class Årtal_20
    {
        public int Årtalet20 { get; set;}

        public void FrågaOm20År()
        {
            Console.Write("Vilket årtal är det om 20 år?\n\n");

            try
            {
                Årtalet20 = Convert.ToInt32(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Ledsen, men du måste skriva årtalet i siffror!\n ");
                Console.Write("Vilket årtal är det nu? \n");
                Console.WriteLine();
            }


            if (Årtalet20 == 2040)
            {
                Console.WriteLine();
                Console.WriteLine("Helt rätt, årtalet kommer att vara 2040.");
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Njae, du har ju ingen superkoll direkt, 2040 kommer ju årtalet att vara.");
            }
        }
    }
}
