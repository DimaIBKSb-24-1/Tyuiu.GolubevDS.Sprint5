using Tyuiu.GolubevDS.Sprint5.Task7.V18.Lib;
DataService ds = new DataService();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* УСЛОВИЕ:                                                                *");
Console.WriteLine("* Дан файл, в котором есть набор символьных данных. Заменить все буквы н   *");
Console.WriteLine("* на нн. Полученный результат сохранить в файл.                           *");
Console.WriteLine("***************************************************************************");

// Указываем путь к исходному файлу  
string inputPath = Path.Combine(Directory.GetCurrentDirectory(), "InPutDataFileTask7V18.txt");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("Данные находятся в файле: " + inputPath);
Console.WriteLine("***************************************************************************");

// Обработка данных  
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

// Загружаем данные и сохраняем результат  
string outputPath = ds.LoadDataAndSave(inputPath);
Console.WriteLine("Находится в файле: " + outputPath);

Console.WriteLine("***************************************************************************");
Console.WriteLine("Нажмите любую клавишу для выхода...");
Console.ReadKey();