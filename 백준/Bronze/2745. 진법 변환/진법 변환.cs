using System;
using System.Collections.Generic;

namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] inputs = System.Console.ReadLine().Split();

			string n = inputs[0];
			int b = int.Parse(inputs[1]);

			Dictionary<char, int> nums = new Dictionary<char, int>();

			for(int i = 0; i< b; i++)
			{
				char key = (char)(i + '0');

				if(i > 9)
				{
					key = (char)('@' + (i-9));
				}
				nums.Add(key, i);
			}

			double answer = 0;
			for(int i = 0; i<n.Length;i++)
			{
				char ch = n[n.Length - 1 - i];

				answer += nums[ch]* (int)Math.Pow(b, i);
			}
			
			System.Console.WriteLine(answer);
		}
	}
}