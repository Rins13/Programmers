using System;

public class Solution {
    public int solution(int[,] dots) {
        int x = dots[0, 0], y = dots[0,1];
		int width = 0, height = 0;

		for(int i = 1; i< dots.GetLength(0); i++)
		{
			if (x == dots[i, 0])
				height = Math.Abs(y - dots[i, 1]);
			else if(y == dots[i, 1])
				width = Math.Abs(x - dots[i, 0]);
		}
		return width * height;
    }
}