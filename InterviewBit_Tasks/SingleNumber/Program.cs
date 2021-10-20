using System;
using System.Collections.Generic;

namespace SingleNumber
{
    /// <summary>
    /// Problem Description
    /// Given an array of integers A, every element appears twice except for one.Find that single one.
    /// NOTE: Your algorithm should have a linear runtime complexity. Could you implement it without using extra memory?
    /// Problem Constraints: 2 <= |A| <= 2000000 ; 0 <= A[i] <= INTMAX
    /// Input Format: First and only argument of input contains an integer array A.
    /// Output Format: Return a single integer denoting the single element.
    /// Examples
    /// Input 1:  A = [1, 2, 2, 3, 1] ; Output 1: 3
    /// Input 2: A = [1, 2, 2] ; Output 2: 1
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var s = new Solution();
            List<int> A = new List<int>() { 1, 2, 2 };

            Console.WriteLine("First solution: " + s.SingleNumber(A));
            Console.WriteLine("Second solution: " + s.SingleNumberXORAproach(A));
        }
    }

    public class Solution
    {
        public int SingleNumberXORAproach(List<int> A)
        {
            var count = A.Count;
            var result = A[0];

            if(count == 0)
            {
                return count;
            }
            else
            {
                for(int i = 1; i< count; i++)
                {
                    result ^= A[i];
                }
            }

            return result;
        }

        public int SingleNumber(List<int> A)
        {
            var dic = new Dictionary<int, int>();

            foreach(var a in A)
            {
                if (dic.ContainsKey(a))
                {
                    dic[a]++;
                }
                else
                {
                    dic.Add(a, 1) ;
                }
            }

            var result = 0;

            foreach(var d in dic)
            {
                if(d.Value == 1)
                {
                    result = d.Key;
                    break;
                }
            }

            return result;
        }
    }
}
