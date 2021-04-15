using System;
using System.Text;

namespace BinaryRepresentation
{
    /// <summary>
    /// Given a number N >= 0, find its representation in binary.
    /// Example:
    /// if N = 6,
    /// binary form = 110
    /// Problem Approach:
    /// Complete code in the hint.
    /// </summary>
    /// 
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.FindDigitsInBinary(0));
        }
    }
    public class Solution
    {
        public string FindDigitsInBinary(int A)
        {
            var digits = new StringBuilder();
            int tmp;

            if (A == 0)
            {
                return "0";
            }

            while (A > 0)
            {
                tmp = A % 2;
                digits.Append(tmp);
                A /= 2;
            }

            var arr = digits.ToString()
                 .ToCharArray();

            Array.Reverse(arr);

            var res = new string(arr);
            return res;
        }
    }
}
