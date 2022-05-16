using System;

namespace Challenges
{
    partial class ProjectEuler
    {
        // By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        // What is the 10 001st prime number?
        static public void Problem7()
        {
            int limit = 10001;
            int count = 0;
            int prime = 0;

            for (int i = 0; count < limit; i++)
            {
                bool isPrime = true;

                if (i % 2 == 0)
                    continue;

                for (int j = 3; j < i; j+=2)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                }

                if (isPrime)
                {
                    prime = i;
                    count++;
                }
            }

            Console.WriteLine(prime);
        }
    }
}
