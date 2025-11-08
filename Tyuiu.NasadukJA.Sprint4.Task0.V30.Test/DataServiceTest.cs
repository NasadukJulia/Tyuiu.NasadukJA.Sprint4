using Tyuiu.NasadukJA.Sprint4.Task0.V30.Lib;

namespace Tyuiu.NasadukJA.Sprint4.Task0.V30.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidGetSumEvenArrEl()
        {
            DataService ds = new DataService();

            int[] numsArray = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };
            int res = ds.GetSumEvenArrEl(numsArray);
            int wait = 30; 

            Assert.AreEqual(wait, res);
        }
    }
}
