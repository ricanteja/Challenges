using System;

namespace Challenges
{
    partial class ProjectEuler
    {
        // A palindromic number reads the same both ways.
        // The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
        // Find the largest palindrome made from the product of two 3-digit numbers.
        static public void Problem4()
        {
            int palindrome = 0;
            int x = 999, y = 999;

            var isPalindrome = (String str) =>
            {
                for (int i = 0; i < str.Length / 2; i++)
                {
                    if (str[i] != str[(str.Length - 1) - i])
                        return false;
                }

                return true;
            };

            for (int i = x; i > 0; i--)
            {
                for (int j = y; j > 0; j--)
                {
                    if (isPalindrome((i * j).ToString()) && i * j > palindrome)
                    {
                        palindrome = i * j;
                        break;
                    }
                }
            }

            Console.WriteLine(palindrome);
        }
    }
}
