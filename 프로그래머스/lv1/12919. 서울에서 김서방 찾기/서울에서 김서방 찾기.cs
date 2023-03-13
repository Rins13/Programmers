using System;

public class Solution {
    public string solution(string[] seoul) {
		string lastName = "Kim";
		return $"김서방은 {Array.IndexOf(seoul, lastName)}에 있다";
    }
}