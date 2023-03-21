using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(System.Console.ReadLine());
			bool[,] arr = new bool[100, 100];

			int answer = 0;
			for (int i =0; i< count;i++)
			{
				string[] splits = System.Console.ReadLine().Split(' ');
				int col = int.Parse(splits[0]);
				int row = int.Parse(splits[1]);

				for(int j = 0; j<10;j++)
				{
					for (int k = 0; k < 10; k++)
					{
						if (row + j >= 100 || col + k >= 100)
							continue;

						if (!arr[row + j, col + k])
							answer++;
						arr[row + j, col + k] = true;
					}
				}
			}
			Console.WriteLine(answer);
		}
	}
}