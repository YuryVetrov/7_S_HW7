// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве
// и возвращает значение этого массива или же указание, что такого элемента нет
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет
void FillArrayRandom(int[,] array, int minValue, int maxValue)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0;  j < array.GetLength(1);  j++)
            array[i, j] = new Random().Next(minValue, maxValue);
    }
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0;  j < array.GetLength(1);  j++)
            System.Console.Write($"{array[i, j], 4}"); 
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
void SearchArray(int[,] array, int row, int column)
{
    if (row -1 > array.GetLength(0) || column -1 > array.GetLength(1))
    System.Console.WriteLine("Такого числа в массиве нет");
    else
    System.Console.WriteLine($"Искомое число в массиве = {array[row -1, column -1]}");
}
Console.WriteLine("Введите позицию строки искомого элемента двумерного массива");
int row = int.Parse(Console.ReadLine());
Console.WriteLine("Введите позицию столбца искомого элемента двумерного массива");
int column = int.Parse(Console.ReadLine());
int[,] array = new int[row, column];
FillArrayRandom(array, -10, 10);
PrintArray(array);
SearchArray(array, row, column);


