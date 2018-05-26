using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeAlg.Test
{
    [TestClass]
    public class N001TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            System.Collections.Hashtable hash = new System.Collections.Hashtable();
            for (int i = 0; i < nums.Length; i++)
            {
                if (hash.Contains(target - nums[i]))
                {
                    return new int[] { (int)hash[target - nums[i]], i };
                }
                if (!hash.Contains(nums[i]))
                    hash.Add(nums[i], i);
            }

            return new int[] { };
        }

        [TestMethod]
        public void Case_001()
        {
            var nums = new int[] { 2, 7, 11, 15 };
            var result = TwoSum(nums, 9);

            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }
    }
}