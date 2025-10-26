using Tyuiu.FrankK.Sprint0.Task7.V0.Lib;
namespace Tyuiu.FrankK.Sprint0.Task7.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void CheckAdditionArraysValid()
        {
            int[] nums1 = { 1, 1, 1, 1, 1 };
            int[] nums2 = { 2, 2, 2, 2, 2 };
            int[] nums3 = { 3, 3, 3, 3, 3 };

            int[] res = DataService.AdditionArrays(nums1, nums2);
            CollectionAssert.AreEquivalent(nums3, res);
        }
    }
}