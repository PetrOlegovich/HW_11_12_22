// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.WriteLine("Введите ПЕРВУЮ матрицу M x N : ");
Console.WriteLine("введите количество линий M :  ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов  N :  ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] a = new int[m, n];
Console.WriteLine("Ваш первая матрица :");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        a[i, j] = new Random().Next(1, 10);
        Console.Write(a[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("------------------------------------");


Console.WriteLine("Введите ВТОРУЮ матрицу M x N : ");
Console.WriteLine("введите количество линий M :  ");
int m1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов  N :  ");
int n1 = Convert.ToInt32(Console.ReadLine());

int[,] b = new int[m1, n1];
Console.WriteLine("Ваша вторая матрица : ");
for (int i = 0; i < m1; i++)
{
    for (int j = 0; j < n1; j++)
    {
        b[i, j] = new Random().Next(1, 10);
        Console.Write(b[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine("-----------------------------------");
Console.WriteLine("Произведение : ");
int[,] c = Multiplication(a, b);


for (int i = 0; i < c.GetLength(0); i++)
{
    for (int j = 0; j < c.GetLength(1); j++)
    {
        Console.Write(c[i, j] + " ");
    }
    Console.WriteLine();

}



static int[,] Multiplication(int[,] a, int[,] b)
{
    int[,] r = new int[a.GetLength(0), b.GetLength(1)];
    for (int i = 0; i < a.GetLength(0); i++)
    {
        for (int j = 0; j < b.GetLength(1); j++)
        {
            for (int k = 0; k < b.GetLength(0); k++)
            {
                r[i, j] += a[i, k] * b[k, j];
            }

        }

    }
    return r;
}