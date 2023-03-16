namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] splits = (System.Console.ReadLine()).Split(' ');
			int basketCount = int.Parse(splits[0]);
			int changeTime = int.Parse(splits[1]);

			int[] balls = new int[basketCount];
			for (int i = 0; i < balls.Length; i++)
				balls[i] = i + 1;


			for (int c = 0; c< changeTime; c++)
			{
				splits = (System.Console.ReadLine()).Split(' ');

				int basket_1 = int.Parse(splits[0]) -1;
				int basket_2 = int.Parse(splits[1]) -1;

				int temp = balls[basket_1];
				balls[basket_1] = balls[basket_2];
				balls[basket_2] = temp;
			}

			string answer = "";
			foreach (int num in balls)
				answer += $"{num} ";

			System.Console.WriteLine(answer.Remove(answer.Length - 1));
		}

	}
}