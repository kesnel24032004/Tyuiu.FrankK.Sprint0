using Tyuiu.FrankK.Sprint0.Task2.V0.Lib;
namespace Tyuiu.FrankK.Sprint0.Task2.V0.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var name = "Игорь";
            var res = DataService.GM(name);
            Assert.AreEqual("Привет, Игорь", res);
        }
    }
}
