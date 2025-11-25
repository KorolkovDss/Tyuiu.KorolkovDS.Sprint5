using Tyuiu.KorolkovDS.Sprint5.Task6.V3.Lib;
DataService ds = new DataService();
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");

string path = $@"C:\DataSprint5\InPutDataFileTask6V3.txt";
double res = ds.LoadFromDataFile(path);


Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
Console.WriteLine(res);

Console.ReadKey();