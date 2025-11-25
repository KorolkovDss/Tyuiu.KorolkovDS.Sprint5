using Tyuiu.KorolkovDS.Sprint5.Task7.V14.Lib;
DataService ds  = new DataService();
Console.WriteLine("*****************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                          *");
Console.WriteLine("*****************************************************************************");

string path = $@"{Directory.GetCurrentDirectory()}\InPutDataFileTask7V14.txt";
string pathSaveFile = Path.Combine("OutPutDataFileTask7V14.txt");

Console.WriteLine("Данные находятся в файле: " + path);

Console.WriteLine("*****************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                                *");
Console.WriteLine("*****************************************************************************");
Console.WriteLine("Находится в файле: ");
pathSaveFile = ds.LoadDataAndSave(path);
Console.WriteLine(pathSaveFile);
Console.ReadKey();