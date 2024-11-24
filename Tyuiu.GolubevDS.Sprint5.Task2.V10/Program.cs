using Tyuiu.GolubevDS.Sprint5.Task2.V10.Lib;
DataService ds = new DataService();

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

int[,] matrix = new int[3, 3] { { 4, 3, -3 },
                                           { -5, -6, -3 },
                                           { -7, -9, -9 } };
int rows = matrix.GetUpperBound(0) + 1;
int columns = matrix.Length / rows;

Console.WriteLine("Массив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        Console.Write($"{matrix[i, j]} \t");
    }
    Console.WriteLine();
}

Console.WriteLine();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

string res = ds.SaveToFileTextData(matrix);

Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");

Console.ReadKey();