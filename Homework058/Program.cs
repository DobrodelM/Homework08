/*
Задача 58.
Задайте две матрицы.
Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/
int GetNumberFromUser(string message)
{
    int number = 0;
    Console.WriteLine(message);
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
int[,] MatrixMultiplication(int[,] array1, int[,] array2)
{

    int[,] newArray = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int i = 0; i < array1.GetLength(0); i++)
    {
        for (int j = 0; j < array2.GetLength(1); j++)
        {
            for (int z = 0; z < array2.GetLength(0); z++)
            {
                newArray[i, j] += array1[i, z] * array2[z, j];
            }
        }
    }
    return newArray;
}
int R = GetNumberFromUser("Введите порядок квадратной матрицы (R)");
Console.WriteLine();
int n = R;
int m = R;
int[,] array1 = generate2DArray(n, m, 10);
int[,] array2 = generate2DArray(n, m, 10);
print2dArray(array1);
Console.WriteLine();
print2dArray(array2);
Console.WriteLine("Результирующая матрица будет:");
int[,] multMatrix = MatrixMultiplication(array1, array2);
print2dArray(multMatrix);