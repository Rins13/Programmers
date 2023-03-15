public class Solution {
    public string solution(string s, int n) {
		char[] codes = s.ToCharArray();
		for (int i = 0; i < codes.Length; i++)
		{
			if (codes[i] == ' ')
				continue;

			char newCode = (char)(codes[i] + n);

			if ((char.IsUpper(codes[i]) && newCode > 'Z') || (char.IsLower(codes[i]) && newCode > 'z'))
				codes[i] = (char)(newCode - 26);
			else
				codes[i] = newCode;

		}

		return new string(codes);

    }
}