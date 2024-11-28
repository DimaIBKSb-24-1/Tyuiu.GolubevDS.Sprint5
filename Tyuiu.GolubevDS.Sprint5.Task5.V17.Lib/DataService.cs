namespace Tyuiu.GolubevDS.Sprint5.Task5.V17.Lib;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;

public class DataService : ISprint5Task5V17
{
    public double LoadFromDataFile(string path)
    {
        double res = 0;
        using (StreamReader reader = new StreamReader(path))
        {
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                string lineReplace = line.Replace('.', ',');
                string[] lineArray = lineReplace.Split(' ');

                foreach (string number in lineArray)
                {
                    double lineParse = double.Parse(number);
                    if (lineParse > 0)
                    {
                        res = res + lineParse;
                    }
                }
            }
        }
        return Math.Round(res, 3);
    }
}
