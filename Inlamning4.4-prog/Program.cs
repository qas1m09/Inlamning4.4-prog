using System;

namespace Inlamning4._4_prog
{
    class Program
    {
        static void Main(string[] args)
        {
            string val = "";

            while (val != "3")
            {
                Console.WriteLine("1. Subtrahera ett tal med ett annat tal");
                Console.WriteLine("2. Dividera ett tal med ett annat tal");
                Console.WriteLine("3. Avsluta programmet");

                val = Console.ReadLine();

                if (val == "1")
                {
                    Console.WriteLine("Skriv ett tal att subtrahera: ");
                    int tal1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv ett till tal att subtrahera med: ");
                    int tal2 = int.Parse(Console.ReadLine());
                    int result = tal1 - tal2;
                    Console.WriteLine("Resultat: " + result);
                }

                else if (val == "2")
                {
                    Console.WriteLine("Skriv ett tal att dividera med:");
                    int tal1 = int.Parse(Console.ReadLine());
                    Console.WriteLine("Skriv ett till tal att dividera med:");
                    int tal2 = int.Parse(Console.ReadLine());

                    if (tal2 == 0)
                    {
                        Console.WriteLine("FEL: Kan inte dividera med noll!");
                    }
                    else
                    {
                        int result = tal1 / tal2;
                        Console.WriteLine("Resultat: " + result);
                    }
                    
                }

                else if (val == "3")
                {
                    Console.WriteLine("Programmet avslutas. Dra åt helvete!");
                }
                else
                {
                    Console.WriteLine("Ogiltigt val, försök igen.");

                }
            }
        }
    }
}