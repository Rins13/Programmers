using System.Collections.Generic;
using System.Linq;

public class Solution {
    public string solution(string X, string Y) {
		int[] nums_x = new int[10];
		int[] nums_y = new int[10];

		foreach (char ch in X)
			nums_x[ch - '0']++;

		foreach (char ch in Y)
			nums_y[ch - '0']++;

		string answer = "";
		int count = 0;
		for (int i =9; i>0; i--)
		{
			 count = (nums_x[i] > nums_y[i]) ? nums_y[i] : nums_x[i];

			if(count > 0)
				answer += new string((char)(i + '0'), count);
		}


		count = (nums_x[0] > nums_y[0]) ? nums_y[0] : nums_x[0];

		if (string.IsNullOrEmpty(answer))
		{
			if (count == 0)
				return "-1";
			else
				return "0";
		}
		else
			answer += new string('0', count);

		return answer;

    }
}