using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
						int zero = lottos.Where(x => x == 0).ToList().Count;
			int dup = 0;

			for (int i = 0; i < lottos.Length; i++)
			{
				if (win_nums.Contains(lottos[i]))
					dup++;
			}

			int min = 7 - dup;
			int max = 7 - (dup + zero);

			if (min > 6) min = 6;
			else if (min < 1) min = 1;

			if (max > 6) max = 6;
			else if (max < 1) max = 1;

			int[] answer = { max, min };
			return new int[] { max, min };
    }
}