using System;
using System.Collections.Generic;

namespace KthRowOfPascalTriangle
{

    ///Given an index k, return the kth row of the Pascal’s triangle.
    ///Pascal’s triangle : To generate A[C] in row R, sum up A’[C] and A’[C-1] from previous row R - 1.
    ///Example: Input : k = 3  Return : [1,3,3,1]
    /// NOTE : k is 0 based. k = 0, corresponds to the row [1]. 
    /// Note:Could you optimize your algorithm to use only O(k) extra space?

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of rows");
            if (int.TryParse(Console.ReadLine(), out int A))
            {
                Solution s = new Solution();

                var res = s.GetRow(A);

                Console.Write("Return: ");
                for (int i = 0; i <= A; i++)
                {
                    Console.Write(res[i] + " ");
                }
            }
            else
            {
                Console.Write("Invalid input");
            }


        }
    }
    public class Solution
    {
        public List<int> GetRow(int A)
        {
            var listResult = new List<int>();
            if (A == 0)
            {
                listResult.Add(1);
            }
            else
            {
                for (int i = 0; i <= A; i++)
                {
                    List<int> tmpList = new List<int>();
                    for (int j = 0; j <= i; j++)
                    {
                        if (j == 0 || j == i)
                        {
                            tmpList.Add(1);
                        }
                        else
                        {
                            var t = listResult[j - 1] + listResult[j];
                            tmpList.Add(t);
                        }
                    }
                    listResult = tmpList;
                }
            }
            return listResult;
        }
    }
}
