using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp
{
	public class Program
	{
		static void Main(string[] args)
		{
			string[] inputs = System.Console.ReadLine().Split();
			int[] nums = new int[3];
			for (int i = 0; i < inputs.Length; i++)
				nums[i] = int.Parse(inputs[i]);

			/*
			 *  1. A+Bx < Cx
			 * 
			 *  2. 
			 *      A
			 *    ----- < x
			 *     C-B
			 */

			int c_Minus_b = nums[2] - nums[1];


			if (c_Minus_b < 1)
				Console.WriteLine(-1);
			else
				Console.WriteLine((int)(nums[0] / c_Minus_b) + 1);
		}
	}
}
