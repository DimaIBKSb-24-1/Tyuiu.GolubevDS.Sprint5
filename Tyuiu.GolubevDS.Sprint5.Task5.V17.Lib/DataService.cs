namespace Tyuiu.GolubevDS.Sprint5.Task5.V17.Lib;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;

public class DataService : ISprint5Task5V17
{
    public double LoadFromDataFile(string path)
    {
        double sum = 0;

        using (StreamReader reader = new StreamReader(path))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (int.TryParse(line.Trim(), out int number) && IsPrime(number))
                {
                    sum += number;
                }
            }
        }

         
        return Math.Round(sum, 3);
    }

      
    private bool IsPrime(int number)
    {
        if (number <= 1) return false;   
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;  
        }
        return true;
    }
}
