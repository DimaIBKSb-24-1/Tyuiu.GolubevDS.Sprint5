using Tyuiu.GolubevDS.Sprint5.Task2.V10.Lib;

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

int[,] matrix = new int[3, 3];


Console.WriteLine("Введите элементы массива 3x3 (разделяйте значения с помощью пробела):");
for (int i = 0; i < 3; i++)
{
    string[] input = Console.ReadLine().Split(new char[] { ' ', ';' }, StringSplitOptions.RemoveEmptyEntries);
    for (int j = 0; j < 3; j++)
    {
        matrix[i, j] = int.Parse(input[j]);
    }
}


DataService dataService = new DataService();
string filePath = dataService.SaveToFileTextData(matrix);


Console.WriteLine("Результат преобразования:");
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        int value = matrix[i, j] > 0 ? 1 : 0;
        Console.Write(value);
        if (j < matrix.GetLength(1) - 1)
            Console.Write(";"); 
    }
    Console.WriteLine();
}

Console.WriteLine($"Данные сохранены в файл: {filePath}");