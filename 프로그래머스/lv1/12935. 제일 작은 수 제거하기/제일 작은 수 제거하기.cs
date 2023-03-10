using System.Linq;

public class Solution {
    public int[] solution(int[] arr) {
		int min = arr.Min();
		int[] answer = arr.Where(x => x > min).ToArray();
        
		if(answer.Length == 0)
			return new int[] { -1 };
		else
			return answer;

    }
}