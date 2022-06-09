class Program
{
    static void Main(string[] args)
    {
        var A = new List<int>() { 4, 2, 1, 4 };
        var B = new List<int>() { 7 , 8, 1};

        Console.WriteLine(Solution.ContainsItems(A, B));
        Console.WriteLine(Solution.ContainsItemsWithLinq(A, B));
    }

    public class Solution
    {
        //O(a + b) -Time 
        //O(a) - space
        public static bool ContainsItems(List<int> A, List<int> B)
        {
            if(A.Count == 0 || B.Count == 0)
            {
                return false;
            }
            if (A.Count == 1)
            {
                return ContainsItem(B, A.First());
            }
            else if (B.Count == 1)
            {
                return ContainsItem(A, B.First());
            }
            else
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
            }
            return false;
        }

        public static bool ContainsItemsWithLinq(List<int> A, List<int> B)
        {
            return A.Any(a => B.Contains(a));
        }

        private static bool ContainsItem(List<int> array, int item)
        {
            foreach(var a in array)
            {
                if(a == item)
                {
                    return true;
                }
            }

            return false;
        }
    }
}

