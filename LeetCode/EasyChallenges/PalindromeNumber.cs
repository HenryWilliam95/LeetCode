namespace LeetCode.EasyChallenges
{
    class PalindromeNumber
    {
        public bool IsPalindrome(int x)
        {
            var str = x.ToString();
            var left = 0;
            var right = str.Length - 1;

            while (left < right)
            {
                if (str[left] != str[right])
                    return false;
                else
                {
                    left++;
                    right--;
                }
            }
            return true;
        }
    }
}
