namespace PairWithGivenDifference
{
    /// <summary>
    /// Given an one-dimensional unsorted array A containing N integers.
    /// You are also given an integer B, find if there exists a pair of elements in the array whose difference is B.
    /// Return 1 if any such pair exists else return 0.
    ///Input:  A : [ 20, 500, 1000, 200 ] B : 0  Output : 1
    ///Input:  A : [ 5, 10, 3, 2, 50, 80 ] B : 78  Output : 1
    ///Input:  A : [ -10, 20 ] B : 30  Output : 1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var A = new List<int>() { 637, -466, 556, 993, -824, 705, -38, -452, 881, -700, -587, -359, 855, -145, 142, 462, 611, -123, -576, -322, 752, -557, -704, -327, -960, 313, -125, -928, -182, -390, 17, -68, -888, -305, 169 };
            var B = 570;

            Console.WriteLine(Solution.Solve(A, B));
        }

        public class Solution
        {
            public static int Solve(List<int> A, int B)
            {
                var ans = 0;

                var dic = new Dictionary<int, int>();

                for (int i = 0; i < A.Count; i++)
                {
                    if (!dic.ContainsKey(A[i]))
                    {
                        dic.Add(A[i], 1);
                    }
                    else
                    {
                        dic[A[i]]++;
                    }
                }

                foreach (var a in A)
                {
                    var diff = a - B;

                    if (B !=0 && dic.ContainsKey(diff))
                    {
                        ans = 1;
                        break;
                    }
                    else if(B == 0 && dic[a] > 1)
                    {
                        ans = 1;
                        break;
                    }

                }

                return ans;
            }
        }
    }
}