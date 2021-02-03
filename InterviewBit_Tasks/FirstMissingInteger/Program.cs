using System;
using System.Collections.Generic;
using System.Linq;

namespace FirstMissingInteger
{

    /// <summary>
    /// Given an unsorted integer array, find the first missing positive integer.
    /// Example:
    /// Given [1,2,0] return 3,
    /// [3,4,-1,1] return 2,
    /// [-8, -7, -6] returns 1
    /// Your algorithm should run in O(n) time and use constant space.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var arr = new int[] { 3, 4, -1, 1};

            List<int> A = arr.ToList();

            Console.WriteLine(s.FirstMissingPositive(A));
        }

    }

    public class Solution
    {
        public int FirstMissingPositive(List<int> A)
        {
            var posSet = new HashSet<int>();

            for (int i = 0; i < A.Count; i++)
            {
                if (A[i] > 0)
                {
                    posSet.Add(A[i]);
                }
            }

            var count = posSet.Count;

            if(count == 0)
            {
                return 1;
            }

            var missingInt = count + 1; 

            for(int i = 1; i <= count; i++)
            {
                if (!posSet.Contains(i))
                {
                    return i;
                }
            }
            return missingInt;
        }
    }
}
