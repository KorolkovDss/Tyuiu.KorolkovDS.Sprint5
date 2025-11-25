using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KorolkovDS.Sprint5.Task5.V7.Lib
{
    public class DataService : ISprint5Task5V7
    {
        public double LoadFromDataFile(string path)
        {
            string[] lines = File.ReadAllLines(path);
            bool foundInteger = false;
            int firstInteger = 0;
            double res = 1;
            foreach (var line in lines)
            {

                string[] parts = line.Split(new[] { ' ', 't' }, StringSplitOptions.RemoveEmptyEntries);

                foreach (var part in parts)
                {

                    if (int.TryParse(part, out int number))
                    {
                        if (!foundInteger)
                        {
                            firstInteger = number;
                            foundInteger = true;
                            break;
                        }
                    }
                }
                if (foundInteger) break;
            }
            for (int i = 1; i <= firstInteger; i++)
            {
                res *= i;
            }
            return res;
        }
    }
}
