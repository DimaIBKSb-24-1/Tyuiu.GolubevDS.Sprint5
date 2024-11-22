namespace Tyuiu.GolubevDS.Sprint5.Task0.V19.Test;
using Tyuiu.GolubevDS.Sprint5.Task0.V19.Lib;
using System.IO;


[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void ValidSaveToFileTextData()
    {
        string part = @"C:\Users\maska\source\repos\Tyuiu.GolubevDS.Sprint5\Tyuiu.GolubevDS.Sprint5.Task0.V19\bin\Debug\OutPutFileTask0.txt";
        FileInfo fileInfo = new FileInfo(part);
        bool fileExists = fileInfo.Exists;
        bool wait = true;
        Assert.AreEqual(wait, fileExists);
    }
}