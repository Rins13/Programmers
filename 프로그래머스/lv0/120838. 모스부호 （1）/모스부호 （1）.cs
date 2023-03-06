using System;

public class Solution {
    public string solution(string letter) {
		string answer = "";

		string[] morseCode = new string[] { ".-", "-...", "-.-.", "-..", ".", "..-.", "--.", "....", "..", ".---", "-.-", ".-..", "--", "-.", "---", ".--.", "--.-", ".-.", "...", "-", "..-", "...-", ".--", "-..-", "-.--", "--.." };
		string[] splits = letter.Split(' ');

		foreach(string code in splits)
		{
			answer += (char)((Array.IndexOf(morseCode, code)) + 97);
		}

		return answer;
    }
    
}