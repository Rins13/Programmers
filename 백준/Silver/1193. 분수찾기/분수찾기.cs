namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			int num = int.Parse(System.Console.ReadLine());
			int sum = 1;
			int i = 1;

			for (; sum + i <= num; i++)
				sum += i;

			int gap = num - sum;

			if(i%2 == 0)
				System.Console.WriteLine($"{gap + 1}/{i - gap}");
			else
				System.Console.WriteLine($"{i - gap}/{gap + 1}");
		}
	}
}