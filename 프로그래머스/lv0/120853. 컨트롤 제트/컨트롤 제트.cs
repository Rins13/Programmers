using System;

public class Solution {
    public int solution(string s) {
		string[] splits = s.Split(' ');
		int prev = 0, answer = 0; ;
		foreach (string split in splits)
		{
			if (int.TryParse(split, out int num))
			{
				prev = num;
				answer += num;
			}
			else
				answer -= prev;
		}

		return answer;
    }
}