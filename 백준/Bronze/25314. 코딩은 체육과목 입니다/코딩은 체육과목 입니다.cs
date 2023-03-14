namespace ConsoleApp2
{
	public class Program
	{
		static void Main(string[] args)
		{

			int byteCount = int.Parse(System.Console.ReadLine());
			int count = byteCount / 4;
			string answer = "int";

			for(int  i =0; i< count; i++)
			{
				answer = $"long {answer}";
			}

			System.Console.WriteLine(answer);

		}
	}
}