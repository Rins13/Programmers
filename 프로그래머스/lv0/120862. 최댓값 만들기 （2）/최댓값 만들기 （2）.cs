using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int solution(int[] numbers) {
		List<int> multips = new List<int>();

		for (int i = 0; i < numbers.Length; i++)
			for (int j = i + 1; j < numbers.Length; j++)
				multips.Add(numbers[i] * numbers[j]);

		return multips.OrderByDescending(x => x).First();
    }
}