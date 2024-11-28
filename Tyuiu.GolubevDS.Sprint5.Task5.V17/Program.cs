using Tyuiu.GolubevDS.Sprint5.Task5.V17.Lib;

DataService ds = new DataService();


Console.WriteLine("******************************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                               *");
Console.WriteLine("* Дан файл 'InPutDataFileTask5V17.txt' в котором есть набор значений.                    *");
Console.WriteLine("* Найти сумму всех простых целых чисел в файле. Полученный результат вывести на консоль. *");
Console.WriteLine("******************************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                       *");
Console.WriteLine("******************************************************************************************");

string path = @"C:\DataSprint5\InPutDataFileTask5V17.txt";

Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("******************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                             *");
Console.WriteLine("******************************************************************************************");

double res = ds.LoadFromDataFile(path);

Console.WriteLine("Сумма элементов файла = " + res);
Console.ReadKey();
