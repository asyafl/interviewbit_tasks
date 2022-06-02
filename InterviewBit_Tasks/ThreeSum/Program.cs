/// <summary>
/// Given an array S of n integers, find three integers in S such that the sum is closest to a given number, target.
//Return the sum of the three integers.
//Assume that there will only be one solution
//Example:
//given array S = {-1 2 1 -4},
//and target = 1.
//The sum that is closest to the target is 2. (-1 + 2 + 1 = 2)
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        //var A = new List<int>() { -5, 1, 4, -7, 10, -7, 0, 7, 3, 0, -2, -5, -3, -6, 4, -7, -8, 0, 4, 9, 4, 1, -8, -6, -6, 0, -9, 5, 3, -9, -5, -9, 6, 3, 8, -10, 1, -2, 2, 1, -9, 2, -3, 9, 9, -10, 0, -9, -2, 7, 0, -4, -3, 1, 6, -3 };
        //var B = -1;

        // var A = new List<long>() { 2147483647, -2147483648, -2147483648, 0, 1 };
        // var B = 0;

        var A = new List<long>() { -10, -10, -10 };
        var B = -5;

        Console.WriteLine(Solution.ThreeSumClosest(A, B));

    }

    public class Solution
    {
        public static long ThreeSumClosest(List<long> A, int B)
        {
            A.Sort();

            long closestSum = int.MaxValue;

            for (var i = 0; i < A.Count; i++)
            {
                int ptr1 = i + 1;
                int ptr2 = A.Count - 1;

                while (ptr1 < ptr2)
                {
                    long sum = A[i] + A[ptr1] + A[ptr2];

                    if (Math.Abs(B - sum) < Math.Abs(B - closestSum))
                    {
                        closestSum = sum;
                    }

                    if (sum > B)
                    {
                        ptr2--;
                    }

                    else
                    {
                        ptr1++;
                    }
                }
            }

            return closestSum;
        }
    }
}