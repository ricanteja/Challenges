using System;

namespace Challenges
{
    partial class ProjectEuler
    {
        // 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
        // What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
        static public void Problem5()
        {
            int max = 20;
            int smallest = 0;

            for (int i = 1; i < int.MaxValue; i++)
            {
                bool found = true;

                for (int j = max; j > 0; j--)
                {
                    if (i % j != 0)
                    {
                        found = false;
                        break;
                    }
                }

                if (found)
                {
                    smallest = i;
                    break;
                }
            }

            Console.WriteLine(smallest);
        }
    }
}
