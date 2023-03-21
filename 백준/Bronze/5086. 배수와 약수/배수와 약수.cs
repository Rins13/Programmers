namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			string answer = "";
			while(true)
			{
				string[] splits = System.Console.ReadLine().Split(' ');
				int num1 = int.Parse(splits[0]);
				int num2 = int.Parse(splits[1]);

				if (num1 == 0 && num2 == 0)
					break;

				if (num1 % num2 == 0)
					answer += "multiple\n";
				else if (num2 % num1 == 0)
					answer += "factor\n";
				else
					answer += "neither\n";
			}

			System.Console.WriteLine(answer.Remove(answer.Length - 1));
		}
	}
}