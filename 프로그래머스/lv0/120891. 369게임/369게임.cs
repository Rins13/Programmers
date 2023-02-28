using System;

public class Solution {
    public int solution(int order) {
    	int answer = 0;
		char[] nums = order.ToString().ToCharArray();
        
		foreach (char num in nums)
		{
			if (num == '3' || num == '6' || num == '9')
				answer++;
		}
			
		return answer;
    }
}