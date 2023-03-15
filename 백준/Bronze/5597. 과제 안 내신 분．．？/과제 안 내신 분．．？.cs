using System;

namespace ConsoleApp2
{
	public class Program
	{
		static void Main(string[] args)
		{
			bool[] nums = new bool[30];
			for (int i = 0; i < 28; i++)
			{
				int num = int.Parse(System.Console.ReadLine()) - 1;
				nums[num] = true;
			}

			System.Console.WriteLine(Array.IndexOf(nums, false) + 1);
			System.Console.WriteLine(Array.LastIndexOf(nums, false) + 1);
		}

	}
}