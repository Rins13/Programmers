namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] splits = System.Console.ReadLine().Split(' ');
			int num1 = int.Parse(splits[0]);
			int num2 = int.Parse(splits[1]);

			int count = 0;


			for (int i = 1; i <= num1; i++)
			{
				if (num1 % i == 0)
					count++;

				if (count == num2)
				{
					System.Console.WriteLine(i);
					return;
				}
			}
			System.Console.WriteLine(0);

		}
	}
}