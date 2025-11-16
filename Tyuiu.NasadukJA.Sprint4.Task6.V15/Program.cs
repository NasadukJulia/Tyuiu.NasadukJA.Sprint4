using Tyuiu.NasadukJA.Sprint4.Task6.V15.Lib;

// See https://aka.ms/new-console-template for more information
DataService ds = new DataService();

Console.Title = "Спринт #4 | Выполнила: Насадюк Ю. А. | СМАРТб-25-1";

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #4                                                               *");
Console.WriteLine("* Тема:  Класс Array                                                      *");
Console.WriteLine("* Задание #6                                                              *");
Console.WriteLine("* Вариант #15                                                             *");
Console.WriteLine("* Выполнила: Насадюк Юлия Андреевна | СМАРТб-25-1                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан строковый массив данных ['Чикаго','Хьюстон','Феникс','Филадельфия', *");
Console.WriteLine("* 'Сан-Антонио','Сан-Диего','Даллас'] используя класс Array подсчитайте   *");
Console.WriteLine("* количество элементов, длина которых меньше 7.                           *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string[] cities =
        {
            "Чикаго", "Хьюстон", "Феникс", "Филадельфия",
            "Сан-Антонио", "Сан-Диего", "Даллас"
        };

Console.WriteLine("Исходный массив:");
for (int i = 0; i < cities.Length; i++)
{
    Console.WriteLine(cities[i]);
}

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

int res = ds.Calculate(cities);
Console.WriteLine("Количество элементов длина которых < 7 = " + res);

Console.ReadKey();
