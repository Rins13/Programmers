public class Solution {
    public string solution(string s) {
		string[] nums = s.Split(' ');
		int max = int.MinValue;
		int min = int.MaxValue;
		foreach (string num in nums)
		{
			int n = int.Parse(num);
			if (max < n)
				max = n;

			if (min > n)
				min = n;
		}
		return $"{min} {max}";

    }
}