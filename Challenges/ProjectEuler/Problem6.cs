﻿using System;

namespace Challenges
{
    partial class ProjectEuler
    {
        // The sum of the squares of the first ten natural numbers is, 1^2 + 2^2 + ... + 10^2 = 385
        // The square of the sum of the first ten natural numbers is, (1 + 2 + ... + 10)^2 = 55^2 = 3025
        // Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 - 385 = 2640
        // Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
        static public void Problem6()
        {
            int max = 100;
            int sumSquare = 0;
            int squareSum = 0;
            int diff = 0;

            for (int i = 1; i <= max; i++)
                sumSquare += i * i;

            for (int i = 1; i <= max; i++)
                squareSum += i;

            squareSum *= squareSum;

            diff = squareSum - sumSquare;

            Console.WriteLine(diff);
        }
    }
}
