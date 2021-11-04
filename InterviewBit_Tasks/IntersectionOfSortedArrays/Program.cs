namespace IntersectionOfSortedArrays
{
    /// <summary>
    /// Find the intersection of two sorted arrays. OR in other words, 
    /// Given 2 sorted arrays, find all the elements which occur in both the arrays.
    /// Example: Input: A: [1 2 3 3 4 5 6] B: [3 3 5] ; Output: [3 3 5]
    /// Example: Input: A: [1 2 3 3 4 5 6] B: [3 3 5] ; Output: [3 5]
    /// NOTE : For the purpose of this problem ( as also conveyed by the sample case ), 
    /// assume that elements that appear more than once in both arrays should be included multiple times in the final output.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var listA = new List<int>() { 1, 2, 3, 3, 4, 5, 6 };
            var listB = new List<int>() { 3, 3, 5 };

            Solution.ListOutput(Solution.Intersect(listA, listB));
        }

        public class Solution
        {
            public static List<int> Intersect(List<int> A, List<int> B)
            {
                var countA = A.Count;
                var countB = B.Count;
                var asw = new List<int>();
                var k = 0;

                for (int i = 0; i < countB; i++)
                {
                    for (int j = k; j < countA; j++)
                    {
                        if (A[j] > B[i])
                        {
                            break;
                        }
                        else if (B[i] == A[j])
                        {
                            asw.Add(B[i]);
                            k = j + 1;
                            break;
                        }
                    }
                }
                return asw;
            }

            public static void ListOutput(List<int> list)
            {
                var i = 0;
                foreach (var l in list)
                {
                    if (i != 0)
                    {
                        Console.Write(", ");
                    }
                    Console.Write(l);
                    i++;
                }
            }
        }

    }


}