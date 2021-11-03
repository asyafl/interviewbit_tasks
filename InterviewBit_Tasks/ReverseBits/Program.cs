namespace ReverseBit
{
    /// <summary>
    /// Problem Description
    /// Reverse the bits of an 32 bit unsigned integer A.
    /// Input 1 : 3 ; Output 1:  3221225472
    /// Input 2 : 0 ; Output 2:  0
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            Console.WriteLine(s.Solve(3));
        }

        public class Solution
        {
            public long Solve(long A)
            {
                long b = 0;
                for (int i = 0; i < 32; i++)
                {
                    b |= (A & 1);
                    b <<= 1;
                    A >>= 1;
                }
                b >>= 1;

                return b;
            }
        }
    }
}
