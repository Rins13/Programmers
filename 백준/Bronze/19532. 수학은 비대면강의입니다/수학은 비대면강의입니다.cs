using System.Linq;

namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			
			int[] num = System.Console.ReadLine().Split(' ').Select(x => int.Parse(x)).ToArray();

			int a = num[0];
			int b = num[1];
			int c = num[2];
			int d = num[3];
			int e = num[4];
			int f = num[5];

			for (int x = -999; x <= 999; x++)
			{
				for (int y = -999; y <= 999; y++)
				{
					if (a * x + b * y == c && d * x + e * y == f)
					{
						System.Console.WriteLine($"{x} {y}");
						return;
					}
				}
			}

		}
	}
}