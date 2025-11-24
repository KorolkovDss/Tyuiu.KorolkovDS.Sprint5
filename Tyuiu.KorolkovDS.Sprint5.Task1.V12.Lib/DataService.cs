using tyuiu.cources.programming.interfaces.Sprint5;
using System.IO;

namespace Tyuiu.KorolkovDS.Sprint5.Task1.V12.Lib
{
    public class DataService : ISprint5Task1V12
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string FPath = $@"{Path.GetTempPath()}OutPutFileTask1.txt";
            FileInfo fileInfo = new FileInfo(FPath);
            bool fileExists = fileInfo.Exists;
            if (fileExists)
            {
                File.Delete(FPath);
            }
            double y;
            string strY;
            for (int x = startValue; x < stopValue; x++)
            {
                y = Math.Round(((5 * x + 2.5) / (Math.Sin(x) - 2)) + 2 , 2);
                strY= Convert.ToString(y);
                if (x != stopValue)
                {
                    File.AppendAllText(FPath, strY + Environment.NewLine);
                }
                else
                {
                    File.AppendAllText(FPath, strY);
                }

            }
            return FPath;
        }
    }
}
