namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] inputs = System.Console.ReadLine().Split(' ');
			int row = int.Parse(inputs[0]);
			int col = int.Parse(inputs[1]);

			int[,] sums = new int[row,col];

			for (int i = 0; i < row *2; i++)
			{
				inputs = System.Console.ReadLine().Split(' ');
				for(int j = 0; j<col;j++)
				{
					sums[i % row, j] += int.Parse(inputs[j]);
				}
			}

			string answer = "";
			for (int i = 0; i < row; i++)
			{
				for (int j = 0; j < col; j++)
					answer += $"{sums[i, j]} " ;

				answer = $"{answer.Remove(answer.Length - 1)}\n";
			}

			System.Console.WriteLine(answer.Remove(answer.Length - 1));
		}
	}
}