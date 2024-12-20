﻿
namespace Tyuiu.GolubevDS.Sprint5.Task3.V7.Lib;
using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;
using System.Text;

public class DataService : ISprint5Task3V7
{
    public string SaveToFileTextData(int x)
    {
        string path = Path.Combine(Path.GetTempPath(), "OutPutFileTask3.bin");

        double y = (1.6 * (Math.Pow(x, 3)) - 2.1 * (Math.Pow(x, 2)) + 7 * x);


            y = Math.Round(y, 3);

            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.OpenOrCreate), Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }

            return path;

    }
}
