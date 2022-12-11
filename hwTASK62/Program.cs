// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

Console.Write("Введите величину ( сторону квадрата ) ");
int m = Convert.ToInt32(Console.ReadLine());
int n = m;
int steps = m * n;
int passedSteps = 1;
int[,] matrix = new int[m, n];
Console.WriteLine("Ваш  спиральный  квадратичный  массив :");
int i = 0, j = 0;
int iStart = 0, iEnd = 0, jStart = 0, jEnd = 0;
while (passedSteps <= steps)
{
    matrix[i, j] = passedSteps;
    
    if (i == iStart && j < m - jEnd - 1)
        ++j;
    else if (j == m - jEnd - 1 && i < n - iEnd - 1)
        ++i;
    else if (i == n - iEnd - 1 && j > jStart)
        --j;
    else
        --i;

    if ((i == iStart + 1) && (j == jStart) && (jStart != m - jEnd - 1))
    {
        ++iStart;
        ++iEnd;
        ++jStart;
        ++jEnd;
    }
    ++passedSteps;
}
for ( i = 0; i < m; i++)
{
    for ( j = 0; j < n; j++)
    {
        Console.Write(matrix[i, j] + "   ");
    }Console.WriteLine();
}
