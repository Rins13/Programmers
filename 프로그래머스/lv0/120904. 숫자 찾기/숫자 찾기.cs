using System;

public class Solution {
    public int solution(int num, int k) {
        int answer = (num.ToString()).IndexOf((char)(k + '0'));
		if (answer == -1)
			return answer;
		else
			return answer + 1;
    }
}