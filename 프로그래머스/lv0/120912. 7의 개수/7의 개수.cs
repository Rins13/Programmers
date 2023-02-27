using System;

public class Solution {
    public int solution(int[] array) {
        int answer = 0;
        foreach (int num in array)
        {
            char[] num_ch = num.ToString().ToCharArray();
            foreach(char ch in num_ch)
            {
                if (ch == '7')
                    answer++;
            }
        }
        
        return answer;
    }
}