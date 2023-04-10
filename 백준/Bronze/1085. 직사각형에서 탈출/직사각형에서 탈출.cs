using System;

namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] inputs = System.Console.ReadLine().Split();
			int x = int.Parse(inputs[0]);
			int y = int.Parse(inputs[1]);
			int w = int.Parse(inputs[2]);
			int h = int.Parse(inputs[3]);

			int[] length = new int[] { x, w - x, y, h - y };
			Array.Sort(length);
			System.Console.WriteLine(length[0]);
		}
	}
}