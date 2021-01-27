using System;
using System.Collections.Generic;

namespace MaximumSumSquareSubMatrix
{
    /// <summary>
    /// Problem Description
    /// Given a 2D integer matrix A of size N x N find a B x B submatrix where B<= N and B>= 1,
    /// such that sum of all the elements in submatrix is maximum.
    /// Input Format: First arguement is an 2D integer matrix A. Second argument is an integer B.
    /// Output Format: Return a single integer denoting the maximum sum of submatrix of size B x B.
    /// Input 1: 
    ///          A = [
    /// [1, 1, 1, 1, 1]
    /// [2, 2, 2, 2, 2]
    ///  [3, 8, 6, 7, 3]
    ///  [4, 4, 4, 4, 4]
    ///  [5, 5, 5, 5, 5]
    /// ]
    ///B = 3
    ///Output 1: 48 
    ///
    ///My algorith solve this problem in O(N2) time.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            /* var arr = new int[,] { 
                 { 1, 1, 1, 1, 1 }, 
                 { 2, 2, 2, 2, 2 } , 
                 { 3, 8, 6, 7, 3 } ,
                 { 4, 4, 4, 4, 4 },
                 { 5, 5, 5, 5, 5 }
             } ;*/

            var arr = new int[,] { { 2, 2 }, { 2, 2 } };


            List<List<int>> A = new List<List<int>>();

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                List<int> AA = new List<int>();
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    AA.Add(arr[i, j]);
                }
                A.Add(AA);
            }
            Console.WriteLine(s.Solve(A, 2));
        }
    }
    public class Solution
    {
        public int Solve(List<List<int>> A, int B)
        {

            if (A.Count == 1)
            {
                return A[0][0];
            }

            var listSum = new List<List<int>>();

            var aX = A[0].Count;
            var aY = A[1].Count;

            for (int i = 0; i < aX; i++)
            {
                var tmpList = new List<int>();
                var lim = i + B;
                if (lim <= aY)
                {
                    for (int j = 0; j < aY; j++)
                    {
                        var res = 0;
                        for (int k = i; k < lim; k++)
                        {
                            res += A[k][j];
                        }
                        tmpList.Add(res);
                    }
                    listSum.Add(tmpList);
                }
            }

            var sX = listSum.Count;
            var sY = listSum[0].Count;
            var max = int.MinValue;


            for (int i = 0; i < sX; i++)
            {
                var temp = 0;
                for (int j = 0; j < sY; j++)
                {
                    if (j == 0)
                    {
                        for (int k = 0; k < B; k++)
                        {
                            temp += listSum[i][k];
                        }
                    }
                    else if ((j + B - 1) < sY)
                    {
                        temp = temp - listSum[i][j - 1] + listSum[i][j + B - 1];
                    }

                    if (temp > max)
                    {
                        max = temp;
                    }
                }
            }

            return max;

        }
    }
}
