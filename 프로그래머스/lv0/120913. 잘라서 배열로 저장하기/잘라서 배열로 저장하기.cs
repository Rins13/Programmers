using System.Collections.Generic;

public class Solution {
    public string[] solution(string my_str, int n) {
		List<string> answer = new List<string>();
		int count = my_str.Length / n;
		int addCount = my_str.Length % n;

		for (int i = 0; i< count; i++)
			answer.Add(my_str.Substring(i*n, n));

		if (addCount > 0)
			answer.Add(my_str.Substring(count * n, addCount));

		return answer.ToArray();
    }
}