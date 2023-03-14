using System;

public class Solution {
    public int solution(int[] d, int budget) {
		Array.Sort(d);

		int answer = 0;
		while(true)
		{
			if (answer >= d.Length || budget - d[answer] < 0)
				break;

			budget -= d[answer];
			answer++;

		}

		return answer;
    }
}