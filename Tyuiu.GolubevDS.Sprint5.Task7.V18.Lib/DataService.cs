namespace Tyuiu.GolubevDS.Sprint5.Task7.V18.Lib;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;

public class DataService : ISprint5Task7V18
{
    public string LoadDataAndSave(string path)
    {
        string pathSaveFile = Path.Combine(Path.GetTempPath(), "OutPutFileTask7.txt");

        // Проверяем, существует ли файл, и удаляем его, если он существует  
        if (File.Exists(pathSaveFile))
        {
            File.Delete(pathSaveFile);
        }

        using (StreamReader reader = new StreamReader(path))
        using (StreamWriter writer = new StreamWriter(pathSaveFile, true)) //true для добавления  
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Заменяем все 'н' на 'нн'  
                string modifiedLine = line.Replace("н", "нн");
                // Записываем результат в выходной файл  
                writer.WriteLine(modifiedLine);
            }
        }

        return pathSaveFile;
    }
}
