namespace Tyuiu.GolubevDS.Sprint5.Task7.V18.Test;

[TestClass]
public class DataServiceTest
{
    [TestMethod]
    public void CheckedExistsFile()
    {
        string path = @"C:\DataSprint5\InPutDataFileTask7V18.txt";

        FileInfo fileinfo = new FileInfo(path);
        bool fileExists = fileinfo.Exists;
        bool wait = true;
        Assert.AreEqual(wait, fileExists);
        
    }
}