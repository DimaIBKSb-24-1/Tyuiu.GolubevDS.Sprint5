using Tyuiu.GolubevDS.Sprint5.Task3.V7.Lib;
DataService dataService = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* Спринт #5                                                               *");
Console.WriteLine("* Тема: Обработка файлов                                                  *");
Console.WriteLine("* Задание #2                                                              *");
Console.WriteLine("* Вариант #10                                                             *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Написать программу на C#, Дан двумерный целочисленный массив 3 на 3     *");
Console.WriteLine("* элементов, заполненный значениями с клавиатуры. Заменить положительные  *");
Console.WriteLine("* элементы массива на 1, отрицательные на 0. Результат сохранить в файл   *");
Console.WriteLine("* OutPutFileTask2.csv и вывести на консоль.                               *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string result = dataService.SaveToFileTextData(2);

// Выводим результат на консоль  
Console.WriteLine($"Результат: {result}");

// Информация о завершении вычислений  
Console.WriteLine("Вычисление завершено.");
Console.ReadLine();
