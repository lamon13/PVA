using System;

namespace opakovani
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int cislo = int.Parse(Console.ReadLine());

                for (int i = 0; i < cislo; i++)
                {
                    Console.WriteLine("Cyklus: " + (i + 1));
                }
                Console.ReadKey();
            }
        }
    }
}
