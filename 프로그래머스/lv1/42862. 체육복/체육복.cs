using System;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        
        Array.Sort(lost);
		Array.Sort(reserve);

		for (int i = 0; i< lost.Length; i++)
		{
			int idx = Array.IndexOf(reserve, lost[i]);
			if(idx > -1)
			{
				reserve[idx] = int.MinValue;
				lost[i] = int.MinValue;
			}
			else
				n--;
		}

		foreach(int num in lost)
		{
			if (num == int.MinValue)
				continue;

			int prevIdx = Array.IndexOf(reserve, num - 1);
			int nextIdx = Array.IndexOf(reserve, num + 1);

			if (prevIdx > -1)
				reserve[prevIdx] = int.MinValue;
			else if (nextIdx > -1)
				reserve[nextIdx] = int.MinValue;
			else
				continue;

			n++;
		}

		return n;

    }
}