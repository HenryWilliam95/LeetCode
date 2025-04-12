using NUnit.Framework.Constraints;

public class MinimumOperationsArray {
    public int Solution(int[] nums, int k) {
        var hashSet = new HashSet<int>();

        foreach(var item in nums)
        {
            if(item < k) return -1;
            if(item > k) hashSet.Add(item);
        }

        return hashSet.Count;
    }
}