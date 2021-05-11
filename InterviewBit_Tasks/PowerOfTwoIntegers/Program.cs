using System;

namespace PowerOfTwoIntegers
{
    class Program
    {
        /// <summary>
        /// Given a positive integer which fits in a 32 bit signed integer, 
        /// find if it can be expressed as A^P where P > 1 and A > 0. A and P both should be integers.
        /// Example: Input : 4 Output : 1
        /// </summary>
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.isPower(1024));
        }
    }
    public class Solution
    {
        public int isPower(int A)
        {
            if (A == 1)
            {
                return 1;
            }
            else
            {
                var sqrt = Math.Ceiling(Math.Sqrt(A));
                for (int i = 2; i <= sqrt; i++)
                {
                     for(int j = 2; j<32; j++)
                    {
                        if(Math.Pow(i, j) == A)
                        {
                            return 1;
                        }
                    }
                }
            }

            return 0;
            
        }
    }
}
