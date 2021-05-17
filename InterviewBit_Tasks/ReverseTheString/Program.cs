using System;
using System.Collections.Generic;

namespace ReverseTheString
{
    /// <summary>
    /// Given a string A.
    /// Return the string A after reversing the string word by word.
    /// NOTE:
    /// A sequence of non-space characters constitutes a word.
    /// Your reversed string should not contain leading or trailing spaces, even if it is present in the input string.
    /// If there are multiple spaces between words, reduce them to a single space in the reversed string.
    /// Example
    /// Input 1: A = "the sky is blue" Output 1: "blue is sky the"
    /// Input 2:  A = "this is ib" Output 2: "ib is this"
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.Solve("       fwbpudnbrozzifml osdt ulc jsx kxorifrhubk ouhsuhf sswz qfho dqmy sn myq igjgip iwfcqq                 "));
        }
    }
    public class Solution
    {
        public string Solve(string A)
        {
            var result = "";

            var list = new List<string>();
            var tmp = "";
            for (int i = 0; i < A.Length; i++)
            {
                if (!char.IsWhiteSpace(A[i]))
                {
                    tmp += A[i];
                    if (i == (A.Length - 1))
                    {
                        list.Add(tmp);
                    }
                }
                else if (string.IsNullOrEmpty(tmp))
                {
                    continue;
                }
                else
                {
                    list.Add(tmp);
                    tmp = "";
                }
            }

            for (int i = list.Count - 1; i >= 0; i--)
            {
                if (i != 0)
                {
                    var t = list[i] + " ";
                    result += t;
                }
                else
                {
                    result += list[i];
                }
            }
            return result;
        }
    }
}
