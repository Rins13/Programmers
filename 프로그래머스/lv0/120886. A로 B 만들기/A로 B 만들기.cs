using System.Collections.Generic;

public class Solution {
    public int solution(string before, string after) {
        Dictionary<char, int> before_Dic = CountAlphabet(before);
		Dictionary<char, int> after_Dic = CountAlphabet(after);

		foreach(var alp in before_Dic)
		{
			if (!after_Dic.ContainsKey(alp.Key))
				return 0;

			if (alp.Value != after_Dic[alp.Key])
				return 0;
		}
		return 1;
    }
    public Dictionary<char, int> CountAlphabet(string str)
	{
		Dictionary<char, int> alphabets = new Dictionary<char, int>();
		char[] chars = str.ToCharArray();

		foreach(char ch in str)
		{
			if (alphabets.ContainsKey(ch))
				alphabets[ch]++;
			else
				alphabets.Add(ch, 1);
		}

		return alphabets;

	}
}