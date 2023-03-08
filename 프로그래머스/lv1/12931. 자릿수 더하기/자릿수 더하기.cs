using System.Linq;

public class Solution {
    public int solution(int n) => n.ToString().ToCharArray().Select(x => x - '0').ToArray().Sum();
}