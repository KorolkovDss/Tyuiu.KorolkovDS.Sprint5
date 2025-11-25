using System.IO;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KorolkovDS.Sprint5.Task7.V14.Lib
{
    public class DataService : ISprint5Task7V14
    {
        public string LoadDataAndSave(string path)
        {
            string pathSaveFile = $@"{Directory.GetCurrentDirectory()}\OutPutDataFileTask7V14.txt";

            FileInfo fileInfo = new FileInfo(pathSaveFile);
            bool fileExists = fileInfo.Exists;

            if (fileExists)
            {
                File.Delete(pathSaveFile);
            }

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    line = line.ToUpper();

                    File.AppendAllText(pathSaveFile, line + Environment.NewLine);


                }
            }
            return pathSaveFile;
        }
    }
}
