using Tyuiu.GolubevDS.Sprint5.Task4.V5.Lib;

DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан файл InPutDataFileTask4V5.txt в котором есть вещественное значение. *");
Console.WriteLine("* Прочитать значение из файла и подставить вместо Х в формуле.            *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("*         4,26x                                                           *");
Console.WriteLine("*   y = ---------                                                         *");
Console.WriteLine("*         sin(x)                                                          *");
Console.WriteLine("*                                                                         *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = @"C:\DataSprint5\InPutDataFileTask4V5.txt";

Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
double res = ds.LoadFromDataFile(path);
Console.WriteLine(res);
Console.ReadKey();
