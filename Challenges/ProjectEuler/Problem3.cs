using System;

namespace Challenges
{
    partial class ProjectEuler
    {
        // The prime factors of 13195 are 5, 7, 13 and 29.
        // What is the largest prime factor of the number 600851475143 ?
        public static void Problem3()
        {
            long number = 600851475143;

            if (number % 2 == 0)
                number /= 2;

            for (long i = 3; i < number; i+=2)
            {
                if (number % i == 0)
                {
                    if (i % 2 == 0)
                        continue;

                    bool prime = true;

                    for (long j = 3; j < i; j += 2)
                    {
                        if (j % i == 0)
                        {
                            prime = false;
                            break;
                        }
                    }

                    if (prime)
                        number /= i;
                }
            }

            Console.WriteLine(number);
        }
    }
}
