namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] inputs = System.Console.ReadLine().Split();

			int a = int.Parse(inputs[0]);
			int b = int.Parse(inputs[1]);
			int v = int.Parse(inputs[2]);

			// Ax - B(x-1) <= V

			double x = (v - b) / (a - b);

			if ((v - b) % (a - b) != 0)
				x++;
			
			System.Console.WriteLine(x);
		}
	}
}