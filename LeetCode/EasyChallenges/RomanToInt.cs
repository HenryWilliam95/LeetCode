namespace LeetCode.EasyChallenges
{
    internal class RomanToInt
    {
        public int Convert(string s)
        {
            var total = 0;

            var roman = new Dictionary<char, int>
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };


            for (int i = 0; i < s.Length - 1; i++)
            {

                if (roman[s[i]] < roman[s[i + 1]])
                {
                    total -= roman[s[i]];
                }
                else
                {
                    total += roman[s[i]];
                }
            }

            return total + roman[s[s.Length - 1]];
        }
    }
}
