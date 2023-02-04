// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

//Облегчённая Версия 

System.Console.WriteLine("Введите номер строки.");
int row = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Введите номер столбца.");
int colum = Convert.ToInt32(Console.ReadLine());
int[,] arr = Generate2DArray(3, 4);
Print2DArray(arr);

if (row < arr.GetLength(0) && colum < arr.GetLength(1)) Console.WriteLine($"Элемент с индексом {row},{colum} равен {arr[row, colum]}");
else Console.WriteLine($"Элемента с индексом {row},{colum} в массиве нет");

int[,] Generate2DArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(1, 10);
        }
    }
    return result;
}

void Print2DArray(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            System.Console.Write($"{arr[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
