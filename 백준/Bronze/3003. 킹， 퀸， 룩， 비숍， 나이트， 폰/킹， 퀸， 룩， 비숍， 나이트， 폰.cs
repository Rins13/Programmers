namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] input = (System.Console.ReadLine()).Split(' ');
			int[] piece = new int[] { 1, 1, 2, 2, 2, 8 };
			string answer = "";
			for (int i = 0; i < piece.Length; i++)
				answer += $"{piece[i] - int.Parse(input[i])} ";

			System.Console.WriteLine(answer.Remove(answer.Length - 1));
		}
	}
}