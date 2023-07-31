using System;
using System.Collections.Generic;

namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			int input = Convert.ToInt32(System.Console.ReadLine());

			string output = "";
			int div = 2;

			if(input == 1)
				return;

			while(true)
			{
				if (input % div == 0)
				{
					output += $"{div}\n";
					input /= div;

					if (input <= 1)
						break;

				}
				else
					div++;
			}

			System.Console.Write(output);
		}
	}
}
