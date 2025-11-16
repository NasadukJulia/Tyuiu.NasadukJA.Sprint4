using Tyuiu.NasadukJA.Sprint4.Task5.V23.Lib;

namespace Tyuiu.NasadukJA.Sprint4.Task5.V23.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidCalc()
        {
            DataService ds = new DataService();

            int[,] mas2 = new int[5, 5]
            {
                { -1,  2,  3, -4,  5 },
                {  6, -7,  8,  9, -1 },
                {  2,  3, -2, -3,  7 },
                { -4,  5, -6,  7, -8 },
                {  1, -1,  2,  3, -2 }
            };

            int[,] wait = new int[5, 5]
            {
                { 0, 2, 3, 0, 5 },
                { 6, 0, 8, 9, 0 },
                { 2, 3, 0, 0, 7 },
                { 0, 5, 0, 7, 0 },
                { 1, 0, 2, 3, 0 }
            };

            int[,] res = ds.Calculate(mas2);

            CollectionAssert.AreEqual(wait, res);
        }
    }
}
