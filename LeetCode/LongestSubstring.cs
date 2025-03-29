namespace LeetCode
{
    public class LongestSubstring
    {
        public int LengthOfLongestSubstring(string s)
        {
            var left = 0;
            var right = 0;
            var longest = 0;
            HashSet<char> charSet = new();

            while (right < s.Length)
            {
                if (!charSet.Contains(s[right]))
                {
                    charSet.Add(s[right]);
                    right++;
                    longest = Math.Max(longest, right - left);
                }
                else
                {
                    charSet.Remove(s[left]);
                    left++;
                }
            }

            return longest;
        }
    }
}
