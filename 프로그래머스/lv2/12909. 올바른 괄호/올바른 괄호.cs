using System.Collections.Generic;

public class Solution {
    public bool solution(string s) {
		Stack<char> stack = new Stack<char>();
		foreach(char c in s )
		{
			if (c == '(')
				stack.Push(c);
			else if (stack.Count == 0)
				return false;
			else
				stack.Pop();
		}

		if (stack.Count == 0)
			return true;
		else
			return false;

    }
}