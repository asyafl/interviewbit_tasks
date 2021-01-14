using System;
using System.Collections.Generic;
using System.Linq;

namespace MaxSumContiguousSubarray
{
    /// <summary>
    /// Input format : The first and the only argument contains an integer array, A.
    /// Output: Return an integer representing the maximum possible sum of the contiguous subarray.
    /// Constraints:1 <= N <= 1e6 ; -1000 <= A[i] <= 1000
    /// Input 1:  A = [1, 2, 3, 4, -10] Output 1: 10
    /// Explanation 1: The subarray[1, 2, 3, 4] has the maximum possible sum of 10.
    /// Input 2: A = [-2, 1, -3, 4, -1, 2, 1, -5, 4]  Output 2:6
    /// Explanation 2:
    /// The subarray[4, -1, 2, 1] has the maximum possible sum of 6.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var arr = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4};

            List<int> A = arr.ToList();

            Console.WriteLine(s.MaxSubArray(A));
        }

      public  class Solution
        {
            public int MaxSubArray(List<int> A)
            {
                int maxResult = int.MinValue;
                int sum = 0;

                for(int i = 0; i < A.Count; i++)
                {
                    sum += A[i];
                    if (sum < A[i])
                    {
                        sum = A[i];
                    }
                    if(maxResult < sum)
                    {
                        maxResult = sum;
                    }
                }

                return maxResult;
            }
        }
    }
}
