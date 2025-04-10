namespace LeetCode.EasyChallenges;

public class Palindrome
{
    public bool IsPalindrome(string s)
    {
        var left = 0;
        var right = s.Length - 1;

        s = s.ToLower();

        while (left < right)
        {
            while (left < right && !char.IsLetterOrDigit(s[left]))
            {
                left++;
            }

            while (left < right && !char.IsLetterOrDigit(s[right]))
            {
                right--;
            }

            if (s[left] == s[right])
            {
                left++;
                right--;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
}
