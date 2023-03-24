using System.Collections.Generic;

public class Solution {
    public int solution(int number, int limit, int power) {
		int answer = 1;
		// 소수
		List<int> primes = new List<int>() { 2};
		for (int i = 2; i <= number; i++)
		{
			int num = i;

			// 약수의 갯수 : 자연수를 소인수분해하였을 때, 각 소인수의 지수에 1을 더한 수들을 곱한 값
			// ex, 72 = 2³×3²=> 약수의 개수는 (3+1) × (2+1) = 12
			int p_idx = 0;
			int exponent = 0; // 지수
			int count = 1; // 약수의 갯수
			while (num > 1)
			{
				if (num % primes[p_idx] == 0)
				{
					exponent++;
					num = num / primes[p_idx];
				}

				else
				{
					if (exponent > 0)
						count *= (exponent + 1);

					exponent = 0;

					if (count > limit)
						break;

					if (p_idx < primes.Count - 1)
						p_idx++;
					else
					{
						int prime = primes[p_idx];
						while (!isPrime(++prime)) { }
						primes.Add(prime);
					}
						
				}
			}

			count *= (exponent + 1);
			answer += (count > limit) ? power : count;
		}

		return answer;
    }
    
    static bool isPrime(int num)
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