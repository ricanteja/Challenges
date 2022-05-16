using System;

namespace Challenges
{
    partial class ProjectEuler
    {
        // A Pythagorean triplet is a set of three natural numbers, a < b < c, for which, a^2 + b^2 = c^2
        // For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
        // There exists exactly one Pythagorean triplet for which a + b + c = 1000
        // Find the product abc.
        static public void Problem9()
        {
            int total = 1000;
            int product = 0;

            for (int i = 1; i < total; i++)
            {
                bool found = false;

                for (int j = i; j < total; j++)
                {
                    int c = total - (i + j);

                    if ((i * i) + (j * j) == c * c)
                    {
                        product = i * j * c;
                        found = true;

                        break;
                    }
                }

                if (found)
                    break;
            }

            Console.WriteLine(product);
        }
    }
}
