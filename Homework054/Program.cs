/*
Задача 54.
Задайте двумерный массив.
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
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
void ArrangeLines(int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
  {
    for (int j = 0; j < array.GetLength(1); j++)
    {
      for (int z = 0; z < array.GetLength(1) - 1; z++)
      {
        if (array[i, z] < array[i, z + 1])
        {
          int buf = array[i, z + 1];
          array[i, z + 1] = array[i, z];
          array[i, z] = buf;
        }
      }
    }
  }
}
int m = GetNumberFromUser("Введите количество (m) строк в массиве");
int n = GetNumberFromUser("Введите количество (n) столбцов в массиве");
int[,] array = generate2DArray(m, n, 100);
print2dArray(array);
Console.WriteLine();
ArrangeLines(array);
print2dArray(array);