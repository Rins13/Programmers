using System;

public class Solution {
    public string solution(int a, int b) {
		int day = (new DateTime(2016, a, b) - new DateTime(2016, 1, 1)).Days;

		string[] days = new string[] { "FRI", "SAT", "SUN", "MON", "TUE", "WED", "THU" };
		return days[day % 7];

    }
}