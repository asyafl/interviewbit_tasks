using System;

namespace TrailingZeroes
{
	/// <summary>
	/// Problem Description : Given an integer A, count and return the number of trailing zeroes.
	/// Problem Constraints : 1 <= A <= 109
	/// Input Format : First and only argument is an integer A.
	/// Output Format :Return an integer denoting the count of trailing zeroes.
	/// 
	/// Example Input: Input 1: A = 18 Input 2: A = 8
	/// Example Output: Output 1: 1 Output 2: 3
	/// Explanation 1: 18 in binary is represented as: 10010, there is 1 trailing zero.
	/// </summary>
	class Program
	{
		static void Main(string[] args)
		{
			var s = new SolveClass();
			Console.WriteLine(s.Solve(8));
		}
	}

	public class SolveClass
	{
		public int Solve(int A)
		{
			var s = ToBinary(A);
			var count = s.Length - 1;
			int result  = 0;

			for (int i = 0; i < count; i++) 
			{
				if (s[i].CompareTo('1') == 0)
				{
					break;
				}
				else 
				{
					result++;
				}
			}

			return result;
		}

		private string ToBinary(int a)
		{
			var s = "";

			while (a > 0)
			{
				s += ((a % 2) == 0 ? "0" : "1");
				a /= 2;
			}

			return s;
		}
	}
}
