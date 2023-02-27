using System;

public class Solution {
    public int solution(string my_string) {
        
		string[] splits = my_string.Split(' ');
		int answer = Convert.ToInt32(splits[0]);
        
		for(int i = 1; i< splits.Length;i += 2)
		{
			switch (splits[i])
			{
				case "+":
					answer += Convert.ToInt32(splits[i + 1]);
					break;
				case "-":
					answer -= Convert.ToInt32(splits[i + 1]);
					break;
			}
		}
		return answer;
    }
}