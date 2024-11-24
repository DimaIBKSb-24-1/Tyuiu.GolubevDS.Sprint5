namespace Tyuiu.GolubevDS.Sprint5.Task2.V10.Test;
using Tyuiu.GolubevDS.Sprint5.Task2.V10.Lib;
using System.IO;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void SaveToFileTextData()
    {
        string path = @"C:\Users\maska\source\repos\Tyuiu.GolubevDS.Sprint5\Tyuiu.GolubevDS.Sprint5.Task2.V10\bin\Debug\OutPutFileTask2.csv";
        FileInfo fileInfo = new FileInfo(path);
        bool fileExists = fileInfo.Exists;
        bool wait = true;
        Assert.AreEqual(wait, fileExists);
    }
}