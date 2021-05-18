using System;
using System.Collections.Generic;
using System.Linq;

namespace LongestCommonPrefix
{
    /// <summary>
    /// Given the array of strings A,
    /// you need to find the longest string S which is the prefix of ALL the strings in the array.
    /// Longest common prefix for a pair of strings S1 and S2 is the longest string S which is the prefix of both S1 and S2.
    /// For Example, longest common prefix of "abcdefgh" and "abcefgh" is "abc".
    /// Input 1: A = ["abcdefgh", "aefghijk", "abcefgh"] Output 1: "a"  Explanation 1:Longest common prefix of all the strings is "a".
    /// Input 2: A = ["abab", "ab", "abcd"] Output 1: "ab"
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var str = new string[] { "abab", "ab", "abcd" };
            Console.WriteLine(s.LongestCommonPrefix(str.ToList()));
        }
    }
    public class Solution
    {
        public string LongestCommonPrefix(List<string> A)
        {
            var result = "";

            var ordereed = A.OrderBy(x => x.Length).ToList();
            var min = ordereed[0];

            for (int i = 0; i < min.Length; i++)
            {
                foreach (var a in A)
                {
                    if (!a[i].Equals(min[i]))
                    {
                        return result;
                    }
                }
                result += min[i];
            }


            return result;
        }
    }
}
