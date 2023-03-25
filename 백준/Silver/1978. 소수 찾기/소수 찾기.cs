namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			System.Console.ReadLine();
			string[] inputs = System.Console.ReadLine().Split();

			int count = 0;
			for (int i = 0; i < inputs.Length; i++)
			{
				int num = int.Parse(inputs[i]);

				if (isPrime(num))
					count++;
			}

			System.Console.WriteLine(count);
		}

		static bool isPrime(int num)
		{

			if (num < 2)
				return false;

			int half = num / 2;

			for (int i = 2; i < half+1; i++)
			{
				if (num % i == 0)
					return false;
			}

			return true;
		}
	}
}