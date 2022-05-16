using System;

namespace Challenges
{
    partial class ProjectEuler
    {
        // The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
        // Find the sum of all the primes below two million.
        static public void Problem10()
        {
            int limit = 2000000;
            long total = 0;
            List<bool> primes = Enumerable.Repeat(true, limit).ToList();

            for (int i = 2; i < Math.Sqrt(limit); i++)
            {
                if (primes[i])
                {
                    for (int j = i; i * j < limit; j++)
                        primes[i * j] = false;
                }
            }

            for (int i = 2; i < limit; i++)
            {
                if (primes[i])
                    total += i;
            }

            Console.WriteLine(total);
        }
    }
}
