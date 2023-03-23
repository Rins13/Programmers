using System;

public class Solution {
    public int[] solution(string s) {
		int removeCount = 0;
		int removeZero = 0;
		
		while(s != "1")
		{
			string removeS = s.Replace("0", "");
			removeZero += (s.Length - removeS.Length);
			removeCount++;
			s = Convert.ToString(removeS.Length, 2);
		}

		return new int[] { removeCount , removeZero };

    }
}