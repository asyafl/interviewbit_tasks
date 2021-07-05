using System;
using System.Collections.Generic;
using System.Linq;

namespace Stringoholics
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var strList = new string[] { "a", "ababa", "aba" };
            
            Console.WriteLine(s.Solve(strList.ToList()));
        }
    }
    public class Solution
    {
        public int Solve(List<string> A)
        {
            var orderedA = A.OrderByDescending(x => x).ToList();
            var maxLen = orderedA[0].Length;
            var result = 0;

            var listOfResults = new List<List<int>>();


            for(int i = 0; i<A.Count; i++)
            {
                var tmpStr = orderedA[i] + orderedA[i] + orderedA[i];
                var strLen = orderedA[i].Length;
                var tmpList = new List<int>(); 
                
                if(i != 0 && orderedA[i].Length == 1)
                {
                    tmpList = listOfResults[0];
                }
                else
                {
                    for (int j = 1; j <= strLen; j ++)
                    {
                        var tt = j % strLen;
                        var jj = tt + j;
                        var subStr = tmpStr.Substring(jj, strLen);
                        if (orderedA[i] == subStr)
                        {
                            tmpList.Add(j);
                        }
                    }

                }

                listOfResults.Add(tmpList);
            }

            listOfResults.OrderByDescending(x => x.Count);

            for(int i = 0; i < listOfResults.Count; i++)
            {
                listOfResults[i].OrderBy(x => x);
            }

            
            for(int i = 0; i< listOfResults[0].Count; i++)
            {

            }
            return result;
            
        }
    }
}
