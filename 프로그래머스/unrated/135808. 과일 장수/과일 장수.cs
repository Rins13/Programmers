using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
		Array.Sort(score);
		Array.Reverse(score);

		int answer = 0;

		for (int i = m; i <= score.Length; i += m)
			answer += score[i-1] * m;

		return answer;

    }
}