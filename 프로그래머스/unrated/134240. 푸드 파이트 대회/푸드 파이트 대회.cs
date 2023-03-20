using System;

public class Solution {
    public string solution(int[] food)
    {
		{
			string left = "", right = "";
			for (int i = 0; i < food.Length; i++)
			{
				int count = food[i] / 2;
				if (count > 0)
				{
					left += new string((char)(i + '0'), count);
					right = new string((char)(i + '0'), count) + right;
				}
			}
			

			return $"{left}0{right}";
		}
	}
}