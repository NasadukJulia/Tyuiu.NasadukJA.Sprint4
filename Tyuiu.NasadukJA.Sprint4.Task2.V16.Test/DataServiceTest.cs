using Tyuiu.NasadukJA.Sprint4.Task2.V16.Lib;

namespace Tyuiu.NasadukJA.Sprint4.Task2.V16.Test
{
    [TestClass]
    public sealed class Test1
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            int[] numsArray = { 4, 0, 3, 12, 11 }; 
            int res = ds.Calculate(numsArray);
            int wait = 14; 

            Assert.AreEqual(wait, res);
        }
    }
}
