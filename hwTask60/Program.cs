// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.WriteLine("введите размеры двумерного массива M x N. \nВведите M  :");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N : ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число K : ");
int k = Convert.ToInt32(Console.ReadLine());

int[,,] matrix = new int[n, m, k];
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int f = 0; f < matrix.GetLength(2); f++)
        {
            matrix[i, j, f] = new Random().Next(0, 10);
            Console.Write(matrix[i, j, f] +$"({i},{j},{f}) " );
        }
        Console.WriteLine();

    }
    Console.WriteLine();
}
Console.WriteLine();