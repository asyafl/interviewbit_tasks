namespace MinXorValue
{
    /// <summary>
    /// Given an integer array A of N integers, find the pair of integers in the array which have minimum XOR value.
    /// Report the minimum XOR value.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            var list = new List<int>() { 15, 5, 1, 10, 2 };

            Console.WriteLine(s.FindMinXor(list));
        }

        public class Solution
        {
            public int FindMinXor(List<int> A)
            {
                var minVal = int.MaxValue;
                var count = A.Count - 1;

                A.Sort();

                for (int i = 0; i < count; i++)
                {
                    int temp = A[i] ^ A[i + 1];
                    if (temp < minVal)
                    {
                        minVal = temp;
                    }

                }

                return minVal;
            }
        }
    }
}
