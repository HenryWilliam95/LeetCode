namespace LeetCode.EasyChallenges
{
    internal class LongestCommonPrefix
    {
        public string Solution(string[] strs)
        {
            if(strs.Length == 0)
            {
                return "";
            }

            var baseWord = strs[0];
            for (int i = 0; i < baseWord.Length; i++)
            {
                foreach (string str in strs) 
                {
                    if (i == str.Length || str[i] != baseWord[i])
                    {
                        return baseWord[..i];
                    }
                }
            }

            return baseWord;
        }
    }
}
