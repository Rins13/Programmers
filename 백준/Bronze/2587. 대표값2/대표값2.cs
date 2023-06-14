using System;
using System.Linq;

namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			int[] arr = new int[5];

			for(int  i =0; i< arr.Length;i++)
				arr[i]= int.Parse(System.Console.ReadLine());

			Array.Sort(arr);

			Console.WriteLine(arr.Sum() / 5);
			Console.WriteLine(arr[2]);
		}
	}
}