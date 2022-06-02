class Program
{
    static void Main(string[] args)
    {
        var A = new List<int>() { 4, 2, 1, 4 };
        int sum = 5;

        Console.WriteLine(Solution.HasPairsWithSumForUnsortedArray(A, sum));

        Console.WriteLine("____");
        var B = new List<int>() { 1, 2, 4, 4 };
        int sum2 = 5;
        Console.WriteLine(Solution.HasPairsWithSumForSortedArray(B, sum2));
    }

    public class Solution
    {
        public static bool HasPairsWithSumForUnsortedArray(List<int> A, int sum)
        {
            var set = new HashSet<int>();

            foreach (var a in A)
            {
                if (set.Contains(a))
                {
                    return true;
                }
                set.Add(sum - a);
            }

            return false;
        }

        public static bool HasPairsWithSumForSortedArray(List<int> A, int sum)
        {
            int start = 0;
            int end = A.Count - 1;

            while (end > start)
            {
                if (A[start] + A[end] == sum)
                {
                    return true;
                }

                else if (A[start] + A[end] < sum)
                {
                    start++;
                }
                else
                {
                    end--;
                }
            }

            return false;
        }
    }
}
