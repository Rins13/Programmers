using System.Collections.Generic;

public class Solution {
    public int[] solution(string s) {
	Dictionary<char, int> dics = new Dictionary<char, int>();
	int[] answer = new int[s.Length];

	for(int i = 0; i<s.Length;i++)
	{
		if (!dics.ContainsKey(s[i]))
		{
			answer[i] = -1;
			dics.Add(s[i], i);
		}
		else
		{
			answer[i] = i - dics[s[i]];
			dics[s[i]] = i;
		}
	}

	return answer;

    }
}