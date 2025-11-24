using Tyuiu.KorolkovDS.Sprint5.Task1.V12.Lib;

namespace Tyuiu.KorolkovDS.Sprint5.Task1.V12.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

            string FPath = Path.GetTempFileName();
            FileInfo fileInfo = new FileInfo(FPath);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
