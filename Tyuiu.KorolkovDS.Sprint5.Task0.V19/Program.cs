using Tyuiu.KorolkovDS.Sprint5.Task0.V19.Lib;
DataService ds = new DataService();
int x = 3;
string path = ds.SaveToFileTextData(x);
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Формула: ((2*Math.Pow(x,2)-1)/(Math.Sqrt(Math.Pow(x,2)-2))) ");

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");

Console.WriteLine($"Результат вычислений сохранен в файл: {path}");
Console.WriteLine($"Содержимое файла: {File.ReadAllText(path)}");

Console.ReadKey();
