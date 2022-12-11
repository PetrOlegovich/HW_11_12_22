// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и 
// выдаёт номер строки с наименьшей суммой элементов: 1 строка


Console.WriteLine("Введите размер двумерного массива M x N : ");
Console.WriteLine("введите количество линий M :  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов  N :  ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = new int[m, n];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        matrix[i, j] = new Random().Next(1, 10);
        Console.Write(matrix[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine(" ^^^ Ваш массив ^^^ ");

int sum = 0;
int index = 0;
for (int i = 0; i < matrix.GetLength(1); i++)
{
    int temp = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        temp += matrix[i, j];
    }
    if (temp > sum)
    {
        sum = temp;
        index = i;
    }
}Console.WriteLine($"НАибольшая сумма элементов в Строке {index+1} равна  {sum}");

int min = sum;
int index1 = 0;
for (int i = 0; i < matrix.GetLength(1); i++)
{
    int temp = 0;
    for (int j = 0; j < matrix.GetLength(0); j++)
    {
        temp += matrix[i, j];
    }
    if (temp < sum)
    {
        min = temp;
        sum = min;
        index1 = i;
    }
}Console.WriteLine($"Наименьшая сумма элементов в Строке {index1+1} равна  {min}");

// долго сидел над этой задачей . почему то работает не так как нужно
// работает только для квадратичного массива . не понимаю в чем загвоздка (((.