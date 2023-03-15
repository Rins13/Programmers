using System;

public class Solution {
    public int solution(string t, string p) {
		int answer = 0; 
        double count = t.Length - p.Length + 1;
        
		for (int i = 0; i < count; i++)
		{
			string num = "";
			for (int j = 0; j < p.Length; j++)
				num += t[i+j];

			if (double.Parse(num) <= double.Parse(p))
				answer++;
		}
        
		return answer;
    }
}