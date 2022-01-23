using System;

namespace secventa
{
    class Program
    {
        /// <summary>
        /// Functia determina cea mai lunga secventa din vector care incepe si se termina
        /// cu acceasi cifra para si afiseaza lungimea acelei secvente si cifra cu care incepe si se termina
        /// Daca sunt mai multe astfel de secvente se vor afisa toate cifrele cu care incep si se termina acele secvente.
        /// E nevoie de o rezolvare eficienta/liniara.
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            int n,i;
            Console.WriteLine("Introduceti nr de elemente ale vectorului:");
            n = int.Parse(Console.ReadLine());

            Console.WriteLine("Introduceti pe o singura linie elementele vectorului:");
            string linie = Console.ReadLine();

            string[] tokens = linie.Split(' ', StringSplitOptions.RemoveEmptyEntries);

            if (tokens.Length < n || tokens.Length > n)
            {
                Console.WriteLine($"Nu s-au introdus {n} elemente!");
                return;
            }

            int[] vector = new int[n];
            for (i = 0; i < n; i++)
                vector[i] = int.Parse(tokens[i]);

            int[] primaPoz = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            int[] ultimaPoz = { -1, -1, -1, -1, -1, -1, -1, -1, -1, -1 };
            int lungimeMax = -1;

            for(i=0;i<n;i++)
            {
                if(vector[i]%2==0)
                {
                    if (primaPoz[vector[i]] == -1)
                        primaPoz[vector[i]] = i;
                    else
                    {
                        ultimaPoz[vector[i]] = i;
                        if (ultimaPoz[vector[i]] - primaPoz[vector[i]] + 1 > lungimeMax)
                            lungimeMax = ultimaPoz[vector[i]] - primaPoz[vector[i]] + 1;
                    }
                }
            }

            Console.WriteLine("Lungimea maxima este: {0}", lungimeMax);

            for(i=0;i<10;i=i+2)
            {
                if(ultimaPoz[i]!=-1 && ultimaPoz[i]-primaPoz[i]+1==lungimeMax)
                    Console.WriteLine($"Nr. cu care incepe secventa este: {i} ");
            }


        }
    }
}
