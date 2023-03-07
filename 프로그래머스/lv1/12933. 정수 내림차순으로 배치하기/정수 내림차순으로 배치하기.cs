using System.Linq;

public class Solution {
    public long solution(long n) {
		char[] numbers = n.ToString().ToCharArray();
		numbers = numbers.OrderByDescending(x => x).ToArray();

		string num_str = new string(numbers);
		return long.Parse(num_str);

    }
}