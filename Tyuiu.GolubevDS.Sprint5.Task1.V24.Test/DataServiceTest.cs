namespace Tyuiu.GolubevDS.Sprint5.Task1.V24.Test;
using Tyuiu.GolubevDS.Sprint5.Task1.V24.Lib;
using System.IO;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidSaveToFileTextData()
    {
        string path = @"C:\Users\maska\source\repos\Tyuiu.GolubevDS.Sprint5\Tyuiu.GolubevDS.Sprint5.Task1.V24\bin\Debug\OutPutFileTask1.txt";
        FileInfo fileInfo = new FileInfo(path);
        bool fileExists = fileInfo.Exists;
        bool wait = true;
        Assert.AreEqual(wait, fileExists);
    }
}