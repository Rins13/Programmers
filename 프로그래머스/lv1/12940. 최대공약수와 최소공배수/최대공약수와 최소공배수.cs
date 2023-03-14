public class Solution {
    public int[] solution(int n, int m)
    {
		// 최대 공약수
		int min = gcd(n, m);

		//  최대 공배수 (두 수의 곱 / 최대공약수(gcd))
		int max = (n * m) / min;

		return new int[] {min, max};
	}

	/// <summary>
	///  최대 공약수 (유클리드 호제법)
	/// </summary>
	static int gcd(int n, int m)
	{
		if (m == 0) return n;
		else return gcd(m, n % m);
	}
}