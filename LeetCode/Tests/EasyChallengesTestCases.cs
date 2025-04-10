using LeetCode.EasyChallenges;
using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture]
    internal class EasyChallengesTestCases
    {
        [TestCase("abcabcbb", 3)]
        [TestCase("bbbbb", 1)]
        [TestCase("pwwkew", 3)]
        [TestCase("", 0)]
        public void LongestSubstringTest(string s, int expected)
        {
            var substring = new LongestSubstring();
            var output = substring.LengthOfLongestSubstring(s);

            Assert.That(output, Is.EqualTo(expected));
        }

        [TestCase(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [TestCase(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
        [TestCase(new[] { 3, 3 }, 6, new[] { 0, 1 })]
        public void TwoSumTest(int[] nums, int target, int[] expected)
        {
            var twoSums = new TwoSumClass();
            var output = twoSums.TwoSum(nums, target);

            Assert.That(output, Is.EqualTo(expected));
        }

        // TODO: Needs major improvements on this test
        [TestCase(2, 4, 3, 5, 6, 4, new int[] { 7, 0, 8 })]
        public void AddTwoNumbersTest(int num1, int num2, int num3, int num4, int num5, int num6, int[] expected)
        {
            var list1 = new ListNode(num1, new ListNode(num2, new ListNode(num3)));
            var list2 = new ListNode(num4, new ListNode(num5, new ListNode(num6)));

            var addTwoNumbers = new AddTwoNumbers();
            var output = addTwoNumbers.AddTwoNumbersMethod(list1, list2);

            var result = new List<int>();

            while (output != null)
            {
                result.Add(output.val);
                output = output.next;
            }

            result.ToArray();

            Assert.That(result, Is.EqualTo(expected));
        }

        [TestCase("kayak", true)]
        [TestCase("Henry", false)]
        [TestCase("Henry!", false)]
        [TestCase("A man, a plan, a canal: Panama", true)]
        public void PalindromeTest(string s, bool expected)
        {
            var palindrome = new Palindrome();
            var output = palindrome.IsPalindrome(s);

            Assert.That(output, Is.EqualTo(expected));
        }

        [TestCase(new int[] { 7, 1, 5, 3, 6, 4 }, 5)]
        [TestCase(new int[] { 7, 6, 4, 3, 1 }, 0)]
        public void MaxProfitTest(int[] prices, int expected)
        {
            var maxProfit = new BestDayToBuyAndSellStock();
            var output = maxProfit.MaxProfit(prices);

            Assert.That(output, Is.EqualTo(expected));
        }

        [TestCase(121, true)]
        [TestCase(12, false)]
        [TestCase(1221, true)]
        [TestCase(111, true)]
        [TestCase(12345, false)]
        public void PalindromeNumberTest(int x, bool expected)
        {
            var palindrome = new PalindromeNumber();
            var output = palindrome.IsPalindrome(x);

            Assert.That(output, Is.EqualTo(expected));
        }

        [TestCase("III", 3)]
        [TestCase("IV", 4)]
        [TestCase("X", 10)]
        [TestCase("MMCD", 2400)]
        [TestCase("MMCDII", 2402)]
        public void RomanToIntTest(string romanNumerals, int expected)
        {
            var romanConverter = new RomanToInt();
            var output = romanConverter.Convert(romanNumerals);

            Assert.That(output, Is.EqualTo(expected));
        }

        [TestCase(new string[] {"flower", "flow", "flight"}, "fl")]
        [TestCase(new string[] { "dog", "racecar", "car" }, "")]
        public void LongestCommonPrefixTest(string[] array, string expected)
        {
            var longestCommonPrefix = new LongestCommonPrefix();
            var output = longestCommonPrefix.Solution(array);

            Assert.That(output, Is.EqualTo(expected));
        }

        [TestCase("()[]{}", true)]
        [TestCase(")[]{}", false)]
        [TestCase("({[]})", true)]
        public void ValidParanthesesTest(string input, bool expected)
        {
            var validParantheses = new ValidParantheses();
            var output = validParantheses.Solution(input);

            Assert.That(output, Is.EqualTo(expected));
        }

        [TestCase(new int[] { 1, 2, 3, 1}, true)]
        [TestCase(new int[] { 1, 3, 3, 1}, true)]
        [TestCase(new int[] { 1, 2, 3, 4}, false)]
        public void ContainsDuplicates(int[] input, bool expected)
        {
            var containsDuplicates = new ContainsDuplicates();
            var output = containsDuplicates.Solution(input);

            Assert.That(output, Is.EqualTo(expected));
        }
    }
}
