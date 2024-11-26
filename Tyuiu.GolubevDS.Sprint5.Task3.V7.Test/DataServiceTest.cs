namespace Tyuiu.GolubevDS.Sprint5.Task3.V7.Test;
using Tyuiu.GolubevDS.Sprint5.Task3.V7.Lib;
using System.IO;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        string path = @"C:\Users\maska\source\repos\Tyuiu.GolubevDS.Sprint5\Tyuiu.GolubevDS.Sprint5.Task3.V7\bin\Debug\OutPutFileTask3.bin";
        FileInfo fileInfo = new FileInfo(path);
        bool fileExists = fileInfo.Exists;
        bool wait = true;
        Assert.AreEqual(wait, fileExists);
    }
}