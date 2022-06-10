/// <summary>
/// Given an integer array nums, move all 0's to the end of it 
/// while maintaining the relative order of the non-zero elements.
/// Note that you must do this in-place without making a copy of the array.
/// O(n)
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        var nums = new int[] { 0, 1, 0, 3, 12 }; // [1, 3, 12, 0, 0] 
        Solution.MoveZeroes(nums);

        foreach (var n in nums)
        {
            Console.Write($"{n} ");
        }

    }

    public class Solution
    {
        public static void MoveZeroes(int[] nums)
        {
            int length = nums.Length;
            int count = 0;

            for(int i = 0; i < length; i++)
            {
                if (nums[i] == 0)
                {
                    count++;
                }
                else
                {
                    nums[i - count] = nums[i];
                }
            }

            var startPos = length - count;

            for (int i = startPos; i < length; i++)
            {
                nums[i] = 0;
            }
        }
    }
}
