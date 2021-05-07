using System;

namespace ExcelColumnNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.titleToNumber("BAQTZ"));
        }
    }

    public class Solution
    {
        public int titleToNumber(string A)
        {
            int res = 0;
            for (int i = 0; i < A.Length; i++)
            {
                res *= 26;
                res += (A[i] - 'A' + 1);
            }

            return res;
        }
    }
}
