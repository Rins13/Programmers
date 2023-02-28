using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers, string direction) {
       	List<int> nums = new List<int>(numbers);
		if(direction == "right")
		{
			nums.Insert(0, numbers[nums.Count - 1]);
			nums.RemoveAt(nums.Count - 1);
		}
		else
		{
			nums.Add(numbers[0]);
			nums.RemoveAt(0);
		}
		return nums.ToArray();
    }
}