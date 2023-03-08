using System;

public class Solution {
    public int solution(string[] spell, string[] dic) {
		for (int i = 0; i < dic.Length; i++)
		{
			foreach (string sp in spell)
			{
				int idx = dic[i].IndexOf(sp);
				if (idx < 0)	
                {
                    dic[i] += sp;
                    break;
                }
                    
				dic[i] = dic[i].Remove(idx, 1);

			}

			if (string.IsNullOrEmpty(dic[i]))
				return 1;

		}
		return 2;
    }
}