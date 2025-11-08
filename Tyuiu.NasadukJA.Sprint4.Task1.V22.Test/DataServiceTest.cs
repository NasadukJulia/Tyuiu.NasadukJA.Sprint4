using Tyuiu.NasadukJA.Sprint4.Task1.V22.Lib;

namespace Tyuiu.NasadukJA.Sprint4.Task1.V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 8, 5, 4, 4, 3, 9, 9, 9, 3, 4, 4, 9 };
            int res = ds.Calculate(numsArray);
            int wait = 295245;

            Assert.AreEqual(wait, res);
        }
    }
}
