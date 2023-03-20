namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			int max = -1;
			string answer = "";
			for (int i = 0; i < 9; i++)
			{
				string[] inputs = System.Console.ReadLine().Split(' ');
				for (int j = 0; j < 9; j++)
				{
					if (int.TryParse(inputs[j], out int num) && num > max)
					{
						max = num;
						answer = $"{max}\n{i+1} {j+1}";
					}
					
				}
			}
			System.Console.WriteLine(answer);
		}
	}
}