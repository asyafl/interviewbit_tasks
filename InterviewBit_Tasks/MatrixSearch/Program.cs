using System;
using System.Collections.Generic;

/// <summary>
/// Given a matrix of integers A of size N x M and an integer B.
/// Write an efficient algorithm that searches for integar B in matrix A.
/// This matrix A has the following properties
/// Integers in each row are sorted from left to right.
/// The first integer of each row is greater than or equal to the last integer of the previous row.
/// Return 1 if B is present in A, else return 0.
/// Note: Rows are numbered from top to bottom and columns are numbered from left to right.
/// </summary>
namespace MatrixSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();

            var arr = new List<int> { 3, 3, 11, 12, 14 };
            var arr1 = new List<int> { 16, 17, 30, 34, 35 };
            var arr2 = new List<int> { 45, 48, 49, 50, 52 };

            var arr3 = new List<int> { 56, 59, 63, 63, 65 };
            var arr4 = new List<int> { 67, 71, 72, 73, 79 };
            var arr5 = new List<int> { 80, 84, 85, 85, 88 };
            var arr6 = new List<int> { 88, 91, 92, 93, 94 };

            List<List<int>> A = new List<List<int>>
            {
                arr,
                arr1,
                arr2,
                arr3,
                arr4,
                arr5,
                arr6,
            };


            Console.WriteLine(s.SearchMatrix(A, 94));
        }


    }

    public class Solution
    {
        public int SearchMatrix(List<List<int>> A, int B)
        {

            var row = 0;

            var colCount = A[0].Count;
            var rowCount = A.Count;

            for (int i = 0; i < rowCount; i++)
            {
                if (B < A[i][0])
                {
                    if (i == 0)
                    {
                        return 0;
                    }

                    else
                    {
                        row = i - 1;
                        break;
                    }

                }

                if (i == rowCount - 1)
                {
                    row = i;
                }
            }

            for (int j = 0; j < colCount; j++)
            {
                var tmp = A[row][j];

                if (tmp == B)
                {
                    return 1;
                }

                if (tmp > B)
                {
                    break;
                }
            }


            return 0;
        }
    }

}
