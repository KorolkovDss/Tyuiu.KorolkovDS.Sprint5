using Tyuiu.KorolkovDS.Sprint5.Task2.V2.Lib;

namespace Tyuiu.KorolkovDS.Sprint5.Task2.V2.Test
{
    [TestClass]
    public sealed class DataServiceTEST
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
    
}
