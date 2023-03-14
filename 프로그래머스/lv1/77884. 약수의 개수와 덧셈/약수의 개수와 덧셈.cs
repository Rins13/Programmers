using System;

public class Solution {
    public int solution(int left, int right) {
		int answer = 0;
		
		for(int i = left; i<= right; i++)
		{
			answer += (isEvenDivisor(i)) ? i : -i;
		}

		return answer;
	}

	public bool isEvenDivisor(int num)
	{
		int count = 0;
		for(int i = 1; i<= num; i++)
		{
			if (num % i == 0)
				count ++;
		}

		if (count % 2 == 0)
			return true;
		else
			return false;

	}

}