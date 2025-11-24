using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KorolkovDS.Sprint5.Task4.V3.Lib
{
    public class DataService : ISprint5Task4V3
    {
        public double LoadFromDataFile(string path)
        {
            double x = Convert.ToDouble (File.ReadAllText(path).Replace(".",","));
            double res = Math.Round((Math.Sin(x)+4)/x ,3);
            return res;            
        }
    }
}
