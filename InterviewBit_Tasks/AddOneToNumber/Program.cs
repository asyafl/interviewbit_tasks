using System;
using System.Collections.Generic;
using System.Linq;

namespace AddOneToNumber
{
    /// <summary>
    /// Given a non-negative number represented as an array of digits,
    /// add 1 to the number(increment the number represented by the digits ).
    /// The digits are stored such that the most significant digit is at the head of the list.
    /// Note! the intput can have 0’s before the most significant digit, but output no
    /// 
    /// Example:
    /// If the vector has[1, 2, 3] 
    /// the returned vector should be[1, 2, 4]
    /// as 123 + 1 = 124.
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();

            var arr = new int[] { 0, 8, 9, 9, 9, 9, 9, 9, 9, 9,9 };

            List<int> A = arr.ToList();

            foreach (var e in s.PlusOne(A))
            {
                Console.WriteLine(e);
            }

        }
    }
    public class Solution
    {
        public List<int> PlusOne(List<int> A)
        {
            if (A.Count == 0)
            {
                return new List<int>() { 1 };
            }

            A.Reverse();
            var notAdded = true;
            var pos = 0;
            do
            {
                if (pos == A.Count)
                {
                    A.Add(1);
                    notAdded = false;
                }
                else
                {
                    if (A[pos] < 9)
                    {
                        A[pos]++;
                        notAdded = false;
                    }
                    else
                    {
                        A[pos] = 0;
                    }
                }

                pos++;
            }
            while (notAdded);

            while (A[^1] == 0)
            {
                A.RemoveAt(A.Count - 1);
            }

            A.Reverse();

            return A;
        }
    }
}
