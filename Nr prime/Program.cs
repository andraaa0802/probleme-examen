using System;

namespace Nr_prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int nr;

            Console.WriteLine("Introduceti un numar:");

            nr = int.Parse(Console.ReadLine());

            if (prim(nr)==true)
                Console.WriteLine($"{nr} este numar prim");
            else
                Console.WriteLine($"{nr} nu este numar prim");

        }

        private static bool prim(int nr)
        {
            if (nr < 2)
                return false;
            if (nr == 2)
                return true;
            if (nr % 2 == 0)
                return false;
            for (int d = 3; d * d <= nr; d = d + 2)
                if (nr % d == 0)
                    return false;
            return true;
        }
    }
}
