using System;

public class Solution {
    public int solution(int n) {
			int multip = 1;
			for (int i = 1; i < 11; i++)
			{
				if ((multip *= i) == n)
					return i;
				else if (multip > n)
					return i - 1;
			}

			return -1;
    }
}