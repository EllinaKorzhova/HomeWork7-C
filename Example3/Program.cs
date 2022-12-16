
/*Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.*/

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] InitArray(int i, int j)
{
    int[,] array = new int[i, j];
    Random rnd = new Random();
    for ( i = 0; i < array.GetLength(0); i++)
    {
        for ( j = 0; j < array.GetLength(1); j++)
        {

            array[i, j] = rnd.Next(0,21);

        }
    }
    return array;
}
void PrintArray(int[,] array)
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
int[,] array = InitArray(m,n);
PrintArray(array);
Console.WriteLine();


void SearchArithmetic(int[,] array){
int[] sum = new int[array.GetLength(0)];
int l = 0;
for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            sum[j] += array[i,j];
        }
    }
    int m = 0;
    while (l <= array.GetLength(0)){
        double res = Convert.ToDouble(sum[m])/Convert.ToDouble(n);
        Console.WriteLine($"Среднее арифметическое столбца {l + 1}: {res} ");
        l ++;
        m ++;
    }
}

SearchArithmetic(array);