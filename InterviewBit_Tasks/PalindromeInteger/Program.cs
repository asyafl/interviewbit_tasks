using System;

namespace PalindromeInteger
{
    /// <summary>
    /// Determine whether an integer is a palindrome. Do this without extra space.
    /// A palindrome integer is an integer x for which reverse(x) = x where reverse(x) is x with its digit reversed.
    /// Negative numbers are not palindromic.
    /// Example :
    /// Input : 12121 Output : True
    /// Input : 123  Output : False
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.isPalindrome(123));
        }


    }
    public class Solution
    {
        public int isPalindrome(int A)
        {
            if (A < 0)
            {
                return 0;
            }

            var c = A.ToString();
            var count = (int)Math.Floor(c.Length / 2.0);

            for (int i = 0, j = c.Length - 1; i < count && j >= count; i++, j--)
            {
                if (c[i] != c[j])
                {
                    return 0;
                }

            }
            return 1;
        }
    }
}
