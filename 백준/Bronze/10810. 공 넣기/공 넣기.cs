namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] splits = (System.Console.ReadLine()).Split(' ');
			int basketCount = int.Parse(splits[0]);
			int count = int.Parse(splits[1]);

			int[] balls = new int[basketCount];
			for (int c = 0; c<count;c++)
			{
				splits = (System.Console.ReadLine()).Split(' ');
				int[] nums = new int[3];
				for (int idx = 0; idx < splits.Length; idx++)
					nums[idx] = int.Parse(splits[idx]);
				
				for(int i = nums[0] -1 ; i<nums[1];i++)
					balls[i] = nums[2];
			}

			string answer = "";
			foreach (int num in balls)
				answer += $"{num} ";

			System.Console.WriteLine(answer.Remove(answer.Length - 1));
		}

	}
}