/// <summary>
/// Given an array, rotate the array to the right by k steps, where k is non-negative.
/// Could you do it in-place with O(1) extra space?
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        var nums = new int[] { 1, 2, 3, 4, 5, 6, 7 }; // [5,6,7,1,2,3,4]
        var k = 3;

       // var nums = new int[] { -1 }; // [5,6,7,1,2,3,4]
       // var k = 2;

        //var nums = new int[] { 1, 2, 3};
        // var k = 3;

        // var nums = new int[] {1, 2, 3, 4, 5, 6};
        // var k = 1;

        //  var nums = new int[] { 1, 2 };
        // var k = 2;

        Solution.Rotate(nums, k);

        foreach (var n in nums)
        {
            Console.Write($"{n} ");
        }

    }

    public class Solution
    {
        public static void Rotate(int[] nums, int k)
        {
            var len = nums.Length;

            k %= len;

            ReverseArray(nums, 0, len - 1);
            ReverseArray(nums, 0, k - 1);
            ReverseArray(nums, k, len - 1);
        }


        private static void ReverseArray(int[] nums, int start, int end)
        {

            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}
