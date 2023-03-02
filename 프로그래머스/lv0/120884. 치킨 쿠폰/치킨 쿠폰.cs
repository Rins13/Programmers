using System;

public class Solution {
    public int solution(int chicken) {
        int service = 0;
		int coupon = chicken;

		while (coupon > 9)
		{
			int addService = coupon / 10;
			coupon = coupon % 10 + addService;
			service += addService;
		}

		return service;
    }
}