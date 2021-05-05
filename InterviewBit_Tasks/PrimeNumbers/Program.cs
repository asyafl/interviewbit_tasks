using System;
using System.Collections.Generic;

namespace PrimeNumbers
{
    /// <summary>
    /// Given a number N, find all prime numbers upto N ( N included ).
    /// Example:
    /// if N = 7,
    /// all primes till 7 = {2, 3, 5, 7}
    /// Make sure the returned array is sorted.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var r = s.sieve(10);

            foreach (var t in r)
            {
                Console.WriteLine(t);
            }
        }
    }

    public class Solution
    {
        public List<int> sieve(int A)
        {
            var isPrime = new bool[A + 1];

            var count = Math.Ceiling(Math.Sqrt(A));

            for (int i = 2; i <= count; i++)
            {
                if (isPrime[i])
                {
                    continue;
                }
                else
                {
                    for (int j = i + i; j <= A; j += i)
                    {
                        if (!isPrime[j])
                        {
                            isPrime[j] = true;
                        }
                    }
                }
            }

            var result = new List<int>();

            for (int i = 2; i <= A; i++)
            {
                if (!isPrime[i])
                {
                    result.Add(i);
                }
            }

            return result;
        }


    }
}
