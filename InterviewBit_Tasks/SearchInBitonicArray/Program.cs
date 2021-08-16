using System;
using System.Collections.Generic;

namespace SearchInBitonicArray
{
    /// <summary>
    /// Given a bitonic sequence A of N distinct elements, write a program to find a given element B in the bitonic sequence in O(logN) time.
    /// NOTE:
    /// A Bitonic Sequence is a sequence of numbers which is first strictly increasing then after a point strictly decreasing.
    /// Problem Constraints
    /// 3 <= N <= 105
    /// 1 <= A[i], B <= 108
    /// Given array always contain a bitonic point.
    /// Array A always contain distinct elements.
    /// Input Format:  First argument is an integer array A denoting the bitonic sequence. Second argument is an integer B.
    /// Output Format: Return a single integer denoting the position(0 index based) of the element B in the array A if B doesn't exist in A return -1.
    /// Input 1: A = [3, 9, 10, 20, 17, 5, 1]  B = 20 Output: 3
    /// Input 2: A = [5, 6, 7, 8, 9, 10, 3, 2, 1]  B = 30 Output: -1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var A = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 20, 19, 18, 17, 16, 15, 14, 13, 12, 11 };
            var B = 12;
            // Output: 18
            Console.WriteLine(s.Solve(A, B));
        }
    }

    public class Solution
    {
        public int Solve(List<int> A, int B)
        {
            var bitonicPoint = int.MinValue;
            var countA = A.Count;
            var index = 0;

            for (int i = 0; i < countA; i++)
            {
                if (A[i] == B)
                {
                    return i;
                }
                else if (A[i] > bitonicPoint)
                {
                    bitonicPoint = A[i];
                    index = i;
                }
                else
                {
                    break;
                }
            }

            if (bitonicPoint < B || A[countA - 1] > B)
            {
                return -1;
            }


            return BinarySearch(A, B, index);
        }

        private int BinarySearch(List<int> A, int B, int s)
        {
            var start = s;
            var end = A.Count - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;

                if (A[mid] == B)
                {
                    return mid;
                }
                else if (B > A[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }

            if (A[end + 1] == B)
            {
                return end + 1;
            }
            else
            {

                return -1;
            }
        }
    }
}
