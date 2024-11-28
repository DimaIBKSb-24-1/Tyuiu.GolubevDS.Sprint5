namespace Tyuiu.GolubevDS.Sprint5.Task5.V17.Test;
using Tyuiu.GolubevDS.Sprint5.Task5.V17.Lib;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void TestMethod1()
    {
        string path = @"C:\DataSprint5\InPutDataFileTask5V17.txt";

        FileInfo fileinfo = new FileInfo(path);
        bool fileExists = fileinfo.Exists;
        bool wait = true;
        Assert.AreEqual(wait, fileExists);
    }
}