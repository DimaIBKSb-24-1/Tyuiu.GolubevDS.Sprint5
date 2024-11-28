namespace Tyuiu.GolubevDS.Sprint5.Task6.V25.Test;
using Tyuiu.GolubevDS.Sprint5.Task6.V25.Lib;

[TestClass]
public class DataServiceTest

{
    [TestMethod]
    public void ValidCalc()
    {
        DataService ds = new DataService();
        string path = @"C:\DataSprint5\InPutDataFileTask6V25.txt";

        var res = ds.LoadFromDataFile(path);
        int wair = 6;
        Assert.AreEqual(wair, res);
    }

    [TestMethod]
    public void CheckedExistsFile()
    {
        string path = @"C:\DataSprint5\InPutDataFileTask6V25.txt";

        FileInfo fileinfo = new FileInfo(path);
        bool fileExists = fileinfo.Exists;
        bool wait = true;
        Assert.AreEqual(wait, fileExists); 
    }
}