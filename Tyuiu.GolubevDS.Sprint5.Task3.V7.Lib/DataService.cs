
namespace Tyuiu.GolubevDS.Sprint5.Task3.V7.Lib;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;


public class DataService : ISprint5Task3V7
{
    public string SaveToFileTextData(int x)
    {
        double result = 1.6 * Math.Pow(x, 3) - 2.1 * Math.Pow(x, 2) + 7 * x;

          
        string output = Math.Round(result, 3).ToString("F3");

          
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

          
        using (FileStream fs = new FileStream(path, FileMode.Create, FileAccess.Write))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
            writer.Write(output);
        }

        
        Console.WriteLine(output);

        
        return path;

    }
}
