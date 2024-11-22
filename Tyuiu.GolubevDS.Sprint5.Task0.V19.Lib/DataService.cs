namespace Tyuiu.GolubevDS.Sprint5.Task0.V19.Lib;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

public class DataService : ISprint5Task0V19
{
    public string SaveToFileTextData(int x)
    {
        string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask0.txt";

        double y = 6.425;
        double result = (2*Math.Pow(x, 2) - 1)/ (Math.Sqrt(Math.Pow(x,2)-2));
        y = Math.Round(result, 3);
        File.WriteAllText(path, y.ToString());
        return path;
        
    }
}
