namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] nums = System.Console.ReadLine().Split(' ');
			string num1 = nums[0];
			string num2 = nums[1];

			int length1 = num1.Length;
			int length2 = num2.Length;
			int length = (length1 > length2) ? length1 : length2;

			int up = 0;
			string answer = "";
			for(int i =1; i<=length;i++)
			{
				int n1 = (i<= length1) ? num1[length1 - i] - '0' : 0;
				int n2 = (i<=length2 ) ? num2[length2 -i] -'0' : 0;

				int sum = n1 + n2 + up;
				answer =  (sum % 10) + answer;
				up = sum / 10;
			}

			if(up > 0)
				answer = up + answer;

			System.Console.WriteLine(answer);
		}
	}
}