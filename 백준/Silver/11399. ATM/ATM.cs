using System;

namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(System.Console.ReadLine());
			string[] inputs = System.Console.ReadLine().Split();
			int[] nums = new int[count];
			
			for (int i = 0; i < count; i++)
				nums[i] = int.Parse(inputs[i]);

			Array.Sort(nums);

			int time = 0, prevTime = 0;
			for (int i = 0; i < count; i++)
			{
				prevTime = prevTime + nums[i];
				time += prevTime;
			}

			Console.WriteLine(time);
		}
	}
}
