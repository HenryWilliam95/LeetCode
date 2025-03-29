using NUnit.Framework;

namespace LeetCode.Tests
{
    [TestFixture]
    internal class TestCases
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

        [TestCase(new[] {2, 7, 11, 15}, 9, new[] {0, 1})]
        [TestCase(new[] { 3, 2, 4 }, 6, new[] {1, 2})]
        [TestCase(new[] { 3, 3 }, 6, new[] {0, 1})]
        public void TwoSumTest(int[] nums, int target, int[]expected)
        {
            var twoSums = new TwoSumClass();
            var output = twoSums.TwoSum(nums, target);

            Assert.That(output, Is.EqualTo(expected));
        }
    }
}
