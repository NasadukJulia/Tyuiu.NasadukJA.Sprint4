using Tyuiu.NasadukJA.Sprint4.Task5.V23.Lib;

// See https://aka.ms/new-console-template for more information
DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Насадюк Ю. А. | СМАРТб-25-1";

Random rnd = new Random();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Двумерные массивы (генератор случайных чисел)                     *");
Console.WriteLine("* Задание #5                                                              *");
Console.WriteLine("* Вариант #23                                                             *");
Console.WriteLine("* Выполнила: Насадюк Юлия Андреевна | СМАРТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан двумерный целочисленный массив 5 на 5 элементов, заполненный        *");
Console.WriteLine("* случайными значениями в диапазоне от -4 до 8. Заменить отрицательные    *");
Console.WriteLine("* элементы на 0.                                                          *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

Console.Write("Введите количество строк массива: ");
int rows = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] mtrx = new int[rows, columns];

Console.WriteLine("***************************************************************************");

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        mtrx[i, j] = rnd.Next(-4, 9);
        Console.Write(mtrx[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int[,] res = ds.Calculate(mtrx);

for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write(res[i, j] + "\t");
    }
    Console.WriteLine();
}

Console.ReadKey();
