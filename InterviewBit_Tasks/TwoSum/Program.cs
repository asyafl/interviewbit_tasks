/// <summary>
/// Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
/// You may assume that each input would have exactly one solution, and you may not use the same element twice.
/// Only one valid answer exists
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        //var nums = new int[] { 2, 7, 11, 15 };
        //var target = 9;

        //var nums = new int[] {2, 5, 5, 11};
        //var target = 10;

        var nums = new int[] {-1, -2, -3, -4, -5}; //[2,4]
         var target = -8;


        // var nums = new int[] { 5, 75, 25 }; //[1,2]
        // var target = 100;

       // var nums = new int[] { -10, 7, 19, 15 }; //[0,2]
       // var target = 9;

        var twoSum = Solution.TwoSum(nums, target);

        foreach (var m in twoSum)
        {
            Console.Write($"{m} ");
        }
    }

    public class Solution
    {
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] result = new int[2];

            int i = 0;
            int j = nums.Length - 1;
            int firtNum = 0;
            int secondNum = 0;

            if(j == 1)
            {
                return nums;
            }

            var sortedNums = nums.OrderBy(x => x).ToArray();

            while (i < j)
            {
                var tmp = sortedNums[i] + sortedNums[j];

                if (tmp < target)
                {
                    i++;
                }
                else if(tmp > target)
                {
                    j--;
                }
                else
                {
                    firtNum = sortedNums[i];
                    secondNum = sortedNums[j];
                    break;
                }
            }

            bool isAddedFirst = false;

            for (int n = 0; n < nums.Length; n++)
            {
                if(nums[n] == firtNum)
                {
                    if (!isAddedFirst)
                    {
                        isAddedFirst = true;
                        result[0] = n;
                    }
                    else if (isAddedFirst)
                    {
                        result[1] = n;
                        break;
                    }
                }
                else if(nums[n] == secondNum)
                {
                    if (!isAddedFirst)
                    {
                        isAddedFirst = true;
                        result[0] = n;
                    }
                    else if (isAddedFirst)
                    {
                        result[1] = n;
                        break;
                    }

                }
            }

            return result;
        }
    }
}
