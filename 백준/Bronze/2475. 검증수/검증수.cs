namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] nums = System.Console.ReadLine().Split(' ');
			int sum = 0;
			foreach(string num in nums)
				sum += (int)Math.Pow(int.Parse(num),2);

			System.Console.WriteLine(sum % 10);
		}
	}
}