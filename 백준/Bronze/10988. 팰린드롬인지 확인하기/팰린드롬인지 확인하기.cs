namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			string str = System.Console.ReadLine();

			int sameLength = str.Length / 2;

			for (int i = 0; i < sameLength; i++)
			{
				if (str[i] != str[str.Length - 1 - i])
				{
					System.Console.WriteLine(0);
					return;
				}

			}
			System.Console.WriteLine(1);

		}
	}
}