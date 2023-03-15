using System;

public class Solution {
    public string solution(int a, int b) {
		string dayOfWeek = new DateTime(2016, a, b).DayOfWeek.ToString();
		return dayOfWeek.Substring(0, 3).ToUpper();

    }
}