using Tyuiu.KorolkovDS.Sprint5.Task2.V2.Lib;
DataService ds  = new DataService();
int[,] matrix = new int[3, 3] { { -7, 7, 5 }, 
                                { 4, 2, -7 }, 
                                { 2, 6, -4 } };
int rows = matrix.GetUpperBound(0) + 1;
int cols = matrix.Length / rows;
Console.WriteLine("***************************************************************************");
Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                        *");
Console.WriteLine("***************************************************************************");
Console.WriteLine("Массив: ");
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < cols; j++)
    {
        Console.Write($"{matrix[i, j]}\t");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("***************************************************************************");
Console.WriteLine("* РЕЗУЛЬТАТ:                                                              *");
Console.WriteLine("***************************************************************************");
string res = ds.SaveToFileTextData(matrix);

Console.WriteLine("Файл: " + res);
Console.WriteLine("Создан!");
Console.ReadKey();