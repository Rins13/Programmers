namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			int count = int.Parse(System.Console.ReadLine());
			int x = 3;
			for(int i =1; i< count;i++)
			{
				x += (x - 1);
			}
			
			System.Console.Write(x*x);
		}
	}
}