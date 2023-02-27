using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        return new string((s.ToCharArray()).GroupBy(i => i).Where(g => g.Count() == 1).OrderBy(g => g.Key).Select(g => g.Key).ToArray()); 
    }
}