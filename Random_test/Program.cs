using System;

namespace Random_test
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int temp = random.Next(40);

            if (temp >= 20)

                Console.WriteLine($" Temperaturen är {temp} grader och har överskridit gränsnivån");

            else

                Console.WriteLine($"Temperaturen är {temp} grader och är inom gränsnivån");


            Random r = new Random();
            Console.WriteLine(r.Next());
            Console.WriteLine(r.Next(100));
            Console.WriteLine(r.Next(1, 7));


        }

        
    }
}
