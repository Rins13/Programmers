using System;

namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			double sum_score = 0;
			double sum_grade = 0;
			string[] grades = new string[] { "F","", "D0", "D+", "C0", "C+", "B0", "B+", "A0", "A+" };
			for (int i = 0; i < 20; i++)
			{
				string[] inputs = System.Console.ReadLine().Split(' ');
				double score = double.Parse(inputs[1]);

				int grade = Array.IndexOf(grades, inputs[2]);
				if (grade == -1)
					continue;

				sum_score += score * 0.5 * grade;
				sum_grade += score;
			}

			System.Console.WriteLine(sum_score / sum_grade);
		}
	}
}