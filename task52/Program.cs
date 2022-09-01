/*
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/

System.Console.WriteLine("Введите количество строк ");
int line = int.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов ");
int column = int.Parse(Console.ReadLine());

int[,] array = new int[line, column];

ArrayRandomNumbers(array);
System.Console.Write("Среднее арифметическое каждого столбца: ");

for (int j = 0; j < array.GetLength(1); j++)
{
    double average = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        average = (average + array[i, j]);
    }
    average = average / line;
    System.Console.Write(average + "; ");
}
System.Console.WriteLine();
PrintArray(array);




void ArrayRandomNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
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