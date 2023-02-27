using System;

public class Solution {
    public string solution(string my_string) {
        string answer = "";
	foreach(char ch in my_string)
	{
		if (char.IsUpper(ch))
	            answer += char.ToLower(ch);
		else
	            answer += char.ToUpper(ch);
	}
	return answer;
    }
}
