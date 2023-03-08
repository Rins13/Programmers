using System.Collections.Generic;

public class Solution {
    public int solution(int[] sides) {
		List<int> addLegs = new List<int>();

		int b = sides[0], s = sides[1];
		if (sides[0] < sides[1])
		{
			b = sides[1];
			s = sides[0];
		}

		int other = b;
		while(true)
		{
			if (other + s > b &&  !addLegs.Contains(other))
				addLegs.Add(other);
			else if(other < 1)
				break;

			other--;
		}

		other = (s+b) -1;
		while (true)
		{
			if (other > b && !addLegs.Contains(other))
				addLegs.Add(other);
			else
				break;

			other--;
		}

		return addLegs.Count;

    }
}