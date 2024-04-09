using System;
using System.Linq;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal)
		{
			if (!IsOrder(cards1, goal) || !IsOrder(cards2, goal))
				return "No";
				
			return "Yes";
		}

		public bool IsOrder(string[] card, string[] goal)
		{
			int count = -1;

			foreach (string str in goal)
			{
				if (card.Contains(str))
				{
					int idx = Array.IndexOf(card, str);
					if (idx - count != 1)
						return false;
					else
						count = idx;
				}
			}

			return true;
		}
}