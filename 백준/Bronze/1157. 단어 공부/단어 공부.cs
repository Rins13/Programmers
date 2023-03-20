using System.Linq;

namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			string str = System.Console.ReadLine();

			char[] chs = str.ToUpper().ToCharArray();
			var sortList = chs.GroupBy(x => x).OrderByDescending(y => y.Count()).ToArray();

			if(sortList.Length > 1 && sortList[0].Count() == sortList[1].Count())
				System.Console.WriteLine("?");
			else
				System.Console.WriteLine(sortList[0].Key);

		}
	}
}