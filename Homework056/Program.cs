/*
Задача 56.
Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/
int GetNumberFromUser(string message)
{
    int number = 0;
    Console.Write(message);
    number = Convert.ToInt32(Console.ReadLine());
    return number;
}
int[,] generate2DArray(int lengthRow, int lengthCol, int deviation)
{
    int[,] array = new int[lengthRow, lengthCol];
    for (int i = 0; i < lengthRow; i++)
    {
        for (int j = 0; j < lengthCol; j++)
        {
            array[i, j] = new Random().Next(-deviation, deviation + 1);
        }
    }
    return array;
}
void print2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int FindSumOfRow(int[,] array, int i)
{
    int sumOfRow = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sumOfRow += array[i, j];
    }
    return sumOfRow;
}
int FindMinRow(int[,] array)
{
    int minSum = 0;
    int sumOfRow = FindSumOfRow(array, 0);
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int buf = FindSumOfRow(array, i);
        if (sumOfRow > buf)
        {
            sumOfRow = buf;
            minSum = i;
        }

    }
    return minSum;
}
int m = GetNumberFromUser("Введите количество (m) строк в массиве: ");
int n = GetNumberFromUser("Введите количество (n) столбцов в массиве: ");
if (n > m)
{
    int buf = n - m;
    n = n - buf - 1;
}
int[,] array = generate2DArray(m, n, 100);
print2dArray(array);
Console.WriteLine();
int row = FindMinRow(array);
Console.WriteLine($"Строка с наименьшей суммой элементов это: {row + 1} строка");