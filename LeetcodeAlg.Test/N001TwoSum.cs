using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LeetcodeAlg.Test
{
    [TestClass]
    public class N001TwoSum
    {
        public int[] TwoSum(int[] nums, int target)
        {
            Dictionary<int, int> dictionary = new Dictionary<int, int>();

            for (var i = 0; i < nums.Length; i++)
            {
                var result = target - nums[i];
                if (dictionary.ContainsKey(result)) return new int[] {dictionary[result], i};

                if (!dictionary.ContainsKey(nums[i]))
                    dictionary.Add(nums[i], i);
            }

            return new int[] { };
        }

        [TestMethod]
        public void Case_001()
        {
            var nums = new int[] {2, 7, 11, 15};
            var result = TwoSum(nums, 9);

            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(1, result[1]);
        }

        [TestMethod]
        public void Case_002()
        {
            var nums = new int[] {2, 2, 7, 11, 15};
            var result = TwoSum(nums, 9);

            Assert.AreEqual(0, result[0]);
            Assert.AreEqual(2, result[1]);
        }
    }
}