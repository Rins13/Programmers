namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] splits = System.Console.ReadLine().Split(' ');
			int count = int.Parse(splits[0]);
			int changes = int.Parse(splits[1]);

			int[] baskets = new int[count];
			for (int i = 0; i < count; i++)
				baskets[i] = i;

			for(int i = 0; i<changes;i++)
			{
				splits = System.Console.ReadLine().Split(' ');
				int begin = int.Parse(splits[0]);
				int end = int.Parse(splits[1]);
				int mid = int.Parse(splits[2]);

				int beginToend = end - begin + 1;
				int midToend = end - mid +1;
				int beginTomid = mid - begin;
				int[] change = new int[beginToend];

				

				Array.Copy(baskets, mid - 1, change, 0, midToend);
				Array.Copy(baskets, begin-1, change, midToend, beginTomid);

				begin--;
				for (int j = 0; j < change.Length; j++)
					baskets[begin + j] = change[j];
			}

			string answer = (baskets[0]+1).ToString();
			for (int i = 1; i < count; i++)
				answer += $" {baskets[i]+1}";

			System.Console.WriteLine(answer);
		}
	}
}