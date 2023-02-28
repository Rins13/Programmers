using System;

public class Solution {
    public string solution(string my_string, int num1, int num2) {
		char[] chars = my_string.ToCharArray();

		char temp = chars[num1];
		chars[num1] = chars[num2];
		chars[num2] = temp;

		return string.Concat(chars);
    }
}