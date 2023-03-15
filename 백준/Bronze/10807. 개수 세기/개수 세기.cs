namespace ConsoleApp2
{
	public class Program
	{
		static void Main(string[] args)
		{
			System.Console.ReadLine();
			string[] numbers = System.Console.ReadLine().Split(' ');
			int num = int.Parse(System.Console.ReadLine());

			int count = 0;
			for (int i = 0; i < numbers.Length; i++)
				if (int.Parse(numbers[i]) == num)
					count++;

			System.Console.WriteLine(count);
		}

	}
}