namespace ConsoleApp
{
	class Program
	{
		static void Main(string[] args)
		{
			while(true)
			{
				int input = int.Parse(System.Console.ReadLine());
				if (input == -1)
					break;

				string answer = $"{input} = 1 +";
				int sum = 1;

				for (int i = 2; i < input; i++)
				{
					if (input % i == 0)
					{
						answer += $" {i} +";
						sum += i;
					}
				}

				if (sum != input)
					answer = $"{input} is NOT perfect.";
				else
					answer = answer.Remove(answer.Length - 2);
	
					System.Console.WriteLine(answer);
			}
		}
	}
}