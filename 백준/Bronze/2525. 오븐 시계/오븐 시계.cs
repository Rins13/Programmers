namespace ConsoleApp2
{
	public class Program
	{
		static void Main(string[] args)
		{
			string currTime = System.Console.ReadLine();
			string[] times = currTime.Split(' ');
			int hour = int.Parse(times[0]);
			int min = int.Parse(times[1]);

			int addTime = int.Parse(System.Console.ReadLine());

			min += addTime;
			hour = (hour + (min / 60)) % 24;
			min = min % 60;

			System.Console.WriteLine($"{hour} {min}");
		}
	}
}