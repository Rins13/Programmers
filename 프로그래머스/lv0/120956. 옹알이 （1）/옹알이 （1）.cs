using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(string[] babbling) {
			string[] strs = new string[] { "aya", "ye", "woo", "ma" };

			int answer = 0;
			foreach (string babble in babbling)
			{
				List<string> splits = babble.Split(strs, StringSplitOptions.None).ToList();
				if (splits.Count == splits.Where(x => string.IsNullOrEmpty(x)).Count())
					answer++;


			}

			return answer;
		}
    
}