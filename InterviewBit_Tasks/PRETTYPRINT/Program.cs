using System;
using System.Collections.Generic;

namespace PRETTYPRINT
{
    /// <summary>
    /// Print concentric rectangular pattern in a 2d matrix.
    /// Let us show you some examples to clarify what we mean.
    /// The outermost rectangle is formed by A, then the next outermost is formed by A-1 and so on.
    /// You will be given A as an argument to the function you need to implement, and you need to return a 2D array.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var res = s.PrettyPrint(4);


            for (int i = 0; i < res.Count; i++)
            {
                for (int j = 0; j < res[1].Count; j++)
                {
                    if (j == res[0].Count - 1)
                    {
                        Console.WriteLine(res[i][j] + " ");
                    }
                    else
                    {
                        Console.Write(res[i][j] + " ");
                    }

                }
            }

        }
    }

    public class Solution
    {
        public List<List<int>> PrettyPrint(int A)
        {
            var result = new List<List<int>>();
            var size = A * 2 - 1;
            var firstPart = Math.Floor(size / 2.0);

            for (int i = 0; i <= firstPart; i++)
            {
                var tmpList = new List<int>();

                int lastVal = A;

                for (int j = 0; j <= i; j++)
                {
                    if (j == 0)
                    {
                        tmpList.Add(A);
                    }
                    else
                    {
                        lastVal = tmpList[j - 1] - 1;
                        tmpList.Add(lastVal);
                    }
                  
                }

                for (int j = i+1; j < size - i; j++)
                {
                    tmpList.Add(lastVal);
                }

                for (int j = size - i; j < size; j++)
                {
                    tmpList.Add(tmpList[j - 1] + 1);
                }

                result.Add(tmpList);
            }

            for(int i = (int)firstPart - 1; i >= 0; i--)
            {
                result.Add(result[i]);
            }

            return result;
        }
    }
}
