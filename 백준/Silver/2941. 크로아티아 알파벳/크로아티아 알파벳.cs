namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] croatiaAlphabet = new string[] { "c=", "c-", "dz=", "d-", "lj", "nj", "s=", "z=" };
			string input = System.Console.ReadLine();

			foreach (string alphabet in croatiaAlphabet)
			{
				if (input.Contains(alphabet))
					input = input.Replace(alphabet, " ");
			}

			System.Console.WriteLine(input.Length);
		}
	}
}