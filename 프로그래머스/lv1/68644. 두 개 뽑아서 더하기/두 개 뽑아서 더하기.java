import java.util.ArrayList;
import java.util.Collections;

class Solution {
    public int[] solution(int[] numbers) {
        int i,j=0;

		
		ArrayList<Integer> Pre_answer = new ArrayList<>();
		
				for(i=0;i<numbers.length;i++)
	    {
			for(j=(i+1);j<numbers.length;j++)
		    {
				if(!Pre_answer.contains(numbers[i]+numbers[j]))
				{
					Pre_answer.add(numbers[i]+numbers[j]);
					
				}
		     }
	     }
		
		Collections.sort(Pre_answer);

		int[] answer = new int[Pre_answer.size()];
		
		for(i=0;i<Pre_answer.size();i++)
	    {
			answer[i] = Pre_answer.get(i);
	     }
		
        
        return answer;  
    }
}