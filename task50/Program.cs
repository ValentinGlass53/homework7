/*
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
Например, задан массив:

1 4 7 2
5 9 2 3
8 4 2 4

17 -> такого числа в массиве нет
*/

System.Console.WriteLine("Введите номер строки  ");
int line = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите номер столбца ");
int column = int.Parse(Console.ReadLine());

int[,] array = new int[4, 4];
ArrayRandomNumbers(array);

if (line > array.GetLength(0) || column > array.GetLength(1))
{
    System.Console.WriteLine("Такого числа в массиве нет ");
}
else
{
System.Console.WriteLine($"Число в {line} строке и в {column} столбце ровно {array[line -1, column -1]}");
}

PrintArray(array);



void ArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-100, 100);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        System.Console.Write("[ ");
        System.Console.Write(" ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write(array[i, j] + " ");
        }

        System.Console.Write("] ");
        System.Console.WriteLine(" ");
    }
}