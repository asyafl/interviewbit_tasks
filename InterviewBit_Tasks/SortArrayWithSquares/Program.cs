using System;
using System.Collections.Generic;
using System.Linq;

namespace SortArrayWithSquares
{


    /// <summary>
    /// Problem Description
    /// Given a sorted array A containing N integers both positive and negative.
    /// You need to create another array containing the squares of all the elements in A and return it in non-decreasing order.
    /// Try to this in O(N) time.
    /// Input Format: First and only argument is an integer array A.
    /// Output Format: Return a integer array as described in the problem above
    /// Examples:
    /// Input 1:  A = [-6, -3, -1, 2, 4, 5]   Output 1: [1, 4, 9, 16, 25, 36]  
    /// Input 2:  A = [-5, -4, -2, 0, 1]      Output 2: [0, 1, 4, 16, 25]
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var arr = new int[] { -5, -4, -2, 0, 1 };

            List<int> A = arr.ToList();

            var AA = s.Solve(A);

            foreach (var a in AA)
            {
                Console.WriteLine(a);
            }

        }
    }

    public class Solution
    {
        public List<int> Solve(List<int> A)
        {
            List<int> result = new List<int>();

            int tmp = 0;

            for(int i =0; i< A.Count; i++)
            {
                if(A[i] < 0)
                {
                    tmp = i;
                }
                else
                {
                    break;
                }
            }


            if(tmp == 0 || (tmp) == A.Count - 1)
            {
                for (int i = 0; i < A.Count; i++)
                {
                    var sqResult = A[i] * A[i];
                    result.Add(sqResult);
                }
            }
            else
            {

                int i = tmp + 1;
                int j = tmp;

                while (j >= 0 && i < A.Count)
                {
                    if (A[i] > Math.Abs(A[j]))
                    {
                        var sqResult = A[j] * A[j];
                        result.Add(sqResult);
                        j--;
                    }
                    else if (A[i] < Math.Abs(A[j]))
                    {
                        var sqResult = A[i] * A[i];
                        result.Add(sqResult);
                        i++;
                    }
                    else
                    {
                        var sqResult = A[i] * A[i];
                        result.Add(sqResult);
                        result.Add(sqResult);
                        i++;
                        j--;
                    }
                  
                }

                if (j < 0 && i == A.Count)
                {
                    return result;
                }

                else if (j >= 0)
                {
                    for(int jj = j; jj >= 0; jj--)
                    {
                        var sqResult = A[jj] * A[jj];
                        result.Add(sqResult);
                    }
                }
                else
                {
                    for (int ii = i; ii < A.Count; ii++)
                    {
                        var sqResult = A[ii] * A[ii];
                        result.Add(sqResult);
                    }
                }

            }

            return result;
        }
    }
}
