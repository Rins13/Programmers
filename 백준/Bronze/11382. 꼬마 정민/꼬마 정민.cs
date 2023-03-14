namespace ConsoleApp2
{
	public class Program
	{
		static void Main(string[] args)
		{
			string input = System.Console.ReadLine();
			string[] nums = input.Split(' ');
			double sum = 0;
			foreach (string num in nums)
				sum += double.Parse(num);
			System.Console.WriteLine(sum);
		}
	}
}