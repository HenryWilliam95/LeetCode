namespace LeetCode.EasyChallenges
{
    internal class ContainsDuplicates
    {
        public bool Solution(int[] nums)
        {
            var hashTable = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if(hashTable.ContainsKey(nums[i]))
                    return true;
                else 
                    hashTable.Add(nums[i], i);
            }

            return false;
        }
    }
}
