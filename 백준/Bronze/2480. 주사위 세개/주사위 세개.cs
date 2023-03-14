using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
	public class Program
	{
		static void Main(string[] args)
		{

			string input = System.Console.ReadLine();
			string[] str_dices = input.Split(' ');

			List<int> dices = new List<int>();
			int dup = 0;
			foreach (string str_dice in str_dices)
			{
				int dice = int.Parse(str_dice);
				if (!dices.Contains(dice))
					dices.Add(dice);
				else
					dup = dice;
			}

			int reward = 0;
			switch (dices.Count)
			{
				case 1:
					reward = 10000 + dices[0] * 1000;
					break;
				case 2:
					reward = 1000 + dup * 100;
					break;
				case 3:
					reward = dices.Max() * 100;
					break;

			}

			System.Console.WriteLine(reward);


		}
	}
}
