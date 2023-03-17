namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] splits = (System.Console.ReadLine()).Split();
			int length = splits.Length;

			if (splits[length - 1] == "")
				length--;

			if (splits[0] == "")
				length--;

			System.Console.WriteLine(length);
		}
	}
}