using System;

namespace _4_numere_in_ordine
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c, d, aux;
            bool ok;
            Console.WriteLine("Introduceti cele 4 numere pe o singura linie!");
            string linie = Console.ReadLine();
            char[] seps = { ' ' };
            string[] tokens = linie.Split(seps, StringSplitOptions.RemoveEmptyEntries);
            if (tokens.Length < 4 || tokens.Length > 4)
            {
                Console.WriteLine("Nu s-au introdus 4 numere");
                return;
            }

            a = int.Parse(tokens[0]);
            b = int.Parse(tokens[1]);
            c = int.Parse(tokens[2]);
            d = int.Parse(tokens[3]);

            ok = false;

            while(ok!=true)
            {
                ok = true;
                if (a>b)
                {
                    aux = a;
                    a = b;
                    b = aux;
                    ok = false;
                }
                if (b>c)
                {
                    aux = b;
                    b = c;
                    c = aux;
                    ok = false;
                }
                if(c>d)
                {
                    aux = d;
                    d = c;
                    c = aux;
                    ok = false;
                }
            }

            Console.WriteLine($"Numerele ordonate crescator sunt: {a}, {b}, {c}, {d}");
        }
    }
}
