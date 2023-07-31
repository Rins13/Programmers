using System.Collections.Generic;

namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] nm = System.Console.ReadLine().Split(' ');
			int n = int.Parse(nm[0]);
			int m = int.Parse(nm[1]);


			string[] str_cards = System.Console.ReadLine().Split(' ');

			List<int> cards = new List<int>();
			for (int i = 0; i < str_cards.Length; i++)
			{
				int card = int.Parse(str_cards[i]);
				if (card > m-2)
					continue;

				cards.Add(card);
			}

			cards.Sort();


			int result = 0;
			for(int i =0; i< cards.Count-2;i++)
			{
				for(int j = i+1; j<cards.Count-1;j++)
				{
					for (int k = j + 1; k < cards.Count; k++)
					{
						int sum = cards[i] + cards[j] + cards[k];
						if (sum <= m && m - sum < m - result)
							result = sum;

					}
				}
			}

			System.Console.WriteLine(result);
		}
	}
}
