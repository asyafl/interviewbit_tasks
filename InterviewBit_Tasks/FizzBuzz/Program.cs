using System;
using System.Collections.Generic;

namespace FizzBuzz
{
    class Program
    {
        /// <summary>
        /// Given a positive integer A, return an array of strings with all the integers from 1 to N.
        /// But for multiples of 3 the array should have “Fizz” instead of the number.
        /// For the multiples of 5, the array should have “Buzz” instead of the number.
        /// For numbers which are multiple of 3 and 5 both, the array should have “FizzBuzz” instead of the number.
        /// Look at the example for more details.
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            var s = new Solution();
            var r = s.fizzBuzz(5);
            
            foreach(var t in r)
            {
                Console.WriteLine(t);
            }

       
            Console.WriteLine("Hello World!");
        }
    }

    public class Solution
    {
        public List<string> fizzBuzz(int A)
        {
            var res = new List<string>();

            for(int i = 1; i<= A; i++)
            {
                if(i % 15 == 0)
                {
                    res.Add("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    res.Add("Buzz");
                }
                else if (i % 3 == 0)
                {
                    res.Add("Fizz");
                }
                else
                {
                    res.Add(i.ToString());
                }
            }
            return res;
        }
    }
}
