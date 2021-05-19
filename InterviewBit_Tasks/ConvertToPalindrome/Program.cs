using System;

namespace ConvertToPalindrome
{
    /// <summary>
    /// Given a string A consisting only of lowercase characters,
    /// we need to check whether it is possible to make this string
    /// a palindrome after removing exactly one character from this.
    /// If it is possible then return 1 else return 0.
    /// Problem Constraints: 3 <= |A| <= 105
    /// A[i] is always a lowercase character.
    /// Input Format: First and only argument is an string A.
    /// Output Format: Return 1 if it is possible to convert A to palindrome by removing exactly one character else return 0.
    /// Example Input 1: "abcba"; Output : 1; Explanation : We can remove character ‘c’ to make string palindrome
    /// Example Input 2: "abecbea"; Output : 0; Explanation : It is not possible to make this string palindrome just by removing one character 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.Solve("phmjjmap"));
        }
    }
    public class Solution
    {
        public int Solve(string A)
        {

            var len = A.Length;
            var halfLen = len / 2;
            var count = 0;
            for (int i = 0, j = len - 1; i <= halfLen & j >= 0; i++, j--)
            {
                if (!A[i].Equals(A[j]))
                {
                    if (count > 0)
                    {
                        return 0;
                    }
                    else
                    {
                        count++;
                        if (A[i + 1].Equals(A[j]))
                        {
                            i++;
                            continue;
                        }
                        else if (A[i].Equals(A[j - 1]))
                        {
                            j--;
                            continue;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }

            return 1;
        }
    }
}
