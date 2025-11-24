using Tyuiu.KorolkovDS.Sprint5.Task0.V19.Lib;

namespace Tyuiu.KorolkovDS.Sprint5.Task0.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            int x = 3;
             
            string path = ds.SaveToFileTextData(x);
            Assert.IsTrue(File.Exists(path));

            string res = File.ReadAllText(path);
            double value = Convert.ToDouble(res);

            double wait = Math.Round(((2 * Math.Pow(x, 2) - 1) / (Math.Sqrt(Math.Pow(x, 2) - 2))),3);
           
            Assert.AreEqual(wait, value);   

        }
    }
}
