using System.Text.RegularExpressions;

/// <summary>
/// Have the function LongestWord(sen) 
/// take the sen parameter being passed 
/// and return the longest word in the string. 
/// If there are two or more words that are the same length, 
/// return the first word from the string with that length. 
/// Ignore punctuation and assume sen will not be empty.
/// Words may also contain numbers, for example "Hello world123 567"
/// Input: "I love dogs"
/// Output: love
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(Solution.LongestWord("fun&!! time"));
    }
    public static class Solution
    {
        public static string LongestWord(string sen)
        {
           var newSen =  Regex.Matches(sen, "[A-Za-z]+").ToArray();

            string result = String.Empty;

            int maxWorldSize = int.MinValue;


            foreach (var s in newSen)
            {
                int tmp = s.Length;

                if (tmp > maxWorldSize)
                {
                    maxWorldSize = tmp;
                    result = s.ToString();
                }
            }

            return result;
        }
    }
}
