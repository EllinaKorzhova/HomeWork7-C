/*Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет*/

Console.Write("Введите количество строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] InitArray(int m, int n)
{
    int[,] array = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
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

Console.Write("Введите номер строки: ");
int line = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца: ");
int column = Convert.ToInt32(Console.ReadLine());

if (line > m && column > n)
            {
                Console.WriteLine("такого числа нет");
            }
            else
            {
                int result = array[line-1, column-1];
                Console.WriteLine($"{result}");
            }
