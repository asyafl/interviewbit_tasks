class Program
{
    static void Main(string[] args)
    {
        var list1 = new List<int>() { 1, 2, 4 , 10, 15};
        var list2 = new List<int>() { 3, 6 , 8};

        var mergedArray = Solution.MergeSortedArrays(list1, list2);

        foreach (var m in mergedArray)
        {
            Console.Write($"{m} ");
        }
    }

    public class Solution
    {
        public static List<int> MergeSortedArrays(List<int> list1, List<int> list2)
        {
            var result = new List<int>();

            var len1 = list1.Count - 1;
            var len2 = list2.Count - 1;
            var index1 = 0;
            var index2 = 0;

            while (index1 <= len1 && index2 <= len2)
            {
                if(list1[index1] < list2[index2])
                {
                    result.Add(list1[index1]);
                    index1++;
                }
                else
                {
                    result.Add(list2[index2]);
                    index2++;
                }
            }

            if(index1 <= len1)
            {
                for(int i = index1; i <= len1; i++)
                {
                    result.Add(list1[i]);
                }
            }
            else if (index2 <= len2)
            {
                for (int i = index2; i <= len2; i++)
                {
                    result.Add(list2[i]);
                }
            }

            return result;

        }

    }
}