public class Solution {
    public int[] solution(long n) {
		string numbers = n.ToString();

		int[] answer = new int[numbers.Length];

		for(int i = 0; i< numbers.Length;i++)
			answer[numbers.Length - i - 1] = numbers[i] - '0';

		return answer;

    }
}