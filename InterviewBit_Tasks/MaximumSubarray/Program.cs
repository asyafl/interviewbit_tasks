///Given an integer array nums, find the contiguous subarray (containing at least one number) 
///which has the largest sum and return its sum.
///A subarray is a contiguous part of an array.
class Program
{
    static void Main(string[] args)
    {
        // var arr = new int[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }; //6
        var arr = new int[] { 5, 4, -1, 7, 8 }; //23

        Console.Write(Solution.MaxSubArray(arr));
    }

    public class Solution
    {
        public static int MaxSubArray(int[] nums)
        {
            int sum = 0;
            int max = int.MinValue;

            foreach (var n in nums)
            {
                sum += n;
                if (sum < n)
                {
                    sum = n;
                }
                if (sum > max)
                {
                    max = sum;
                }
            }

            return max;
        }
    }
}
