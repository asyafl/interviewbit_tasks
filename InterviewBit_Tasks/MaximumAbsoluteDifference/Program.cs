using System;
using System.Collections.Generic;
using System.Linq;

namespace MaximumAbsoluteDifference
{
    /// <summary>
    /// You are given an array of N integers, A1, A2 ,…, AN. Return maximum value of f(i, j) for all 1 ≤ i, j ≤ N.
    /// f(i, j) is defined as |A[i] - A[j]| + |i - j|, where |x| denotes absolute value of x.
    /// For example,
    /// A=[1, 3, -1]
    /// f(1, 1) = f(2, 2) = f(3, 3) = 0
    /// f(1, 2) = f(2, 1) = |1 - 3| + |1 - 2| = 3
    /// f(1, 3) = f(3, 1) = |1 - (-1)| + |1 - 3| = 4
    /// f(2, 3) = f(3, 2) = |3 - (-1)| + |2 - 3| = 5
    /// So, we return 5.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var arr = new int[] { 2, 2, 2 };

            List<int> A = arr.ToList();

            Console.WriteLine(s.MaxArr(A));
        }
    }
    public class Solution
    {
        public int MaxArr(List<int> A)
        {
            var count = A.Count;

            var maxVal = 0;
            var minVal = 0;

            int result = 0;
            bool first = true;

            for (int i = 0; i< count; i++)
            {
                var tempPosi = A[i] - i ;
                var tempNeg = -A[i] - i;

                if (first || tempPosi > maxVal)
                {
                    maxVal = tempPosi;
                }
                if (first || tempNeg > minVal)
                {
                    minVal = tempNeg;
                }


                int posj = -A[i] + i;
                int negj = A[i] + i;

                int pos = maxVal + posj;
                int neg = minVal + negj;

                int m = Math.Max(pos, neg);

                if (m > result)
                {
                    result = m;
                }

                first = false;
            }

            return result;
        }
    }
}
