using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace rinstest
{
	class Program
	{
		static void Main(string[] args)
		{
			int i = 0;
			while(i == 0)
			{
				String temp = System.Console.ReadLine();
				String[] num = temp.Split(' ');

				int A = Convert.ToInt32(num[0]);
				int B = Convert.ToInt32(num[1]);

				if (!(0 < A) || !(B < 10))
					System.Console.WriteLine(@"조건 : 0 < A, B < 10 \n 다시 입력하세요!");

				else
				{
					System.Console.WriteLine(A+B);
					i = 1;
				}
			}


		}
	}
}
