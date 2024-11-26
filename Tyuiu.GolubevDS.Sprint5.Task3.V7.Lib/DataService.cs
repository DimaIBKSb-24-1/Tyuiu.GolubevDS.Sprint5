
namespace Tyuiu.GolubevDS.Sprint5.Task3.V7.Lib;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;


public class DataService : ISprint5Task3V7
{
    public string SaveToFileTextData(int x)
    {
        double result = 1.6 * Math.Pow(x, 3) - 2.1 * Math.Pow(x, 2) + 7 * x;

        // Округление результата до трех знаков после запятой  
        string output = Math.Round(result, 3).ToString("F3");

        // Определение пути к файлу  
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.txt");

        // Сохранение результата в текстовый файл  
        File.WriteAllText(path, output);

        // Возвращаем результат в виде строки  
        return output;

    }
}
