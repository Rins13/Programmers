namespace ConsoleApp2
{
	public class Program
	{
		static void Main(string[] args)
		{

			int sum = int.Parse(System.Console.ReadLine());
			int idx = int.Parse(System.Console.ReadLine());

			int calc = 0;
			for(int  i =0; i< idx;i++)
			{
				string input = System.Console.ReadLine();
				string[] inputs = input.Split(' ');
				int price = int.Parse(inputs[0]);
				int count = int.Parse(inputs[1]);
				calc += price * count;
			}

			if(calc == sum)
				System.Console.WriteLine("Yes");
			else
				System.Console.WriteLine("No");

		}
	}
}