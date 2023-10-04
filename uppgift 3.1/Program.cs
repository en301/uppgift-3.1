using System;

namespace uppgift_3_1
{
    class program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hur gammal är du?");
            string ålder = Console.ReadLine();

            int siffra = int.Parse(ålder);

            if (siffra >= 16 & siffra <= 19)
            {
                Console.WriteLine("Du får delta i tävlingen");
            }
            else
            {
                Console.WriteLine("Du får inte delta i tävlingen");
            }
            Console.ReadKey();
        }
    }
}