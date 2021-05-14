using System;
using System.Text.RegularExpressions;

namespace PalindromeString
{
    /// <summary>
    /// Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.
    /// Example:
    /// "A man, a plan, a canal: Panama" is a palindrome.
    /// "race a car" is not a palindrome.
    /// Return 0 / 1 ( 0 for false, 1 for true ) for this problem
    /// </summary>

    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.IsPalindrome("A man, a plan, a canal: Panama\""));
        }
    }
    public class Solution
    {
        public int IsPalindrome(string A)
        {
            var newText = Regex.Replace(A, "[-.?!)(,: \"]", string.Empty).ToUpper();

            var len = newText.Length;
            var halfLen = len / 2;

            for (int i = 0, j = len - 1; i < halfLen & j >= 0; i++, j--)
            {
                if (newText[i].CompareTo(newText[j]) != 0)
                {
                    return 0;
                }
            }

            return 1;
        }
    }
}

