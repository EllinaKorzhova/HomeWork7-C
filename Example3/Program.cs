
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

int[] sum = new int[n];
void SearchArithmetic(int[,] array){

for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum [i] += array[j,i];
        }
    }
foreach (double elem in sum)
            {
                Console.Write($"{elem/m} "); 
            }
}
SearchArithmetic(array);