namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(System.Console.ReadLine());
			double[] coins = new double[] {25,10,5,1 };
			string answer = "";
			for(int i =0; i< count;i++)
			{
				double change = int.Parse(System.Console.ReadLine());
				string value = "";
				foreach(double coin in coins)
				{
					int num = (int)(change / coin);
					value += $"{num} ";
					change = change % coin;
				}

				answer += $"{value.Remove(value.Length - 1)}\n";
			}
			
			System.Console.Write(answer);
		}
	}
}