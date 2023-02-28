using System;

public class Solution {
    public long solution(string numbers) {
		string[] nums = new string[] { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
		for(int i = 0; i< 10; i++)
		{
			numbers = numbers.Replace(nums[i], $"{i}");
		}
		return long.Parse(numbers);
    }
}