using System;
using System.Linq;

public class Solution 
{
    public int solution(int n) 
    {
		bool[] nums = Enumerable.Repeat(true, n+1).ToArray();
		nums[0] = false;
		nums[1] = false;

		// i의 제곱 > n 
		int i = 2;
		while(true)
		{
			if (Math.Pow(i, 2) > n)
				break;

			if(isPrime(i))
			{
				for (int j = 2*i; j <= n; j = j+i)
				{
					nums[j] = false;
				}
			}

			while(true)
			{
				if (nums[++i])
					break;
			}
		}

		return nums.Where(x => x).Count();
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