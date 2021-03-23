using System;

namespace VerifyPrime
{
    /// <summary>
    ///  Given a number N, verify if N is prime or not.
    ///  Return 1 if N is prime, else return 0.
    ///  Example:
    ///  Input : 7
    ///  Output : 1
    /// </summary>



    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();

            Console.WriteLine(s.IsPrime(12));
        }
    }

    public class Solution
    {
        public int IsPrime(int A)
        {
            int size = (int)Math.Ceiling(Math.Sqrt(A));

            int result = 1;

            if(A == 1)
            {
                return 0;
            }

            for(int i = 2; i<= size; i++)
            {
                if(A % i == 0)
                {
                    result = 0;
                    break;
                }
            }

            return result;
        }
    }
}
