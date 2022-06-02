class Program
{
    static void Main(string[] args)
    {
        var A = new List<int>() { 4, 2, 1, 4 };
        var B = new List<int>() { 7 , 8};

        Console.WriteLine(Solution.ContainsItems(A, B));

    }

    public class Solution
    {
        public static bool ContainsItems(List<int> A, List<int> B)
        {
            var set = new HashSet<int>();
            foreach (var item in A)
            {
                set.Add(item);
            }

            foreach (var item in B)
            {
                if (set.Contains(item))
                {
                    return true;
                }
            }
            return false;
        }
    }
}

