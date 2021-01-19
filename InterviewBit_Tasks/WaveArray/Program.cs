using System;
using System.Collections.Generic;
using System.Linq;

namespace WaveArray
{

    /// <summary>
    /// Given an array of integers, sort the array into a wave like array and return it,
    /// In other words, arrange the elements into a sequence such that a1 >= a2 <= a3 >= a4 <= a5.....
    /// Example
    /// Given [1, 2, 3, 4]
    /// One possible answer : [2, 1, 4, 3]
    /// Another possible answer : [4, 1, 3, 2]
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Solution s = new Solution();
            var arr = new int[] { 5, 1, 3, 2, 4 };

            List<int> A = arr.ToList();

            var AA = s.Wave(A);

            foreach(var a in AA)
            {
                Console.WriteLine(a);
            }
           
        }

    }

    public class Solution
    {
        public List<int> Wave(List<int> A)
        {
            A.Sort();

            for(int i = 0; i < A.Count; i+=2)
            {
                if ((i + 1) < A.Count)
                {
                    int tmp = A[i];
                    A[i] = A[i + 1];
                    A[i + 1] = tmp;
                }
            
            }

            return A;
        }
    }
}
