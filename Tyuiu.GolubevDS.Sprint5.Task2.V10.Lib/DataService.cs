namespace Tyuiu.GolubevDS.Sprint5.Task2.V10.Lib;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

public class DataService : ISprint5Task2V10
{
    public string SaveToFileTextData(int[,] matrix)
    {
        string path = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask2.csv";
        FileInfo fileInfo = new FileInfo(path);
        bool fileExists = fileInfo.Exists;
        if (fileExists)
        {
            File.Delete(path);
        }
        using (StreamWriter writer = new StreamWriter(path))
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    
                    int value = matrix[i, j] > 0 ? 1 : 0;
                    writer.Write(value);
                    if (j < matrix.GetLength(1) - 1)
                    {
                        writer.Write(";");  
                    }
                }
                writer.WriteLine();   
            }
        }

        return path;
    }
}
