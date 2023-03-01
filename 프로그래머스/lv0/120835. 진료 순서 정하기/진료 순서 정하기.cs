using System;
using System.Linq;

public class Solution {
    public int[] solution(int[] emergency) {
        int[] sort = emergency.OrderByDescending(x => x).ToArray();
		return emergency.Select(x=> Array.IndexOf(sort, x)+1).ToArray();
    }
}