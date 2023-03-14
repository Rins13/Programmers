using System;

namespace ConsoleApp2
{
	public class Program
	{
		static void Main(string[] args)
		{
			string str_y = System.Console.ReadLine();
			int y = Convert.ToInt32(str_y);

			int gap = 2541 - 1998;

			System.Console.WriteLine(y-gap);
		}
	}
}
