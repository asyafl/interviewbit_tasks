using System;

namespace CountAndSay
{
    class Program
    {
        static void Main(string[] args)
        {
             var s = new Solution();
            Console.WriteLine(s.CountAndSay(2));
        }
    }
    public class Solution
    {
        public string CountAndSay(int A)
        {
            if(A == 1)
            {
                return "1";
            }
            if(A == 2)
            {
                return "11";
            }

            var str = "11";
            for(int i = 3; i<= A; i++)
            {
                str += '$';
                int len = str.Length;

                int cnt = 1; 
                string tmp = ""; 
                char[] arr = str.ToCharArray();

                
                for (int j = 1; j < len; j++)
                {
                    
                    if (arr[j] != arr[j - 1])
                    {
                        
                        tmp += cnt + 0;

                        tmp += arr[j - 1];

                        cnt = 1;
                    }

                    else cnt++;
                }
                str = tmp;
            }

            return str;
        
        }
    }
}
