using System;

public class Solution {
    public long solution(long n) {
		double x = Math.Sqrt(n);
		if (x % 1 != 0)
			return -1;
		else
			return (long)Math.Pow(x + 1, 2);

    }
}