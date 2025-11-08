using Tyuiu.NasadukJA.Sprint4.Task0.V30.Lib;

// See https://aka.ms/new-console-template for more information
DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Насадюк Ю. А. | СМАРТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема: Одномерные массивы (статический ввод)                             *");
Console.WriteLine("* Задание #0                                                              *");
Console.WriteLine("* Вариант #30                                                             *");
Console.WriteLine("* Выполнила: Насадюк Юлия Андреевна | СМАРТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан одномерный целочисленный массив на 10 элементов заполненный         *");
Console.WriteLine("* статическими значениями в диапазоне от 0 до 9 подсчитать сумму четных   *");
Console.WriteLine("* элементов массива.  {9, 8, 4, 6, 9, 4, 3, 6, 1, 2}                      *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

int[] numsArray = { 9, 8, 4, 6, 9, 4, 3, 6, 1, 2 };

Console.WriteLine("Исходный массив:");
for (int i = 0; i < numsArray.Length; i++)
{
    Console.Write(numsArray[i] + "\t");
}

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine("Сумма чётных элементов массива = " + ds.GetSumEvenArrEl(numsArray));

Console.ReadKey();
