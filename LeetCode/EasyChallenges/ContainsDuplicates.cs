﻿namespace LeetCode.EasyChallenges
{
    internal class ContainsDuplicates
    {
        public bool Solution(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] == nums[j])
                        return true;
                }
            }

            return false;
        }
    }
}
