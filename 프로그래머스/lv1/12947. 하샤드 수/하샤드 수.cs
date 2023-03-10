public class Solution {
    public bool solution(int x) {
        int sum = 0;

		foreach (char num in x.ToString())
			sum += num - '0';

		return x % sum == 0;

    }
}