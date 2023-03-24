using System;
using System.Linq;

public class Solution {
    public int[] solution(int k, int[] score) {
		int[] answer = new int[score.Length];
		int[] hof = Enumerable.Repeat(int.MinValue, k).ToArray();
		for (int i=0; i<score.Length; i++)
		{
			if(hof[0] < score[i])
			{
				hof[0] = score[i];
				Array.Sort(hof);
			}
			if(i < k)
				answer[i] = hof[k-1-i];
			else
				answer[i] = hof[0];
		}
		return answer;

    }
}