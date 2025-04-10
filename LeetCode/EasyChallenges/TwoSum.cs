namespace LeetCode.EasyChallenges
{
    internal class TwoSumClass
    {
        public int[] TwoSum(int[] nums, int target)
        {
            var hashTable = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                var complementary = target - nums[i];
                if (hashTable.ContainsKey(complementary))
                {
                    return [hashTable[complementary], i];
                }
                else
                {
                    hashTable[nums[i]] = i;
                }
            }

            throw new Exception("Not Found");
        }
    }
}
