using System;
using System.Collections.Generic;

namespace PrimeSum
{
    /// <summary>
    /// Given an even number ( greater than 2 ), return two prime numbers whose sum will be equal to given number.
    /// NOTE A solution will always exist.read Goldbach’s conjecture
    /// Example:
    /// Input : 4 Output: 2 + 2 = 4
    /// If there are more than one solutions possible, return the lexicographically smaller solution.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();

            var res = s.primesum(4);
            foreach (var t in res)
            {
                Console.WriteLine(t);
            }

        }
    }
    public class Solution
    {
        public List<int> primesum(int A)
        {
            bool[] notPrime = new bool[A + 1];
            var count = Math.Ceiling(Math.Sqrt(A));
            var result = new List<int>();

            for (int i = 2; i <= count; i++)
            {
                if (notPrime[i])
                {
                    continue;
                }
                else
                {
                    for (int j = i + i; j <= A; j += i)
                    {
                        if (!notPrime[j])
                        {
                            notPrime[j] = true;
                        }
                    }
                }
            }

            for (int i = 2; i <= A / 2; i++)
            {
                if (!notPrime[i])
                {
                    var tmp = A - i;
                    if (!notPrime[tmp])
                    {
                        result.Add(i);
                        result.Add(tmp);
                        break;
                    }
                }
            }
            return result;
        }
    }
}
