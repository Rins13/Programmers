public class Solution {
    public string solution(string s) {
		int idx = 0;
		char[] chs = s.ToCharArray();

		for(int i = 0; i< chs.Length;i++)
		{
			if (chs[i] == ' ')
			{
				idx = 0;
				continue;
			}
			else if (idx % 2 == 0)
				chs[i] = char.ToUpper(chs[i]);
            else
			chs[i] = char.ToLower(chs[i]);

			idx++;
		}
		return new string(chs);

    }
}