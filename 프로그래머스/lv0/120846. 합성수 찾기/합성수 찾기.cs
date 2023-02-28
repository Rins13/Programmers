using System;

public class Solution {
    public int solution(int n) {
    if (n < 4)
			return 0;

		int count = 0;

		for (int i = 4; i <= n; i++)
		{
			if (IsCompositeNum(i))
				count++;
		}
		return count;
    }
    
    public bool IsCompositeNum(int num)
	{
		int measure = 0;

		for (int i = 1; i < num + 1; i++)
		{
			if (num % i == 0)
				measure++;
		}

		if (measure >= 3)
			return true;
		else
			return false;

	}
}