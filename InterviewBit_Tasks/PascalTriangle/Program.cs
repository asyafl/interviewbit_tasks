using System;
using System.Collections.Generic;

namespace PascalTriangle
{
    /// <summary>
    /// Pascal Triangle
    /// Given numRows, generate the first numRows of Pascal’s triangle.
    /// Pascal’s triangle : To generate A[C] in row R, sum up A’[C] and A’[C-1] from previous row R - 1.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input the number of rows");

            if (int.TryParse(Console.ReadLine(), out int tmp))
            {
                var s = new Solution();

                var res = s.Solve(tmp);

                for (int i = 0; i < tmp; i++)
                {
                    for (int j = 0; j <= i; j++)
                    {
                        Console.Write(res[i][j] + " ");
                    }
                    Console.Write("\n");
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
            public List<List<int>> Solve(int A)
            {
                var res = new List<List<int>>();
                for (int i = 0; i < A; i++)
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
                            var t = res[i - 1][j - 1] + res[i - 1][j];
                            tmpList.Add(t);
                        }
                    }
                    res.Add(tmpList);
                }

                return res;
            }
        }
    }
