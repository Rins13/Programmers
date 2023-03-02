using System;

public class Solution {
    public int solution(string my_string) {
		int count = 0;
		string str_num = "";
		foreach(char ch in my_string)
		{
			if (ch >= 48 && ch <= 57)
				str_num += ch;
			else if (!string.IsNullOrEmpty(str_num))
			{
				count += Convert.ToInt32(str_num);
				str_num = "";
			}
		}
        if (!string.IsNullOrEmpty(str_num))
			{
				count += Convert.ToInt32(str_num);
				str_num = "";
			}
		return count;
    }
}