namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(System.Console.ReadLine()) * 2 -1;
			int i = 1, flag = 1;

			if(count == 1)
			{
				System.Console.WriteLine($"{new string('*', i)}");
				return;
			}
				
			while (i > 0)
			{
				int blanks = (count - i) / 2;
				System.Console.WriteLine($"{new string(' ', blanks)}{new string('*', i)}");

				i += 2 * flag;

				if (i >= count)
					flag = -1;
			}
		}
	}
}