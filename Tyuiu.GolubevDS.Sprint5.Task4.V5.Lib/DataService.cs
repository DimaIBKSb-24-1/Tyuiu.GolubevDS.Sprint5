namespace Tyuiu.GolubevDS.Sprint5.Task4.V5.Lib;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;

public class DataService : ISprint5Task4V5
{
    public double LoadFromDataFile(string path)
    {
        string str = File.ReadAllText(path);
        string strX = str.Replace('.', ',');
        double res = (Math.Round(4.26 * (Convert.ToDouble(strX)) / Math.Sin(Convert.ToDouble(strX)), 3));
        return res;
    }
}
