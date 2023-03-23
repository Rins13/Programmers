public class Solution {
    public string solution(string s) {
		char[] chs = s.ToCharArray();

		int prev = ' ';
		for(int i =0; i<chs.Length;i++)
		{
			if (prev == ' ')
				chs[i] = char.ToUpper(chs[i]);
            else
                chs[i] = char.ToLower(chs[i]);


			prev = chs[i];
		}

		return new string(chs);

    }
}