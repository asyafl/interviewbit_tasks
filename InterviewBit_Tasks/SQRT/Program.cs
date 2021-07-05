using System;

namespace SQRT
{
    /// <summary>
    /// Given an integar A.
    /// Compute and return the square root of A.
    /// If A is not a perfect square, return floor(sqrt(A)).
    /// DO NOT USE SQRT FUNCTION FROM STANDARD LIBRARY
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.Sqrt(2147483647));
        }
    }

    public class Solution
    {
        public int Sqrt(int A)
        {
            int i = 1;

            while (i < A / i)
            {
                i++;
            }


            if (i > A / i)
            {
                return --i;
            }
            else
            {
                return i;
            }

        }
    }

}
