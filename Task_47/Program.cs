// Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.
// m = 3, n = 4
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

void FillArrayRandom(double[,] array, double minValue, double maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0;  j < array.GetLength(1);  j++)
            array[i, j] = new Random().NextDouble() * new Random().Next(-10, 10);
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0;  j < array.GetLength(1);  j++)
            System.Console.Write($"{Math.Round(array[i, j], 1)} ");
        System.Console.WriteLine();
    }
}

System.Console.WriteLine("Введите количество строк");
int m = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов");
int n = int.Parse(Console.ReadLine());

double [,] array = new double [m, n];
FillArrayRandom(array, -9, 10);
PrintArray(array);

