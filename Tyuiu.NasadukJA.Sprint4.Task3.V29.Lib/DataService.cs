using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.NasadukJA.Sprint4.Task3.V29.Lib
{
    public class DataService : ISprint4Task3V29
    {
        public int Calculate(int[,] array)
        {
            int rows = array.GetUpperBound(0) + 1;  
            int product = 1;

            for (int i = 0; i < rows; i++)
            {
                product *= array[i, 0]; 
            }

            return product;
        }
    }
}
