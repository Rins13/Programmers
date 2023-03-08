using System.Linq;

public class Solution {
    public int solution(int[] sides) {
		return 2 * sides.Min() - 1;
    }
}