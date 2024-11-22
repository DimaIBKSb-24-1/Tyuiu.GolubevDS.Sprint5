using Tyuiu.GolubevDS.Sprint5.Task0.V19.Lib;
int x = 3;

DataService ds = new DataService();

Console.WriteLine("********************************************************************************");
Console.WriteLine("* Спринт #5                                                                    *");
Console.WriteLine("* Класс File. Запись данных в текстовый файл                                   *");
Console.WriteLine("* Задание #0                                                                   *");
Console.WriteLine("* Вариант #19                                                                  *");
Console.WriteLine("* Выполнил Голубев Дмитрий Сергеевич | ИБКСб 24-1                              *");
Console.WriteLine("********************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                     *");
Console.WriteLine("* Дано выражение вычислить его значение при x = 3                              *");
Console.WriteLine("* Результат сохранить в текстовый файл OutPutFileTask0.txt                     *");
Console.WriteLine("*                                                                              *");
Console.WriteLine("********************************************************************************");


Console.WriteLine(" x = " + x);

Console.WriteLine("****************************************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                       *");
Console.WriteLine("****************************************************************************************************");

string res = ds.SaveToFileTextData(x);

Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();
