//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.Write("Введите число строк m: ");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число столбцов n: ");
int numberN = Convert.ToInt32(Console.ReadLine());

double[,] InitArray(int m, int n)
{
    double[,] array = new double[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {

            array[i, j] =  Math.Round(rnd.NextDouble() * m,n);

        }
    }
    return array;
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[,] array = InitArray(numberM,numberN);
PrintArray(array);