using System;
using System.Collections.Generic;

namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			int sum = 0;
			List<int> angles = new List<int>();
			for (int  i =0; i< 3;i++)
			{
				int angle = int.Parse(System.Console.ReadLine());

				sum += angle;

				if (!angles.Contains(angle))
					angles.Add(angle);
			}

			if (sum != 180)
				Console.WriteLine("Error");
			else if(angles.Count == 1)
				Console.WriteLine("Equilateral");
			else if (angles.Count == 2)
				Console.WriteLine("Isosceles");
			else
				Console.WriteLine("Scalene");
		}
	}
}