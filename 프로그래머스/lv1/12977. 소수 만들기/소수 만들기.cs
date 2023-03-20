using System;

class Solution
{
	public int solution(int[] nums)
	{
		int answer = 0;

		for (int i =0; i< nums.Length - 2;i++)
		{
			for (int j = i+1; j < nums.Length - 1; j++)
			{
				for (int k = j+1; k < nums.Length ; k++)
				{
					if (isPrime(nums[i] + nums[j] + nums[k]))
						answer++;

				}
			}
		}

		return answer;
	}

	public bool isPrime(int num)
	{
		int half = num / 2;
		if (num % 2 == 1)
			half++;

		for (int i = 2; i < half; i++)
		{
			if (num % i == 0)
				return false;
		}

		return true;
	}
}