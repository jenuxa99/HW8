// Задача 54. Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

void Task_54()
{
    Random rand = new Random();
    int rows = rand.Next(3,10);
    int columns = rand.Next(3,10);
    int[,] Array = new int[rows, columns];
    FillArray(Array, 3, 10);
    PrintArray(Array);
    Console.Write(String.Empty);
    SortArray(Array);
    PrintArray(Array);
}

void FillArray(int[,] numbers, int minValue, int maxValue)
{
    maxValue++;
    Random rand = new Random();
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
         {
            numbers[i, j] = rand.Next(minValue, maxValue);
         }
     }
}

void PrintArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{numbers[i, j]}\t");
        }
        Console.WriteLine(String.Empty);
    }
    Console.WriteLine(String.Empty);
}

void SortArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);
    int temp = 0;

    for (int i = 0; i < rows; i++)
    {
        for (int k = 0; k < columns-1; k++)
        {
            for (int j = 0; j < columns-1; j++)
            {
                if (numbers[i, j] < numbers[i, j+1])
                {
                    temp = numbers[i, j+1];
                    numbers[i, j+1] = numbers[i, j];
                    numbers[i, j] = temp;
                }
            }
        }
    }
}
Task_54();



void Task_56()
// Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
{
    Random rand = new Random();
    int rows = rand.Next(3, 10);
    int columns = rand.Next(3, 10);
    int[,] Array = new int[rows, columns];
    FillArray(Array, 3, 10);
    Console.WriteLine("Случайный массив: ");
    PrintArray(Array);

    int[] rowsSum = new int[rows];

    Console.WriteLine("Суммы элементов каждых строк: ");
    for (int i = 0, k = 0, sum = 0; i < rows; i++, k++, sum = 0)
    {
        for (int j = 0; j < columns; j++) sum = sum + Array[i, j];
        rowsSum[k] = sum;
        Console.Write($"{rowsSum[k]} \t");
    }
    Console.WriteLine(String.Empty);

    int minValue = rowsSum[0];
    int index = 0;

    Console.Write("Индекс строки с минимальной суммой элементов: ");
    for (int k = 0; k < rowsSum.Length; k++)
    {
        if (rowsSum[k] < minValue) 
        {
            minValue = rowsSum[k];
            index = k;
        }
    }
    Console.WriteLine(index);
    Console.WriteLine(String.Empty);
    Console.WriteLine("Строка с минимальной суммой элементов: ");

    for (int i = index, j = 0; j < columns; j++)
    {
        Console.Write(Array[index, j] + "\t");
    }
    Console.WriteLine(String.Empty);

}
Task_56();

void Task_58()
// Задача 58. Заполните спирально массив 4 на 4 числами от 1 до 16.
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
{
    int rows = 4;
    int columns = 4;
    int[,] Array = new int[rows, columns];

    FillSpiralArray(Array);
    Console.WriteLine("Спиральный массив: ");
    PrintSpiralArray(Array);
}

void FillSpiralArray(int[,] numbers)
{
    int temp = 1;
    int i = 0;
    int j = 0;

    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);

    while (temp <= rows * columns)
    {
        numbers[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < columns - 1)
            j++;
        else if (i < j && i + j >= rows - 1)
            i++;
        else if (i >= j && i + j > columns - 1)
            j--;
        else
            i--;
    }
}

void PrintSpiralArray(int[,] numbers)
{
    int rows = numbers.GetLength(0);
    int columns = numbers.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            if (numbers[i,j] / 10 <= 0) Console.Write($"0{numbers[i,j]} ");
            else Console.Write($"{numbers[i,j]} ");
        }
        Console.WriteLine();
    }
}
Task_58();