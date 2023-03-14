using System;

public class Solution {
    public int solution(int n) {
		string str_base = "";
		while (n > 0)
		{
			str_base = (n % 3) + str_base;
			n = n / 3;
		}

		int answer = 0;
		for (int i = 0; i < str_base.Length; i++)
			answer += (str_base[i] - '0') * (int)Math.Pow(3, i);

		return answer;

    }
}