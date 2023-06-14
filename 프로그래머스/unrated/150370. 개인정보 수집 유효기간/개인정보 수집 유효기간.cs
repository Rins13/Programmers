using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(string today, string[] terms, string[] privacies) {
		List<int> answer = new List<int>();
		DateTime dt_Today = DateTime.Parse(today);
		Dictionary<string, int> termDict = new Dictionary<string, int>();
		foreach(string term in terms)
		{
			string[] split = term.Split(' ');
			termDict.Add(split[0], int.Parse(split[1]));
		}

		for(int  i =0; i< privacies.Length;i++)
		{

			string privacy = privacies[i];
			string[] split = privacy.Split(' ');

			DateTime dt_date = DateTime.Parse(split[0]);

			DateTime endTime = dt_date.AddMonths(termDict[split[1]])-new TimeSpan(0,0,1);
			if (dt_Today > endTime)
				answer.Add(i+1);
		}

		return answer.ToArray();

    }
}