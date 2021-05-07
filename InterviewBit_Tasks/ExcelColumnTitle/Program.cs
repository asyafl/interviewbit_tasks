using System;
using System.Collections.Generic;
using System.Linq;

namespace ExcelColumnTitle
{
    /// <summary>
    /// Problem Description
    /// Given a positive integer A, return its corresponding column title as appear in an Excel sheet.
    /// Problem Constraints: 1 <= A <= 1000000000
    /// Input Format: First and only argument is integer A.
    /// Output Format: Return a string, the answer to the problem.
    /// Example Input: 28 
    /// Output: AB
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.convertToTitle(943566));
        }
    }
    public class Solution
    {
        public string convertToTitle(int A)
        {
            var result = new List<char>();


          while(A > 0)
            {
                var tmp = A % 26;

                if(tmp == 0)
                {
                    tmp = 26;
                }
                var r = 'A' - 1 + tmp;

                A = (A - 1) / 26;

                result.Add(Convert.ToChar(r));
            }
            result.Reverse();

            return new string(result.ToArray());
        }
    }

}
