using System.IO;
using System.Text;


using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KorolkovDS.Sprint5.Task3.V26.Lib
{
    public class DataService : ISprint5Task3V26
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Path.GetTempPath()}OutPutFileTask3.bin";
            double y = Math.Round(0.7 * Math.Pow(x,3) + 1.52 * Math.Pow(x,2),3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(path, FileMode.Create),Encoding.UTF8))
            {
                writer.Write(BitConverter.GetBytes(y));
            }
            return path; 
        }
    }
}
