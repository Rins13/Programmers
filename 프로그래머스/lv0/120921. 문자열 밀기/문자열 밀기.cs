using System;

public class Solution {
    public int solution(string A, string B) {
        if (A == B)
            return 0;

        int count = A.Length;
        for(int answer = 0; answer < count; answer ++)
        {
            A = A[count - 1] + A.Remove(count - 1);
            
            if (A == B)
                return answer+1;
        }
        
        return -1;
    }
}