using System;

namespace ImplementStrStr
{
    /// <summary>
    /// strstr - locate a substring ( needle ) in a string ( haystack ). 
    /// Try not to use standard library string functions for this question.
    /// Returns the index of the first occurrence of needle in haystack, or -1 
    /// if needle is not part of haystack.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.StrStr("bbbbbbbbab!", "baba"));
        }
    }
    public class Solution
    {
        public int StrStr(string A, string B)
        {
            var result = -1;
            var aLen = A.Length;
            if (string.IsNullOrEmpty(B) || string.IsNullOrEmpty(A))
            {
                return result;
            }
            else
            {
                for (int i = 0; i < aLen; i++)
                {
                    if (A[i] == B[0])
                    {
                        var bLen = B.Length;
                        if (i + bLen > aLen)
                        {
                            break;
                        }
                        else
                        {
                            var subStr = A.Substring(i, B.Length);
                            if (subStr.Equals(B))
                            {
                                return i;
                            }
                        }
                    }
                }
            }
            return result;
        }
    }
}
