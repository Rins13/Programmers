public class Solution {
    public int solution(string[] babbling) {
		string[] strs = new string[] { "aya", "ye", "woo", "ma" };

		int answer = 0;
		for (int i =0; i< babbling.Length;i++)
		{
			for (int j = 0; j < strs.Length; j++)
			{
				babbling[i] = babbling[i].Replace(strs[j], j.ToString());
			}
            
            if (!int.TryParse(babbling[i], out int temp))
			    continue;


			char prev = ' ';
			bool isPass = true;
			foreach(char ch in babbling[i])
			{
				if (ch == prev)
					isPass = false;

				prev = ch;

			}

			if (isPass)
				answer++;
		}
		
		return answer;

    }
}