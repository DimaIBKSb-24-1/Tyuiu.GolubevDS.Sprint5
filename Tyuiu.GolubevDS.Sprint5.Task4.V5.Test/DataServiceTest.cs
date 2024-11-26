using System.Diagnostics;
using System.Threading.Tasks;
using Tyuiu.GolubevDS.Sprint5.Task4.V5.Lib;

namespace Tyuiu.GolubevDS.Sprint5.Task4.V5.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint5\InPutDataFileTask4V5.txt";

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }

        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();

            string strX = @"C:\DataSprint5\InPutDataFileTask4V5.txt";
            double res = ds.LoadFromDataFile(strX);
            double wait = -127.963;

            Assert.AreEqual(wait, res);
        }
    }
}