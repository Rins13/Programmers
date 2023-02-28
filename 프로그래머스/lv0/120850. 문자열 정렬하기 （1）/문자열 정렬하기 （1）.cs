using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(string my_string) {
        List<int> nums = new List<int>();

		foreach (char ch in my_string)
		{
			if (ch >= 28 && ch <= 57)
				nums.Add(ch - '0');
		}
		return nums.OrderBy(x => x).ToArray();
    }
}