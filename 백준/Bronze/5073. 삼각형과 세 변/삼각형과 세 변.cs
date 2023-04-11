using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			while(true)
			{
				string input = System.Console.ReadLine();
				if (input.Equals("0 0 0"))
					return;

				string[] inputs = input.Split();

				List<int> angles = new List<int>();
				for (int i = 0; i < 3; i++)
				{
					int angle = int.Parse(inputs[i]);

					angles.Add(angle);
				}

				angles.Sort();


				if (angles[0] + angles[1] <= angles[2])
				{
					Console.WriteLine("Invalid");
					continue;
				}

				int count = angles.Distinct().Count();

				if (count == 1)
					Console.WriteLine("Equilateral");
				else if (count == 2)
					Console.WriteLine("Isosceles");
				else
					Console.WriteLine("Scalene");
			}
		}
	}
}