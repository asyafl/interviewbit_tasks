namespace Diffk
{
    /// <summary>
    /// Given an array ‘A’ of sorted integers and another non negative integer k, 
    /// find if there exists 2 indices i and j such that A[i] - A[j] = k, i != j.
    /// Example: Input : A : [1 3 5] k : 4
    /// Output : YES
    /// as 5 - 1 = 4
    /// Return 0 / 1 ( 0 for false, 1 for true ) for this problem
    /// Try doing this in less than linear space complexity.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var list = new List<int>() { 1, 3, 5 };
            Console.WriteLine(s.DiffPossible(list,4));
        }
    }

    public class Solution
    {
        public int DiffPossible(List<int> A, int B)
        {
            HashSet<int> diff = new();
            int length = A.Count;

            for (int i = 0; i < length; i++)
            {
                if (diff.Contains(A[i]))
                {
                    return 1;
                }

                diff.Add(A[i] - B);
                diff.Add(A[i] + B);
            }

            return 0;
        }
    }
}


