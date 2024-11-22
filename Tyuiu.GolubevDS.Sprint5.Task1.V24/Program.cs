using Tyuiu.GolubevDS.Sprint5.Task1.V24.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Класс File. Запись набора данных в текстовый файл                 *");
Console.WriteLine("* Задание #1                                                              *");
Console.WriteLine("* Вариант #24                                                             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дана функция, (произвести табулирование) f(x) на заданном диапазоне     *");
Console.WriteLine("* [-5;5] с шагом 1. Произвести проверку деления на 0. При делении на 0    *");
Console.WriteLine("* вернуть значение 0.                                                     *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
int startValue = -5;
int stopValue = 5;
Console.WriteLine("startValue = " + startValue);
Console.WriteLine("stopValue = " + stopValue);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
string res = ds.SaveToFileTextData(startValue, stopValue);

Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();
