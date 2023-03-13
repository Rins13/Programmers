public class Solution {
    public int solution(int num) {
		int i = 0;

		double doubleNum = num;
		while(doubleNum != 1 && i< 500)
		{
			if (doubleNum % 2 == 0)
				doubleNum /= 2;
			else
				doubleNum = doubleNum * 3 + 1;

			i++;

			if(i == 487)
			{

			}

		}

		if (i == 500)
			return -1;
		else
			return i;

    }
}