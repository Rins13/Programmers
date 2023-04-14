using System;

namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] inputs = System.Console.ReadLine().Split();
			int[] nums = new int[3];
			for(int  i =0; i<inputs.Length;i++)
				nums [i] = int.Parse(inputs[i]);

			Array.Sort(nums);

			int addAB = nums[0] + nums[1];

			if (addAB > nums[2])
				Console.WriteLine(addAB + nums[2]);
			else
				Console.WriteLine(addAB * 2 -1);

		}
	}
}
