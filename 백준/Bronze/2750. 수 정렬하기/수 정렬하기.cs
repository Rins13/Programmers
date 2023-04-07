using System;

namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(System.Console.ReadLine());
			int[] arr = new int[count];
			for(int i = 0; i< count;i++)
				arr[i] = int.Parse(System.Console.ReadLine());

			Array.Sort(arr);

			foreach(int num in arr)
				System.Console.WriteLine(num);
		}
	}
}