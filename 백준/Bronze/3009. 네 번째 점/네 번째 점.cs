using System.Collections.Generic;

namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			List<int> answer_X = new List<int>();
			List<int> answer_Y = new List<int>();

			for (int i =0; i< 3;i++)
			{
				string[] inputs = System.Console.ReadLine().Split();
				int x = int.Parse(inputs[0]);
				int y = int.Parse(inputs[1]);

				if (answer_X.Contains(x))
					answer_X.Remove(x);
				else
					answer_X.Add(x);

				if (answer_Y.Contains(y))
					answer_Y.Remove(y);
				else
					answer_Y.Add(y);
			}
			System.Console.WriteLine($"{answer_X[0]} {answer_Y[0]}");
		}
	}
}