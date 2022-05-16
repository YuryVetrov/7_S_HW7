// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в
// каждом столбце.
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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
void Average(int[,] array)
{
    for (int i = 0; i < array.GetLength(1); i++)
    {
        int result = 0;
        for (int j = 0;  j < array.GetLength(0);  j++)
            result = array[j, i] + result;
            Console.Write($"Среднее арифметическое {i + 1} столбца = {(double) result / array.GetLength(0)} ");
            System.Console.WriteLine();
    }
    System.Console.WriteLine();
}
int[,] array = new int[5, 5];
FillArrayRandom(array, -10, 10);
PrintArray(array);
Average(array);






//PrintArray(array);


/*
int[,] arrayFirst = new int[i, j];
FillArrayRandom(arrayFirst, -10, 10);
PrintArray(arrayFirst);
//int[,] arraySecond = 
Average(arrayFirst);
PrintArray(arraySecond);
*/