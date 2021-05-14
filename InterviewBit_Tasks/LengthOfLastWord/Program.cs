using System;

namespace LengthOfLastWord
{
    /// <summary>
    /// Given a string s consists of upper/lower-case alphabets and empty space characters ' ', 
    /// return the length of last word in the string.
    /// If the last word does not exist, return 0.
    /// Note: A word is defined as a character sequence consists of non-space characters only.
    /// Example:
    /// Given s = "Hello World", return 5 as length("World") = 5.
    /// Please make sure you try to solve this problem without using library functions.
    /// Make sure you only traverse the string once.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.LengthOfLastWord("Hello World  "));
        }
    }
    public class Solution
    {
        public int LengthOfLastWord(string A)
        {
            var count = 0;

            for (int i = A.Length - 1; i >= 0; i--)
            {
                var comparison = A[i].CompareTo((char)32);

                if (comparison != 0)
                {
                    count++;
                }
                else if (comparison == 0 && count == 0)
                {
                    continue;
                }
                else
                {
                    return count;
                }
            }

            return count;
        }
    }
}
