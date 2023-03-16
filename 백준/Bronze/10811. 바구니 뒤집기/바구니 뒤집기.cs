namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] splits = (System.Console.ReadLine()).Split(' ');
			int basketCount = int.Parse(splits[0]);
			int changeTime = int.Parse(splits[1]);

			int[] baskets = new int[basketCount];
			for (int i = 0; i < basketCount; i++)
				baskets[i] = i;


			for (int c = 0; c < changeTime; c++)
			{
				splits = (System.Console.ReadLine()).Split(' ');

				int min = int.Parse(splits[0]) - 1;
				int max = int.Parse(splits[1]) - 1;
				int count = max - min + 1;
				int[] copyBaskets = new int[count];
				Array.Copy(baskets, min, copyBaskets, 0, count);
				for (int i = 0; i < count; i++)
				{
					baskets[min + i] = copyBaskets[count - i - 1];
				}

			}

			string answer = "";
			foreach (int num in baskets)
				answer += $"{num + 1} ";

			System.Console.WriteLine(answer.Remove(answer.Length - 1));
		}
	}
}