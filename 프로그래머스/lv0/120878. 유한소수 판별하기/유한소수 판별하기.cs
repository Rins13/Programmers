using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int a, int b)
	{
		int[] primes = Primes(Irreducible(new int[] { a, b })[1]);
		foreach(int prime in primes)
		{
			if (prime != 2 && prime != 5 && prime != 1)
				return 2;
		}
		return 1;
	}

	public int[] Irreducible(int [] numbers)
	{
		int gcd = GCD(numbers[0], numbers[1]);
		numbers[0] /=  gcd;
		numbers[1] /= gcd;
			return numbers;
	}
    
	public int GCD(int a, int b)
	{
		if (b == 0) return a;
		else return GCD(b, a % b);
	}
    
	public int[] Primes(int n)
	{			
        List<int> primes = new List<int>();
		int currPrime = 2;
		while (!isPrime(n))
		{
			if (n % currPrime == 0)
			{
				n /= currPrime;
				primes.Add(currPrime);
			}
			else
			{
				currPrime++;
				while (!isPrime(currPrime))
				{
					currPrime++;
				}
			}
		}
		primes.Add(n);

		return primes.Distinct().ToArray();
	}
    
	public bool isPrime(int n)
	{
		int count = 0;
		for (int i = 2; i < n; i++)
		{
			if (n % i == 0)
				count++;
		}
		if (count == 0)
			return true;
		else
			return false;
        
		}
}