using System;
using System.Collections.Generic;
using System.Linq;

namespace AllFactors
{
    /// <summary>
    /// Given a number N, find all factors of N.
    /// N = 6 
    /// factors = {1, 2, 3, 6}
    /// O(sqrt(n))
/// </summary>
class Program
    {
        static void Main(string[] args)
        {
            var f = new Factors();
            var res = f.AllFactors(82944);

            foreach(var r in res)
            {
                Console.WriteLine(r);
            }
            
        }
    }

    public class Factors
    {
        public List<int> AllFactors(int A)
        {
            var result = new List<int>();

            if(A == 1)
            {
                result.Add(1);
            }
            else
            {
                int newA = (int)Math.Sqrt(A);

                for (int i = 1; i <= newA; i++)
                {
                    if (A % i == 0)
                    {
                        result.Add(i);

                        var tmp = A / i;
                        if(tmp  != newA)
                        {
                            result.Add(A / i);
                        }
                        
                    }
                }
            }
            
            return result.OrderBy(x => x).ToList();
        }
    }
}
