using System;
using System.Text;

namespace NextSimilarNumber
{
    /// <summary>
    /// Problem Description:
    /// Given a number A in a form of string.
    /// You have to find the smallest number that has same set of digits as A and is greater than A.
    /// If A is the greatest possible number with its set of digits, then return -1.
    /// Problem Constraints: 1 <= A <= 10100000; A doesn't contain leading zeroes.
    /// Input Format:
    /// First and only argument is an numeric string denoting the number A.
    /// Output Format:
    /// Return a string denoting the smallest number greater than A with same set of digits , 
    /// if A is the largest possible then return -1.
    /// Examples: 
    /// Input: 218765 Output: 251678
    /// Input: 4321 Output: -1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.Solve("1152"));
        }
    }
    public class Solution 
    {
        public string Solve(string A)
        {
            var n = A.Length;
            int i;

            for (i = n - 1; i > 0; i--)
            {
                if (A[i] > A[i - 1])
                {
                    break;
                }
            }
            if (i == 0)
            {
                return "-1";
            }
            else
            {
                int x = A[i - 1], min = i;

                for (int j = i + 1; j < n; j++)
                {
                    if (A[j] > x && A[j] < A[min])
                    {
                        min = j;
                    }
                }

                
                var str = Swap(A, i - 1, min);
                var charArr = str.ToCharArray();
                Array.Sort(charArr, i , n - i);
                return new string(charArr);
            }

        }

        private  string Swap(string A, int i, int j)
        {
            StringBuilder sb = new StringBuilder(A);
            sb[i] = A[j];
            sb[j] = A[i];

            return sb.ToString();
        }

      
    }

}
