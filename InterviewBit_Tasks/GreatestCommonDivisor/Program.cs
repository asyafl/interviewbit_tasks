using System;

namespace GreatestCommonDivisor
{
    /// <summary>
    /// Given 2 non negative integers m and n, find gcd(m, n)
    /// GCD of 2 integers m and n is defined as the greatest integer g such that g is a divisor of both m and n.
    /// Both m and n fit in a 32 bit signed integer.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.gcd(6,12));
        }
    }

   public class Solution
    {
        public int gcd(int A, int B)
        {
            if(A == 0)
            {
                return B;
            }
            else if(B == 0)
            {
                return A;
            }
            else
            {
                var min = Math.Min(A,B);
                var max = Math.Max(A, B);
                return gcd(max - min, min);
            }

        }
    }

}
