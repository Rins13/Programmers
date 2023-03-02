using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[,] score) {
		double[] average = new double[score.GetLength(0)];
		for(int  i = 0; i< score.GetLength(0);i++)
			average[i] = (double)(score[i, 0] + score[i, 1]) / 2;

		double[] ranks = average.OrderByDescending(x => x).ToArray();
		Dictionary<double, int> ranking = new Dictionary<double , int>();
		for(int i = 0; i< ranks.Length; i++)
		{
			if(!ranking.ContainsKey(ranks[i]))
				ranking.Add(ranks[i], i+1);
		}
		
        return average.Select(x => ranking[x]).ToArray();
    }
}