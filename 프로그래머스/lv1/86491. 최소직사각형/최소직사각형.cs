using System;

public class Solution {
    public int solution(int[,] sizes) {
		int width = 0, height = 0;
		for (int i = 0; i < sizes.GetLength(0); i++)
		{
			int min = sizes[i, 0], max = sizes[i, 1];
			if (max < min)
			{
				min = sizes[i, 1];
				max = sizes[i, 0];
			}

			if (width < min)
				width = min;

			if (height < max)
				height = max;
		}

		return width * height;

    }
}