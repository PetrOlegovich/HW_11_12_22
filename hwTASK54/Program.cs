// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.WriteLine("Введите размер двумерного массива M x N : ");
Console.WriteLine("введите количество линий M :  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов  N :  ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(" ^^^ Ваш массив ^^^ ");
Console.WriteLine("Сортировка по строкам: ");
int[] row = new int[n];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
        row[j] = matrix[i, j];
    BubbleSort(row);
    Insert(true, i, row, matrix);
}
PrintArray(matrix);


void Insert(bool isRow, int dim, int[] source, int[,] dest)
{
    for (int k = 0; k < source.Length; k++)
    {
        if (isRow)
            dest[dim, k] = source[k];
        else
            dest[k, dim] = source[k];
    }
}

void BubbleSort(int[] inArray)
{
    for (int i = 0; i < inArray.Length; i++)
        for (int j = 0; j < inArray.Length - i - 1; j++)
        {
            if (inArray[j] < inArray[j + 1])
            {
                int temp = inArray[j];
                inArray[j] = inArray[j + 1];
                inArray[j + 1] = temp;
            }
        }
}
void PrintArray(int[,] array)
{
    for (int a = 0; a < array.GetLength(0); a++)
    {
        for (int b = 0; b < array.GetLength(1); b++)
        {
            Console.Write(array[a, b] + " ");
        }
        Console.WriteLine();
    }
}