using tyuiu.cources.programming.interfaces.Sprint5; 
using System.IO;

namespace Tyuiu.KorolkovDS.Sprint5.Task6.V3.Lib
{
    public class DataService : ISprint5Task6V3
    {
        public int LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);
            int count = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] >= 'a' && str[i] <= 'z' || str[i] >= 'A' && str[i] <= 'Z')
                {
                    count++;

                }
            }
            return count;
        }
    }
}
